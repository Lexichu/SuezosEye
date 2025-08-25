using Microsoft.Win32;
using PeNet;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
//using SuezosEye.Forms;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using System.Text;

//using Octokit;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

// For my own reference;
// condensed, single operation if/else work like so.
//
// "is this condition true ? yes : no"

namespace SuezosEye
{

    public enum EEMemType
    {
        None = -1, // unloaded
        Static = 0, // PCSX2 1.6.0 (...for those three people using 1.6.0.)
        Dynamic = 1 // PCSX2 1.7.x to present
    }

    public partial class SEMain : Form
    {
        public SEMain()
        {
            InitializeComponent();
            PCSX2Type = EEMemType.None;
            MoveSlotID.SelectedIndex = 0;
            EmulatorSelector.SelectedIndex = 1;
        }

        const int PROCESS_ALLACCESS = 0x1F0FFF;

        [LibraryImport("kernel32.dll", SetLastError = true)]
        internal static partial IntPtr OpenProcess(int dwDesiredAccess, [MarshalAs(UnmanagedType.Bool)] bool bInheritHandle, int dwProcessId);
        // Add Read/WriteProcessMemory definitions from P/Invoke
        [LibraryImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static partial bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, [Out] byte[] lpBuffer, int dwSize, out IntPtr lpNumberOfBytesRead);
        [LibraryImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static partial bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, [In] byte[] lpBuffer, Int32 nSize, out IntPtr lpNumberOfBytesWritten);
        // Used to access 64bit modules from a 32bit application
        [LibraryImport("psapi.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static partial bool EnumProcessModules(IntPtr hProcess, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U4)][In][Out] uint[] lphModule, uint cb, [MarshalAs(UnmanagedType.U4)] out uint lpcbNeeded);

        public IntPtr PS2Base = IntPtr.Zero;
        public IntPtr psxPTR;
        public EEMemType PCSX2Type;
        public bool bAttached;
        IntPtr RPMreadcount; // I just use this so ReadProcessMemory stops complaining.
        Process? PS2Process;
        public byte[] ScratchData = new byte[8];
        public byte[] NameArray = new byte[24]; //bedeg
        public byte[] BigArray = new byte[64];
        public byte MRVersion = 255; // 0 = MF3, 1 = MR3 1.0, 2 = MR3 1.1, 255 = not MR3

        public string[] GenusNames = ["Suezo","Mocchi","Jell","Octopee","Momo","Golem","Zuum","Tiger","Hare","Mew","Beaclon","Dragon","Ducken","Baku","Pixie","Durahan","Naga","Joker","Colorpandora","Plant",
        "Henger","Zan","Lesione","Suzurin","Psiroller","Pancho","Mogi","Raiden","Gitan","Ogyo", "---"];
        public string[] ShortMonths = ["---", "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"]; // catch case at start because months are 1-start not 0-start.
        public string[] LifeTypes = ["0: Precocious (Str.)", "1: Precocious (Mild)", "2: Standard", "3: Late Bloom (Mild)", "4: Late Bloom (Str.)", "5: Sustainable", "---"];
        public string[] Locales = ["Brillia", "Goat", "Takrama", "Kalaragi", "Morx", "Rare #1", "Rare #2", "Rare #3", "Rare #4", "Rare #5", "---"];
        public string[] Traits = ["None/Normal", "Cool", "Unfriendly", "Aloof", "Confident", "Cheerful", "Indignant", "Stubborn", "Pride", "Show-off", "Slow", "Relaxed", "Easygoing", "Selfish", "Serious", "Whimsical",
        "Stoic", "Refined", "Nice", "Hysterical", "Impatient", "Touchy", "Narcissistic", "Resists Water", "Weak v. Water", "Calm", "Combative", "Gluttonous", "Spoiled", "Bashful", "Shy", "Quiet", "Resists Ltng.", "Unselfish",
        "Weak v. Ltng", "Resist Magic", "Fearless", "Brave", "Aggressive", "Optimistic", "Indifferent", "Sensitive", "Timid", "Pessimistic", "Defence Roll", "Reliable", "Honest", "Weirdo", "Weak v. Magic", "Hesitant", "Active",
        "Strong Heart", "Careful", "Resists Wind", "Nervous", "Perfectionist", "Clean", "Honorable", "Sore Loser", "Weak v. Wind", "Groovy Moves", "Contrary", "Lazy", "Childish", "High Output", "Difficult", "Greedy",
        "Energetic", "Independent", "Small Stomach", "Perceptive", "Dim-witted", "Intuitive", "Soft Skin", "Jell Body", "Thirsty", "Weak v. Heat", "Aquaphobic", "Stone Body", "Resists Cold", "Fast Footwork", "Tough Skin",
        "Radar", "Armor", "Light Aura", "Dark Aura", "Chlorophyll", "Weak Heart", "Rock Head", "Sharp Claws", "Sharp Fangs", "Sharp Horn", "Weak v. Cold", "Sweaty", "Resists Heat", "Thick Fur", "Sharp Edge", "Iron Fists",
        "Flexible Tail", "Tone-deaf", "Loud Voice", "Lung Capacity", "Hypotension", "Fire Wisdom", "Illusion Cape", "Charming Eye", "Sweet Voice", "Hard Scales", "Sweet Smell", "Waterproofing", "Heat-proofing", "Insulation",
        "Sharp Ears", "Cold Limbs", "Vegetarian", "Eats Anything", "Directionless", "Stinky Feet", "Arthritis", "Stuffy Nose", "Migrane", "Cold", "Hay Fever", "Sleepless", "Snoring", "Nearsighted", "Split Ends", "Dry Skin",
        "Iron Heart", "Pheromones", "Sniper", "Easily Tired", "Extra Teeth", "Dimples", "Lump", "Bruise", "Gourmet", "Injury", "Burn", "Sharp Eyes", "Flame Secrets", "Modest", "Faithful", "Water Wisdom", "Water Secrets",
        "Ice Wisdom", "Ice Secrets", "Wind Wisdom", "Wind Secrets", "Easrth Wisdom", "Earth Secrets", "Ltng. Wisdom", "Ltng. Secrets", "Heart Wisdom", "Heart Secrets", "Magic Wisdom", "Magic Secrets", "Llfe Wisdom",
        "Life Secrets", "Passionate"];

        //Okay, less operational stuff more actually interesting variables!
        public bool bJPNMode;
        public bool bNameEditMode;

        public int Mon_LIF, Mon_POW, Mon_INT, Mon_SPD, Mon_DEF;
        public int Mon_LIFGR, Mon_POWGR, Mon_INTGR, Mon_SPDGR, Mon_DEFGR;
        public int Mon_GutsRate;
        public int Mon_Fear, Mon_Spoil; // Bonds
        public int Mon_Stress, Mon_Fatigue;
        public int Mon_Lifespan, Mon_LifespanInit;
        public int Mon_LifeType;
        public int Mon_LifeStage;
        public int Mon_Sense; // 3841DE
        public int Mon_Breed, Mon_Locale;
        public int Mon_ArenaSPD;
        public int[] Mon_Personality = [0, 0, 0, 0, 0, 0, 0, 0];
        public int[] Mon_Tags = [0, 0, 0, 0];
        public int[] Mon_Traits = [0, 0, 0, 0, 0, 0, 0, 0, 0];
        public int[] Mon_DRs = [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0];
        public bool[] Mon_TraitActive = [false, false, false, false, false, false, false, false, false];
        public int Mon_Fame;
        public int Mon_Age;
        public int Mon_Form, Mon_Protein, Mon_Minerals, Mon_Vitamins;

        public string MoveName = "";
        public int MoveLevel, MoveMaxLevel;
        public bool MoveIsInt;
        public int MoveXP;
        public int MoveCost, MoveAccuracy, MoveCrit, MoveGutsDown, MoveDamage;
        public int MoveStatusFlags;
        public int MoveEffectDuration;
        public int MoveActivOdds;
        public int MoveRecoveryPow;
        public int MoveUnk1, MoveUnk2, MoveUnk3;
        public int MoveLifDrainPct;
        public int MoveSDPct;
        public int MoveElement;
        public int MoveFlags;
        public int MoveSlot;
        public int[] MoveXPBP = [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 9999];

        //public MoveData Mon_Move1;

        public int Ply_Money;
        public int Ply_Date, Ply_Week, Ply_Month, Ply_Year;
        public bool bOldHitPct = false;

        public string VersionID = "0.1.0";

        private void AttachButton_Click(object sender, EventArgs e)
        {
            IntPtr PointOffset = IntPtr.Zero;
            IntPtr ProgBase;

            if (PCSX2Type == EEMemType.None)
            {
                MessageBox.Show("Please select an emulator version before attaching Suezo's Eye.", "Attach Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            PS2Process = Process.GetProcesses().FirstOrDefault(process => process.ProcessName.StartsWith("PCSX2", StringComparison.OrdinalIgnoreCase));
            if (PS2Process != null)
            {
                if (bAttached)
                {
                    DetachCleanup();
                    return;
                }
                psxPTR = OpenProcess(PROCESS_ALLACCESS, false, PS2Process.Id);
                ProgBase = PS2Process.MainModule!.BaseAddress;

                switch (PCSX2Type)
                {
                    case EEMemType.Static:
                        PS2Base = 0x20000000; // PCSX2 1.6.0. A simple beast.
                        bAttached = true;
                        break;

                    case EEMemType.Dynamic: // PCSX2 EEmem era: doesn't have a fixed offset, but the RAM location is listed in the PE (exe) header
                                            // You can thank jroweboy for this. :)
                        PeFile header = new(PS2Process.MainModule.FileName);
                        uint exportedoffset = header.ExportedFunctions.First(fun => fun.Name == "EEmem").Address;
                        ulong readfrom = (ulong)ProgBase + exportedoffset;
                        ReadProcessMemory(psxPTR, (IntPtr)readfrom, ScratchData, 8, out RPMreadcount);
                        PointOffset = new IntPtr(BitConverter.ToInt64(ScratchData, 0));
                        PS2Base = PointOffset;
                        bAttached = true;
                        break;
                }
                if (bAttached)
                    AttachButton.Text = "Detach";

                // Version determination:
                ReadProcessMemory(psxPTR, IntPtr.Add(PS2Base, 0x009E7042), NameArray, 16, out RPMreadcount);
                if (String.Compare(System.Text.Encoding.UTF8.GetString(NameArray), "SLUS-20190MF3PLA", false) == 0)
                {
                    MRVersion = 2; // we're running MR3 1.1. Good.
                    Array.Clear(NameArray);
                    RenameAction.Enabled = true;
                    return;
                }
                ReadProcessMemory(psxPTR, IntPtr.Add(PS2Base, 0x009E71B2), NameArray, 16, out RPMreadcount);
                if (String.Compare(System.Text.Encoding.UTF8.GetString(NameArray), "SLUS-20190MF3PLA", false) == 0)
                {
                    MRVersion = 1; // we're running MR3 1.0. Not too good.
                    MessageBox.Show("Unfortunately, MR3 v1.0 is not supported. Apologies for the inconvenience.", "Attach Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DetachCleanup();
                    return;
                }
                ReadProcessMemory(psxPTR, IntPtr.Add(PS2Base, 0x009D28B2), NameArray, 16, out RPMreadcount);
                if (String.Compare(System.Text.Encoding.UTF8.GetString(NameArray), "SLPS-25035MF3PLA", false) == 0)
                {
                    MRVersion = 0; // we're running MF3. Functionality is limited, but still: Good.
                    bJPNMode = true;
                    MessageBox.Show(@"MF3 support is incomplete. Apologies for the inconvenience.
MF3のサポートは不完全だ。ごめなさいございます。", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Array.Clear(NameArray);
                    RenameAction.Hide();
                    return;
                }
                MessageBox.Show("It seems you are not running MR3. How strange.", "Attach Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DetachCleanup();
                return;
            }
            else
            {
                MessageBox.Show("PCSX2 isn't running, at least as far as Suezo's Eye can see.", "Attach Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DetachCleanup();
            }
        }

        private void EmulatorSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            PCSX2Type = (EEMemType)EmulatorSelector.SelectedIndex;
        }

        private void DetachCleanup()
        {
            bAttached = false;
            AttachButton.Text = "Attach";
            PS2Base = 0;
            PS2Process = null;
            bJPNMode = false;
            LifeText.Text = "---";
            PowerText.Text = "---";
            IntelText.Text = "---";
            SpeedText.Text = "---";
            DefenText.Text = "---";
            LifeGRText.Text = "---";
            PowerGRText.Text = "---";
            IntelGRText.Text = "---";
            SpeedGRText.Text = "---";
            DefenGRText.Text = "---";
            BaseText.Text = "---";
            PersonalityMatrix.Text = "---";
            TagMatrix.Text = "---";

            MonsterName.Text = "---";
            LifeTypeText.Text = "---";
            LifespanText.Text = "---";
            SenseText.Text = "---";

            IngameDate.Text = "---";
            MoneyText.Text = "---";
            AgeText.Text = "---";
            LifeStageText.Text = "---";
            SpoilText.Text = "---";
            FatigueText.Text = "---";
            StressText.Text = "---";
            FearText.Text = "---";
            ArenaSPDText.Text = "---";
            FormText.Text = "---";
            Text = "Suezo's Eye";

            Trait1Text.Text = "---";
            Trait2Text.Text = "---";
            Trait3Text.Text = "---";
            Trait4Text.Text = "---";
            Trait5Text.Text = "---";
            Trait6Text.Text = "---";
            Trait7Text.Text = "---";
            Trait8Text.Text = "---";
            Trait9Text.Text = "---";

            ProteinText.Text = "---";
            VitaminText.Text = "---";
            MineralText.Text = "---";

            RenameAction.Show();
            RenameAction.Text = "Rename";
            RenameAction.Enabled = false;
            CancelRename.Hide();
            MRVersion = 255;
            MoveNameBox.BackColor = SystemColors.Control;
            MoveNameBox.Text = "---";
            CostBox.Text = "---";
            AccuracyBox.Text = "---";
            CritBox.Text = "---";
            AccuracyBox.Text = "---";
            ForceBox.Text = "---";
            WitherBox.Text = "---";
            StatusBox.Text = "---";
            ElementBox.Text = "---";
            DamageModText.Text = "---";
            LvlXPBox.Text = "---";
            GRText.Text = "---";

            Array.Clear(ScratchData);
            Array.Clear(NameArray);
            Array.Clear(Mon_Personality);
            Array.Clear(Mon_Tags);
        }

        private int MR3ReadByte(int address)
        {
            Array.Clear(ScratchData);
            ReadProcessMemory(psxPTR, IntPtr.Add(PS2Base, address), ScratchData, 1, out RPMreadcount);
            return BitConverter.ToInt32(ScratchData, 0);
        }

        private int MR3ReadDouble(int address)
        {
            Array.Clear(ScratchData);
            ReadProcessMemory(psxPTR, IntPtr.Add(PS2Base, address), ScratchData, 2, out RPMreadcount);
            return BitConverter.ToInt32(ScratchData, 0);
        }

        private int MR3ReadQuad(int address)
        {
            Array.Clear(ScratchData);
            ReadProcessMemory(psxPTR, IntPtr.Add(PS2Base, address), ScratchData, 4, out RPMreadcount);
            return BitConverter.ToInt32(ScratchData, 0);
        }

        private long MR3ReadLong(int address)
        {
            Array.Clear(ScratchData);
            ReadProcessMemory(psxPTR, IntPtr.Add(PS2Base, address), ScratchData, 8, out RPMreadcount);
            return BitConverter.ToInt64(ScratchData, 0);
        }

        private bool MR3ReadBool(int address)
        {
            Array.Clear(ScratchData);
            ReadProcessMemory(psxPTR, IntPtr.Add(PS2Base, address), ScratchData, 1, out RPMreadcount);
            return ScratchData[0] != 0;
        }

        private void MR3ReadRaw(int address, int length)
        {
            Math.Clamp(length, 1, 64);

            Array.Clear(BigArray);
            ReadProcessMemory(psxPTR, IntPtr.Add(PS2Base, address), BigArray, length, out RPMreadcount);
            return;
        }

        private string MR3ReadName(int address, int NameLength)
        {
            if (bJPNMode)
                return "---"; // I don't know how to parse MF3 text.

            ReadProcessMemory(psxPTR, IntPtr.Add(PS2Base, address), NameArray, NameLength, out RPMreadcount);
            return MR3HexToUTF8_EN(NameArray);
        }

        private void MR3WriteMonName(int address, int NameLength)
        {
            if (bJPNMode)
                return; // I don't know how to parse MF3 text.

            WriteProcessMemory(psxPTR, IntPtr.Add(PS2Base, address), UTF8_ENToMR3(MonsterName.Text), NameLength, out RPMreadcount);
        }

        private static string MR3HexToUTF8_EN(byte[] input)
        {
            byte[] outputstring = new byte[input.Length];
            if (input.Length > 0)
            {
                for (int ch = 0; ch < input.Length; ch++)
                {
                    byte decval = input[ch];
                    if (decval < 0x1A) // Uppercase
                        decval += 0x41;
                    else if (decval < 0x34) // Lowercase
                        decval += 0x47;
                    else if (decval < 0x3E) // some punctuation
                        decval -= 0x04;
                    else
                    {
                        switch (decval) // special cases
                        {
                            case 0x3E:
                                decval = 0x21; break;
                            case 0x3F:
                                decval = 0x3F; break;
                            case 0x40:
                                decval = 0x2B; break;
                            case 0x41:
                                decval = 0x2D; break;
                            case 0x42:
                                decval = 0x2A; break;
                            case 0x43:
                                decval = 0x22; break;
                            case 0x44:
                                decval = 0x23; break;
                            case 0x45:
                                decval = 0x24; break;
                            case 0x46:
                                decval = 0x25; break;
                            case 0x47:
                                decval = 0x26; break;
                            case 0x48:
                                decval = 0x27; break;
                            case 0x49:
                                decval = 0x28; break;
                            case 0x4A:
                                decval = 0x29; break;
                            case 0x4B:
                                decval = 0xB7; break;
                            case 0x4C:
                                decval = 0x3C; break;
                            case 0x4D:
                                decval = 0x3E; break;
                            case 0x4E:
                                decval = 0x5F; break;
                            case 0x4F:
                                decval = 0x5B; break;
                            case 0x50:
                                decval = 0x5D; break;
                            case 0x51:
                                decval = 0x2A; break;
                            case 0x52:
                                decval = 0x2A; break;
                            case 0x53:
                                decval = 0x2A; break;
                            case 0x54:
                                decval = 0x2A; break;
                            case 0x55:
                                decval = 0x20; break;
                            case 0x58:
                                decval = 0x2E; break;
                            case 0x59:
                                decval = 0x2C; break;
                            case 0x5A:
                                decval = 0x3A; break;
                            case 0xff:
                                ch = input.Length - 1; break; // end loop
                        }
                    }
                    outputstring[ch] = decval;
                }
                return System.Text.Encoding.ASCII.GetString(outputstring);
            }
            else
                return "Error: no input";
        }

        private static byte[] UTF8_ENToMR3(string input)
        {
            char[] scratchValues = input.ToCharArray();
            byte[] charValues = new byte[13];
            bool bSpecial;

            for (int i = 0; i <= scratchValues.Length; i++)
            {
                if (i == scratchValues.Length)
                {
                    charValues[i] = 0xff;
                    break;
                }

                int value = scratchValues[i];
                bSpecial = true; // You're always special <3
                switch (value)
                {
                    case '!':
                        value = 0x3E; break;
                    case '?':
                        value = 0x3F; break;
                    case '+':
                        value = 0x40; break;
                    case '-':
                        value = 0x41; break;
                    case '*':
                        value = 0x42; break;
                    case '"':
                        value = 0x43; break;
                    case '#':
                        value = 0x44; break;
                    case '$':
                        value = 0x45; break;
                    case '%':
                        value = 0x46; break;
                    case '&':
                        value = 0x47; break;
                    case '\'':
                        value = 0x48; break;
                    case '(':
                        value = 0x49; break;
                    case ')':
                        value = 0x4A; break;
                    case '·':
                        value = 0x4B; break;
                    case '<':
                        value = 0x4C; break;
                    case '>':
                        value = 0x4D; break;
                    case '_':
                        value = 0x4E; break;
                    case '「':
                        value = 0x4F; break;
                    case '[':
                        value = 0x4F; break;
                    case '」':
                        value = 0x50; break;
                    case ']':
                        value = 0x50; break;
                    case ' ': // Space
                        value = 0x55; break;
                    case '.':
                        value = 0x58; break;
                    case ',':
                        value = 0x59; break;
                    case ':':
                        value = 0x5A; break;
                    default:
                        bSpecial = false; break; // until you're not </3
                }
                if (!bSpecial)
                {
                    if (value > 0x2F && value < 0x3A)
                        value += 0x04;
                    if (value > 0x40 && value < 0x5A)
                        value -= 0x41;
                    else if (value > 0x60 && value < 0x7B)
                        value -= 0x47;
                }
                charValues[i] = (byte)value;
            }
            return charValues;
        }

        private void UpdateStatTimer_Tick(object sender, EventArgs e)
        {
            Text = "Suezo's Eye " + VersionID;
            if (PS2Process != null && bAttached) // It's showtime girls.
            {
                Ply_Money = MR3ReadQuad(bJPNMode ? 0x00000000 : 0x0037BEAC); MoneyText.Text = Ply_Money + "G";

                Ply_Year = MR3ReadDouble(bJPNMode ? 0x00372500 : 0x0037BFA8);
                Ply_Month = MR3ReadByte(bJPNMode ? 0x00372502 : 0x0037BFAA); if (Ply_Month > 12) Ply_Month = 1;
                Ply_Week = MR3ReadByte(bJPNMode ? 0x00372503 : 0x0037BFAB);
                Ply_Date = MR3ReadQuad(bJPNMode ? 0x003724FC : 0x0037BFA4);
                if (Ply_Month > 12 || Ply_Month == 0 || Ply_Week > 4 || Ply_Week == 0)
                {
                    Ply_Month = 4;
                    Ply_Week = 1;
                    Ply_Year = 1000;
                }

                if (!bJPNMode)
                    IngameDate.Text = ShortMonths[Ply_Month] + " " + Ply_Week + ", " + Ply_Year;
                else
                    IngameDate.Text = Ply_Month + "月 " + Ply_Week + "週 (" + Ply_Year + ")";

                if (MRVersion == 2)
                {
                    if (!bNameEditMode)
                        MonsterName.Text = MR3ReadName(0x003840D0, 13); // We can currently only read english names.
                }
                else
                    MonsterName.Text = "---";

                if (MonsterName.Text == "AAAAAAAAAAAAAAAAAAAAAAAA")
                    MonsterName.Text = "---"; // yeah i can't lie default text better than screaming. And no, I don't know why 12 bytes of read is 24 bytes of screaming.

                PersonalityMatrix.Text = "";
                for (int l = 0; l < 8; l++)
                {
                    Mon_Personality[l] = MR3ReadByte(bJPNMode ? (0x00379EB4 + l) : (0x003841CC + l));
                    if (l == 7)
                        PersonalityMatrix.Text += Mon_Personality[l].ToString();
                    else
                        PersonalityMatrix.Text += Mon_Personality[l] + " - ";
                }
                TagMatrix.Text = "";
                for (int l = 0; l < 4; l++)
                {
                    Mon_Tags[l] = MR3ReadByte(bJPNMode ? (0x00379E4C + l) : (0x00384164 + l));
                    if (l == 3)
                        TagMatrix.Text += Mon_Tags[l].ToString("X2");
                    else
                        TagMatrix.Text += Mon_Tags[l].ToString("X2") + " - ";
                }
                for (int l = 0; l < 9; l++)
                {
                    Mon_Traits[l] = MR3ReadByte(bJPNMode ? (0x0037A30C + (12 * l)) : (0x00384624 + (12 * l)));
                    Mon_TraitActive[l] = MR3ReadBool(bJPNMode ? (0x0037A30E + (12 * l)) : (0x00384626 + (12 * l)));
                }

                MR3ReadRaw(bJPNMode ? 0x00379E80 : 0x00384198, 12); // Read damage resistances
                DamageModText.Text = "";
                for (int l = 0; l < 12; l++)
                {
                    Mon_DRs[l] = (int)BigArray[l];
                    if (l == 11)
                        DamageModText.Text += Mon_DRs[l].ToString();
                    else
                        DamageModText.Text += Mon_DRs[l] + " ";
                }

                Mon_LIF = MR3ReadDouble(bJPNMode ? 0x00379E58 : 0x00384170); LifeText.Text = Mon_LIF / 10 + "." + Mon_LIF % 10; // it's 2am i can't be bothered with advanced string concantenation.
                Mon_POW = MR3ReadDouble(bJPNMode ? 0x00379E50 : 0x00384168); PowerText.Text = Mon_POW / 10 + "." + Mon_POW % 10;
                Mon_INT = MR3ReadDouble(bJPNMode ? 0x00379E54 : 0x0038416C); IntelText.Text = Mon_INT / 10 + "." + Mon_INT % 10;
                Mon_SPD = MR3ReadDouble(bJPNMode ? 0x00379E52 : 0x0038416A); SpeedText.Text = Mon_SPD / 10 + "." + Mon_SPD % 10;
                Mon_DEF = MR3ReadDouble(bJPNMode ? 0x00379E56 : 0x0038416E); DefenText.Text = Mon_DEF / 10 + "." + Mon_DEF % 10;
                BaseText.Text = "" + (Mon_LIF + Mon_POW + Mon_INT + Mon_SPD + Mon_DEF) / 10;

                Mon_LIFGR = MR3ReadByte(bJPNMode ? 0x00379E7D : 0x00384195); LifeGRText.Text = Mon_LIFGR + " / 9";
                Mon_POWGR = MR3ReadByte(bJPNMode ? 0x00379E79 : 0x00384191); PowerGRText.Text = Mon_POWGR + " / 9";
                Mon_INTGR = MR3ReadByte(bJPNMode ? 0x00379E7B : 0x00384193); IntelGRText.Text = Mon_INTGR + " / 9";
                Mon_SPDGR = MR3ReadByte(bJPNMode ? 0x00379E7A : 0x00384192); SpeedGRText.Text = Mon_SPDGR + " / 9";
                Mon_DEFGR = MR3ReadByte(bJPNMode ? 0x00379E7C : 0x00384194); DefenGRText.Text = Mon_DEFGR + " / 9";

                Mon_Spoil = MR3ReadByte(bJPNMode ? 0x00379EBD : 0x003841D5); SpoilText.Text = Mon_Spoil.ToString();
                Mon_Fear = MR3ReadByte(bJPNMode ? 0x00379EBC : 0x003841D4); FearText.Text = Mon_Fear.ToString();
                Mon_Fatigue = MR3ReadByte(bJPNMode ? 0x00379E71 : 0x00384189); FatigueText.Text = Mon_Fatigue.ToString();
                Mon_Stress = MR3ReadByte(bJPNMode ? 0x00379E72 : 0x0038418A); StressText.Text = Mon_Stress.ToString();
                Mon_Age = MR3ReadDouble(bJPNMode ? 0x00379E36 : 0x0038414E); AgeText.Text = (Mon_Age / 48) + "y, " + ((Mon_Age / 4) % 12) + "m, " + (Mon_Age % 4) + "w";

                Mon_Lifespan = MR3ReadDouble(bJPNMode ? 0x00379E6C : 0x00384184);
                Mon_LifespanInit = MR3ReadDouble(bJPNMode ? 0x00379E6E : 0x00384186);
                LifespanText.Text = Mon_Lifespan / 10 + "." + Mon_Lifespan % 10 + "w / " + Mon_LifespanInit / 10 + "." + Mon_LifespanInit % 10 + "w";

                Mon_LifeType = MR3ReadByte(bJPNMode ? 0x00379E1A : 0x00384132); if (Mon_LifeType > 5) Mon_LifeType = 6; LifeTypeText.Text = LifeTypes[Mon_LifeType];
                Mon_LifeStage = MR3ReadByte(bJPNMode ? 0x00379E1B : 0x00384133); LifeStageText.Text = "Stage " + (Mon_LifeStage + 1).ToString() + " / 16";
                Mon_Sense = MR3ReadByte(bJPNMode ? 0x00379EC6 : 0x003841DE); SenseText.Text = Mon_Sense + " / 99";
                Mon_Breed = MR3ReadByte(bJPNMode ? 0x00379E18 : 0x00384130); if (Mon_Breed > 30) Mon_Breed = 30;
                Mon_Locale = MR3ReadByte(bJPNMode ? 0x00379E19 : 0x00384131); if (Mon_Locale > 10) Mon_Locale = 10;
                Text = "Suezo's Eye " + VersionID + " - Monster: " + GenusNames[Mon_Breed] + " (" + Locales[Mon_Locale] + ")";

                Mon_Form = MR3ReadByte(bJPNMode ? 0x00379E73 : 0x0038418B); if (Mon_Form > 127) { Mon_Form = 256 - Mon_Form; Mon_Form *= -1; }
                Mon_Protein = MR3ReadByte(bJPNMode ? 0x00379E8C : 0x003841A4); ProteinText.Text = Mon_Protein.ToString();
                Mon_Vitamins = MR3ReadByte(bJPNMode ? 0x00379E8D : 0x003841A5); VitaminText.Text = Mon_Vitamins.ToString();
                Mon_Minerals = MR3ReadByte(bJPNMode ? 0x00379E8E : 0x003841A6); MineralText.Text = Mon_Minerals.ToString();
                FormText.Text = Mon_Form switch
                {
                    >= -99 and <= -70 => Mon_Form + " (Emaciated)",
                    >= -69 and <= -41 => Mon_Form + " (Thin)",
                    >= -40 and <= -14 => Mon_Form + " (Slim)",
                    >= -13 and <= 14 => Mon_Form + " (Normal)",
                    >= 15 and <= 42 => Mon_Form + " (Chubby)",
                    >= 43 and <= 70 => Mon_Form + " (Chunky)",
                    >= 71 and <= 99 => Mon_Form + " (Fat)",
                    _ => "---",
                };
                Mon_ArenaSPD = MR3ReadByte(bJPNMode ? 0x00379E7F : 0x00384197); ArenaSPDText.Text = Mon_ArenaSPD.ToString();
                Mon_GutsRate = MR3ReadByte(bJPNMode ? 0x00379E7E : 0x00384196);
                float OutGR = Mon_GutsRate; OutGR /= (50 / 3);
                GRText.Text = Mon_GutsRate + " (" + OutGR.ToString("F2") + "/s)";

                Trait1Text.Text = Traits[Mon_Traits[0]]; if (!Mon_TraitActive[0]) Trait1Text.Text = "---";
                Trait2Text.Text = Traits[Mon_Traits[1]]; if (!Mon_TraitActive[1]) Trait2Text.Text = "---";
                Trait3Text.Text = Traits[Mon_Traits[2]]; if (!Mon_TraitActive[2]) Trait3Text.Text = "---";
                Trait4Text.Text = Traits[Mon_Traits[3]]; if (!Mon_TraitActive[3]) Trait4Text.Text = "---";
                Trait5Text.Text = Traits[Mon_Traits[4]]; if (!Mon_TraitActive[4]) Trait5Text.Text = "---";
                Trait6Text.Text = Traits[Mon_Traits[5]]; if (!Mon_TraitActive[5]) Trait6Text.Text = "---";
                Trait7Text.Text = Traits[Mon_Traits[6]]; if (!Mon_TraitActive[6]) Trait7Text.Text = "---";
                Trait8Text.Text = Traits[Mon_Traits[7]]; if (!Mon_TraitActive[7]) Trait8Text.Text = "---";
                Trait9Text.Text = Traits[Mon_Traits[8]]; if (!Mon_TraitActive[8]) Trait9Text.Text = "---";

                ReadMoveData();
            }
            if (PS2Process == null && bAttached)
            {
                DetachCleanup();
            }
        }

        private void RenameAction_Click(object sender, EventArgs e)
        {
            if (!bNameEditMode)
            {
                RenameAction.Text = "Confirm";
                bNameEditMode = true;
                CancelRename.Visible = true;
                MonsterName.ReadOnly = false;
            }
            else
            {
                MR3WriteMonName(0x003840D0, 13);
                bNameEditMode = false;
                CancelRename.Visible = false;
                MonsterName.ReadOnly = true;
                RenameAction.Text = "Rename";
            }
        }

        private void CancelRename_Click(object sender, EventArgs e)
        {
            bNameEditMode = false;
            CancelRename.Visible = false;
            RenameAction.Text = "Rename";
        }

        private void ReadMoveData()
        {
            MoveName = MR3ReadName((bJPNMode ? 0x00379EC8 : 0x003841E0) + (72 * MoveSlot), 17);
            MoveLevel = MR3ReadByte((bJPNMode ? 0x00379EE1 : 0x003841F9) + (72 * MoveSlot));
            MoveMaxLevel = MR3ReadByte((bJPNMode ? 0x00379EE2 : 0x003841FA) + (72 * MoveSlot));
            MoveIsInt = MR3ReadBool((bJPNMode ? 0x00379EE3 : 0x003841FB) + (72 * MoveSlot));
            MoveXP = MR3ReadDouble((bJPNMode ? 0x00379EE4 : 0x003841FC) + (72 * MoveSlot));
            MoveCost = MR3ReadByte((bJPNMode ? 0x00379EE9 : 0x00384201) + (72 * MoveSlot));
            MoveAccuracy = MR3ReadByte((bJPNMode ? 0x00379EEA : 0x00384202) + (72 * MoveSlot));
            MoveCrit = MR3ReadByte((bJPNMode ? 0x00379EEB : 0x00384203) + (72 * MoveSlot));
            MoveDamage = MR3ReadByte((bJPNMode ? 0x00379EEC : 0x00384204) + (72 * MoveSlot));
            MoveGutsDown = MR3ReadByte((bJPNMode ? 0x00379EEE : 0x00384206) + (72 * MoveSlot));
            MoveStatusFlags = MR3ReadQuad((bJPNMode ? 0x00379EF0 : 0x00384208) + (72 * MoveSlot));
            MoveEffectDuration = MR3ReadDouble((bJPNMode ? 0x00379EF4 : 0x0038420C) + (72 * MoveSlot));
            MoveActivOdds = MR3ReadByte((bJPNMode ? 0x00379EF6 : 0x0038420E) + (72 * MoveSlot));
            MoveRecoveryPow = MR3ReadByte((bJPNMode ? 0x00379EF7 : 0x0038420F) + (72 * MoveSlot));
            MoveUnk1 = MR3ReadByte((bJPNMode ? 0x00379EF8 : 0x00384210) + (72 * MoveSlot));
            MoveLifDrainPct = MR3ReadByte((bJPNMode ? 0x00379EF9 : 0x00384211) + (72 * MoveSlot));
            MoveSDPct = MR3ReadByte((bJPNMode ? 0x00379EFA : 0x00384212) + (72 * MoveSlot));
            MoveUnk2 = MR3ReadDouble((bJPNMode ? 0x00379EFC : 0x00384214) + (72 * MoveSlot));
            MoveElement = MR3ReadDouble((bJPNMode ? 0x00379EFE : 0x00384216) + (72 * MoveSlot));
            MoveFlags = MR3ReadQuad((bJPNMode ? 0x00379F00 : 0x00384218) + (72 * MoveSlot));
            MoveUnk3 = MR3ReadDouble((bJPNMode ? 0x00379F04 : 0x0038421C) + (72 * MoveSlot));
            for (int i = 0; i < 10; i++)
                MoveXPBP[i] = MR3ReadByte((bJPNMode ? 0x00379F06 : 0x0038421E) + (72 * MoveSlot) + i);

            if (MoveMaxLevel > 10 || MoveMaxLevel < 0)
                MoveMaxLevel = 0;
            if (MoveLevel > 10 || MoveMaxLevel < 0)
                MoveLevel = 0;

            if (MoveMaxLevel != 0 && MoveName.Length > 0)
            {
                MoveNameBox.Text = MoveName;
                if (MoveIsInt)
                    MoveNameBox.BackColor = Color.LightGreen;
                else
                    MoveNameBox.BackColor = Color.LightGoldenrodYellow;

                if (MoveMaxLevel <= (MoveLevel + 1))
                    LvlXPBox.Text = "MAX (" + MoveXP + "/" + (MoveXPBP[MoveLevel] * 10) + ")";
                else
                    LvlXPBox.Text = "Lv." + (MoveLevel + 1) + " (" + MoveXP + "/" + (MoveXPBP[MoveLevel + 1] * 10) + ") ";

                CostBox.Text = MoveCost.ToString();
                CritBox.Text = MoveCrit.ToString();
                if (bOldHitPct)
                    MoveAccuracy -= 50;
                AccuracyBox.Text = MoveAccuracy.ToString();
                ForceBox.Text = MoveDamage.ToString();
                WitherBox.Text = MoveGutsDown.ToString();
                StatusBox.Text = ProcessMoveStatus();
                ElementBox.Text = ProcessMoveElement();
            }
            else
            {
                MoveNameBox.BackColor = SystemColors.Control;
                MoveNameBox.Text = "---";
                CostBox.Text = "---";
                AccuracyBox.Text = "---";
                CritBox.Text = "---";
                AccuracyBox.Text = "---";
                ForceBox.Text = "---";
                WitherBox.Text = "---";
                StatusBox.Text = "---";
                ElementBox.Text = "---";
                LvlXPBox.Text = "---";
            }
        }

        [Flags]
        private enum StatusTypes : UInt32
        {
            None = 0x00000000,
            HPDrain = 0x00000001,
            MPDrain = 0x00000002,
            HPRecov = 0x00000004,
            MPRecov = 0x00000008,
            SDonHit = 0x00000010,
            SDonMis = 0x00000020,
            SDonAll = 0x00000040,
            NoPeKid = 0x00000080,
            Knockback = 0x00000100,
            Unk7 = 0x00000200,
            Unk8 = 0x00000400,
            Unk9 = 0x00000800,
            Unk10 = 0x00001000,
            Unk11 = 0x00002000,
            Unk12 = 0x00004000,
            Unk13 = 0x00008000,
            Shaken = 0x00010000,
            Dizzy = 0x00020000,
            HitStag = 0x00040000,
            MissTopp = 0x00080000,
            SelfStag = 0x00100000,
            Slow = 0x00200000,
            Stun = 0x00400000,
            Addled = 0x00800000,
            Mikiri = 0x01000000,
            DefUp = 0x02000000,
            Unk1 = 0x04000000,
            Unk2 = 0x08000000,
            Unk3 = 0x10000000,
            Unk4 = 0x20000000,
            Unk5 = 0x40000000,
            Unk6 = 0x80000000
        }
        // "Why are the labels out of order, Lexi?"
        // > Because I got the endianness of the numbers backwards the first time, imaginary code reader.

        private string ProcessMoveStatus()
        {
            string OutString = "";

            StatusTypes StatFlags = (StatusTypes)MoveStatusFlags;
            float SDuration = (MoveEffectDuration / 60);

            if ((StatFlags & StatusTypes.Mikiri) == StatusTypes.Mikiri)
                OutString = "Dispair";
            if ((StatFlags & StatusTypes.DefUp) == StatusTypes.DefUp)
            {
                if (OutString.Length > 0)
                    OutString += ", ";

                OutString += "Def. Up";
            }
            if ((StatFlags & StatusTypes.Shaken) == StatusTypes.Shaken)
            {
                if (OutString.Length > 0)
                    OutString += ", ";

                OutString += "Shaken " + "(" + MoveActivOdds + "%, " + SDuration.ToString("F2") + "s)";
            }
            if ((StatFlags & StatusTypes.Dizzy) == StatusTypes.Dizzy)
            {
                if (OutString.Length > 0)
                    OutString += ", ";

                OutString += "Dizzy " + "(" + MoveActivOdds + "%, " + SDuration.ToString("F2") + "s)";
            }
            if ((StatFlags & StatusTypes.HitStag) == StatusTypes.HitStag)
            {
                if (OutString.Length > 0)
                    OutString += ", ";

                OutString += "Hit + Stagger";
            }
            if ((StatFlags & StatusTypes.MissTopp) == StatusTypes.MissTopp)
            {
                if (OutString.Length > 0)
                    OutString += ", ";

                OutString += "Miss + Topple";
            }
            if ((StatFlags & StatusTypes.SelfStag) == StatusTypes.SelfStag)
            {
                if (OutString.Length > 0)
                    OutString += ", ";

                OutString += "Self-Stagger";
            }
            if ((StatFlags & StatusTypes.Slow) == StatusTypes.Slow)
            {
                if (OutString.Length > 0)
                    OutString += ", ";

                OutString += "Slow " + "(" + MoveActivOdds + "%, " + SDuration.ToString("F2") + "s)";
            }
            if ((StatFlags & StatusTypes.Stun) == StatusTypes.Stun)
            {
                if (OutString.Length > 0)
                    OutString += ", ";

                OutString += "Stun " + "(" + MoveActivOdds + "%, " + SDuration.ToString("F2") + "s)";
            }
            if ((StatFlags & StatusTypes.Addled) == StatusTypes.Addled)
            {
                if (OutString.Length > 0)
                    OutString += ", ";

                OutString += "Addled " + "(" + MoveActivOdds + "%, " + SDuration.ToString("F2") + "s)";
            }
            if ((StatFlags & StatusTypes.Knockback) == StatusTypes.Knockback)
            {
                if (OutString.Length > 0)
                    OutString += ", ";

                OutString += "Knockback";
            }
            if ((StatFlags & StatusTypes.HPDrain) == StatusTypes.HPDrain)
            {
                if (OutString.Length > 0)
                    OutString += ", ";

                OutString += "HP Drain " + "(" + MoveLifDrainPct + "%)";
            }
            if ((StatFlags & StatusTypes.MPDrain) == StatusTypes.MPDrain)
            {
                if (OutString.Length > 0)
                    OutString += ", ";

                OutString += "Guts Drain " + "(" + MoveLifDrainPct + "%)";
            }
            if ((StatFlags & StatusTypes.HPRecov) == StatusTypes.HPRecov)
            {
                if (OutString.Length > 0)
                    OutString += ", ";

                OutString += "HP Recovery";
                ForceBox.Text = MoveRecoveryPow.ToString();
            }
            if ((StatFlags & StatusTypes.MPRecov) == StatusTypes.MPRecov)
            {
                if (OutString.Length > 0)
                    OutString += ", ";

                OutString += "Guts Recovery";
            }
            if ((StatFlags & StatusTypes.SDonHit) == StatusTypes.SDonHit)
            {
                if (OutString.Length > 0)
                    OutString += ", ";

                OutString += "SD on Hit " + "(" + MoveSDPct + "%)";
            }
            if ((StatFlags & StatusTypes.SDonMis) == StatusTypes.SDonMis)
            {
                if (OutString.Length > 0)
                    OutString += ", ";

                OutString += "SD on Miss " + "(" + MoveSDPct + "%)";
            }
            if ((StatFlags & StatusTypes.SDonAll) == StatusTypes.SDonAll)
            {
                if (OutString.Length > 0)
                    OutString += ", ";

                OutString += "Self Damage " + "(" + MoveSDPct + "%)";
            }
            if ((StatFlags & StatusTypes.NoPeKid) == StatusTypes.NoPeKid)
            {
                if (OutString.Length > 0)
                    OutString += ", ";

                OutString += "Step-In";
            }
            if (OutString.Length > 0)
                return OutString;
            else
                return "None";
        }

        private enum MoveElements
        {
            None = 0x0000,
            Pierce = 0x0001,
            Impact = 0x0002,
            Slash = 0x0004,
            Earth = 0x0008,
            Water = 0x0010,
            Wind = 0x0020,
            Thunder = 0x0040,
            Ice = 0x0080,
            Flame = 0x0100,
            Heart = 0x0200,
            Magic = 0x0400,
            Unk1 = 0x0800
        }

        private string ProcessMoveElement()
        {
            string OutString = "";

            MoveElements ElemFlags = (MoveElements)MoveElement;

            if ((ElemFlags & MoveElements.Pierce) == MoveElements.Pierce)
                OutString = "Pound (Pi)";
            if ((ElemFlags & MoveElements.Impact) == MoveElements.Impact)
            {
                if (OutString.Length > 0)
                    OutString += " / ";

                OutString += "Beat (Im)";
            }
            if ((ElemFlags & MoveElements.Slash) == MoveElements.Slash)
            {
                if (OutString.Length > 0)
                    OutString += " / ";

                OutString += "Cut (Sl)";
            }
            if ((ElemFlags & MoveElements.Earth) == MoveElements.Earth)
            {
                if (OutString.Length > 0)
                    OutString += " / ";

                OutString += "Earth";
            }
            if ((ElemFlags & MoveElements.Water) == MoveElements.Water)
            {
                if (OutString.Length > 0)
                    OutString += " / ";

                OutString += "Water";
            }
            if ((ElemFlags & MoveElements.Wind) == MoveElements.Wind)
            {
                if (OutString.Length > 0)
                    OutString += " / ";

                OutString += "Wind";
            }
            if ((ElemFlags & MoveElements.Thunder) == MoveElements.Thunder)
            {
                if (OutString.Length > 0)
                    OutString += " / ";

                OutString += "Thunder";
            }
            if ((ElemFlags & MoveElements.Ice) == MoveElements.Ice)
            {
                if (OutString.Length > 0)
                    OutString += " / ";

                OutString += "Ice";
            }
            if ((ElemFlags & MoveElements.Flame) == MoveElements.Flame)
            {
                if (OutString.Length > 0)
                    OutString += " / ";

                OutString += "Flame";
            }
            if ((ElemFlags & MoveElements.Heart) == MoveElements.Heart)
            {
                if (OutString.Length > 0)
                    OutString += " / ";

                OutString += "Heart";
            }
            if ((ElemFlags & MoveElements.Magic) == MoveElements.Magic)
            {
                if (OutString.Length > 0)
                    OutString += " / ";

                OutString += "Magic";
            }
            if (OutString.Length > 0)
                return OutString;
            else
                return "None";
        }

        private void OldHitPercent_CheckedChanged(object sender, EventArgs e)
        {
            bOldHitPct = OldHitPercent.Checked;
        }

        private void MoveSlotID_SelectedIndexChanged(object sender, EventArgs e)
        {
            MoveSlot = MoveSlotID.SelectedIndex;
        }
    }
}