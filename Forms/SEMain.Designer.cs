namespace SuezosEye
{
    partial class SEMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SEMain));
            AttachButton = new Button();
            EmulatorSelector = new ComboBox();
            ShamelessPlugs = new StatusStrip();
            EmuVerLabel = new Label();
            LifeText = new TextBox();
            PowerText = new TextBox();
            IntelText = new TextBox();
            SpeedText = new TextBox();
            DefenText = new TextBox();
            LifLabel = new Label();
            PowerLabel = new Label();
            IntelLabel = new Label();
            SpeedLabel = new Label();
            DefenLabel = new Label();
            UpdateStatTimer = new System.Windows.Forms.Timer(components);
            BaseText = new TextBox();
            BSTLabel = new Label();
            SnarkyTips = new ToolTip(components);
            MonsterNameLabel = new Label();
            SenseLabel = new Label();
            MoneyLabel = new Label();
            LifeTypeLabel = new Label();
            LifespanLabel = new Label();
            PersonalityLabel = new Label();
            MonTagsLabel = new Label();
            StressLabel = new Label();
            FatigueLabel = new Label();
            FearLabel = new Label();
            SpoilLabel = new Label();
            AgeLabel = new Label();
            LifeStageLabel = new Label();
            FormLabel = new Label();
            GrowthLabel = new Label();
            MoveSpdLabel = new Label();
            Trait1Label = new Label();
            Trait3Label = new Label();
            Trait4Label = new Label();
            Trait6Label = new Label();
            Trait7Label = new Label();
            Trait9Label = new Label();
            Trait2Label = new Label();
            Trait5Label = new Label();
            Trait8Label = new Label();
            ProteinLabel = new Label();
            VitaminLabel = new Label();
            MineralLabel = new Label();
            GRLabel = new Label();
            DMLabel = new Label();
            PersonalityMatrix = new TextBox();
            TagMatrix = new TextBox();
            DamageModText = new TextBox();
            CostLabel = new Label();
            HitLabel = new Label();
            CritLabel = new Label();
            WitherLabel = new Label();
            ForceLabel = new Label();
            MoveNameLabel = new Label();
            XPLvlLabel = new Label();
            EffectLabel = new Label();
            ElementLabel = new Label();
            OldHitPercent = new CheckBox();
            MoveSlotID = new ComboBox();
            MoveSlotLabel = new Label();
            DateLabel = new Label();
            MonsterName = new TextBox();
            IngameDate = new TextBox();
            LifeGRText = new TextBox();
            PowerGRText = new TextBox();
            IntelGRText = new TextBox();
            SpeedGRText = new TextBox();
            DefenGRText = new TextBox();
            MoneyText = new TextBox();
            LifeTypeText = new TextBox();
            LifespanText = new TextBox();
            SenseText = new TextBox();
            StressText = new TextBox();
            FatigueText = new TextBox();
            FearText = new TextBox();
            SpoilText = new TextBox();
            AgeText = new TextBox();
            LifeStageText = new TextBox();
            FormText = new TextBox();
            ArenaSPDText = new TextBox();
            Trait1Text = new TextBox();
            Trait2Text = new TextBox();
            Trait3Text = new TextBox();
            Trait4Text = new TextBox();
            Trait5Text = new TextBox();
            Trait6Text = new TextBox();
            Trait7Text = new TextBox();
            Trait8Text = new TextBox();
            Trait9Text = new TextBox();
            ProteinText = new TextBox();
            VitaminText = new TextBox();
            MineralText = new TextBox();
            GRText = new TextBox();
            RenameAction = new Button();
            CancelRename = new Button();
            MoveNameBox = new TextBox();
            LvlXPBox = new TextBox();
            CostBox = new TextBox();
            AccuracyBox = new TextBox();
            CritBox = new TextBox();
            WitherBox = new TextBox();
            ForceBox = new TextBox();
            StatusBox = new TextBox();
            ElementBox = new TextBox();
            SuspendLayout();
            // 
            // AttachButton
            // 
            AttachButton.Location = new Point(6, 422);
            AttachButton.Name = "AttachButton";
            AttachButton.Size = new Size(75, 23);
            AttachButton.TabIndex = 0;
            AttachButton.Text = "Attach";
            AttachButton.UseVisualStyleBackColor = true;
            AttachButton.Click += AttachButton_Click;
            // 
            // EmulatorSelector
            // 
            EmulatorSelector.DropDownStyle = ComboBoxStyle.DropDownList;
            EmulatorSelector.FormattingEnabled = true;
            EmulatorSelector.Items.AddRange(new object[] { "PCSX2 1.6.0", "PCSX2 1.7.X+" });
            EmulatorSelector.Location = new Point(142, 422);
            EmulatorSelector.Name = "EmulatorSelector";
            EmulatorSelector.Size = new Size(121, 23);
            EmulatorSelector.TabIndex = 1;
            EmulatorSelector.SelectedIndexChanged += EmulatorSelector_SelectedIndexChanged;
            // 
            // ShamelessPlugs
            // 
            ShamelessPlugs.Location = new Point(0, 451);
            ShamelessPlugs.Name = "ShamelessPlugs";
            ShamelessPlugs.Size = new Size(800, 22);
            ShamelessPlugs.TabIndex = 2;
            ShamelessPlugs.Text = "Test";
            // 
            // EmuVerLabel
            // 
            EmuVerLabel.AutoSize = true;
            EmuVerLabel.Location = new Point(87, 426);
            EmuVerLabel.Name = "EmuVerLabel";
            EmuVerLabel.Size = new Size(53, 15);
            EmuVerLabel.TabIndex = 3;
            EmuVerLabel.Text = "Emu Ver:";
            // 
            // LifeText
            // 
            LifeText.BackColor = Color.Gold;
            LifeText.BorderStyle = BorderStyle.FixedSingle;
            LifeText.Location = new Point(6, 26);
            LifeText.Name = "LifeText";
            LifeText.ReadOnly = true;
            LifeText.Size = new Size(44, 23);
            LifeText.TabIndex = 4;
            LifeText.Text = "---";
            LifeText.TextAlign = HorizontalAlignment.Center;
            // 
            // PowerText
            // 
            PowerText.BackColor = Color.OrangeRed;
            PowerText.BorderStyle = BorderStyle.FixedSingle;
            PowerText.Location = new Point(56, 26);
            PowerText.Name = "PowerText";
            PowerText.ReadOnly = true;
            PowerText.Size = new Size(44, 23);
            PowerText.TabIndex = 5;
            PowerText.Text = "---";
            PowerText.TextAlign = HorizontalAlignment.Center;
            // 
            // IntelText
            // 
            IntelText.BackColor = Color.GreenYellow;
            IntelText.BorderStyle = BorderStyle.FixedSingle;
            IntelText.Location = new Point(106, 26);
            IntelText.Name = "IntelText";
            IntelText.ReadOnly = true;
            IntelText.Size = new Size(44, 23);
            IntelText.TabIndex = 6;
            IntelText.Text = "---";
            IntelText.TextAlign = HorizontalAlignment.Center;
            // 
            // SpeedText
            // 
            SpeedText.BackColor = Color.Turquoise;
            SpeedText.BorderStyle = BorderStyle.FixedSingle;
            SpeedText.Location = new Point(156, 26);
            SpeedText.Name = "SpeedText";
            SpeedText.ReadOnly = true;
            SpeedText.Size = new Size(44, 23);
            SpeedText.TabIndex = 7;
            SpeedText.Text = "---";
            SpeedText.TextAlign = HorizontalAlignment.Center;
            // 
            // DefenText
            // 
            DefenText.BackColor = Color.MediumPurple;
            DefenText.BorderStyle = BorderStyle.FixedSingle;
            DefenText.Location = new Point(206, 26);
            DefenText.Name = "DefenText";
            DefenText.ReadOnly = true;
            DefenText.Size = new Size(44, 23);
            DefenText.TabIndex = 8;
            DefenText.Text = "---";
            DefenText.TextAlign = HorizontalAlignment.Center;
            // 
            // LifLabel
            // 
            LifLabel.AutoSize = true;
            LifLabel.Location = new Point(6, 8);
            LifLabel.Name = "LifLabel";
            LifLabel.Size = new Size(25, 15);
            LifLabel.TabIndex = 9;
            LifLabel.Text = "LIF.";
            SnarkyTips.SetToolTip(LifLabel, "LIF.\r\n...It's your life.\r\nIf it runs out in combat, your monster falls down and you lose.");
            // 
            // PowerLabel
            // 
            PowerLabel.AutoSize = true;
            PowerLabel.Location = new Point(56, 8);
            PowerLabel.Name = "PowerLabel";
            PowerLabel.Size = new Size(37, 15);
            PowerLabel.TabIndex = 10;
            PowerLabel.Text = "POW.";
            SnarkyTips.SetToolTip(PowerLabel, "POW.\r\nYour monster's physical power. Applies to yellow moves.\r\nOffers some limited defence against incoming POW moves.");
            // 
            // IntelLabel
            // 
            IntelLabel.AutoSize = true;
            IntelLabel.Location = new Point(106, 8);
            IntelLabel.Name = "IntelLabel";
            IntelLabel.Size = new Size(28, 15);
            IntelLabel.TabIndex = 11;
            IntelLabel.Text = "INT.";
            SnarkyTips.SetToolTip(IntelLabel, "INT.\r\nYour monster's mental power. Applies to green moves.\r\nOffers some limited defence against incoming INT moves.");
            // 
            // SpeedLabel
            // 
            SpeedLabel.AutoSize = true;
            SpeedLabel.Location = new Point(156, 8);
            SpeedLabel.Name = "SpeedLabel";
            SpeedLabel.Size = new Size(31, 15);
            SpeedLabel.TabIndex = 12;
            SpeedLabel.Text = "SPD.";
            SnarkyTips.SetToolTip(SpeedLabel, "SPD.\r\nYour monster's one-stop-shop for accuracy and evasion.\r\nNot raising this is unwise, unless you're running Radar, or Sharp Eyes. Or both.");
            // 
            // DefenLabel
            // 
            DefenLabel.AutoSize = true;
            DefenLabel.Location = new Point(206, 8);
            DefenLabel.Name = "DefenLabel";
            DefenLabel.Size = new Size(30, 15);
            DefenLabel.TabIndex = 13;
            DefenLabel.Text = "DEF.";
            SnarkyTips.SetToolTip(DefenLabel, "DEF.\r\nYour monster's robustness. Whilst not as dominant as MR1, it's also not as much of a joke as MR2.\r\nThere's also numerous defensive traits you can pick up to compound on this.\r\n");
            // 
            // UpdateStatTimer
            // 
            UpdateStatTimer.Enabled = true;
            UpdateStatTimer.Interval = 125;
            UpdateStatTimer.Tick += UpdateStatTimer_Tick;
            // 
            // BaseText
            // 
            BaseText.BackColor = Color.White;
            BaseText.BorderStyle = BorderStyle.FixedSingle;
            BaseText.ForeColor = Color.Black;
            BaseText.Location = new Point(256, 26);
            BaseText.Name = "BaseText";
            BaseText.ReadOnly = true;
            BaseText.Size = new Size(44, 23);
            BaseText.TabIndex = 14;
            BaseText.Text = "---";
            BaseText.TextAlign = HorizontalAlignment.Center;
            // 
            // BSTLabel
            // 
            BSTLabel.AutoSize = true;
            BSTLabel.Location = new Point(256, 8);
            BSTLabel.Name = "BSTLabel";
            BSTLabel.Size = new Size(29, 15);
            BSTLabel.TabIndex = 15;
            BSTLabel.Text = "BST:";
            SnarkyTips.SetToolTip(BSTLabel, "Your base stat total.\r\nDoesn't take into account your monster's form, if that even does anything in MR3 stats-wise?");
            // 
            // MonsterNameLabel
            // 
            MonsterNameLabel.AutoSize = true;
            MonsterNameLabel.Location = new Point(676, 9);
            MonsterNameLabel.Name = "MonsterNameLabel";
            MonsterNameLabel.Size = new Size(89, 15);
            MonsterNameLabel.TabIndex = 17;
            MonsterNameLabel.Text = "Monster Name:";
            SnarkyTips.SetToolTip(MonsterNameLabel, "If this is stupid, remember that you chose it.");
            // 
            // SenseLabel
            // 
            SenseLabel.AutoSize = true;
            SenseLabel.Location = new Point(304, 8);
            SenseLabel.Name = "SenseLabel";
            SenseLabel.Size = new Size(40, 15);
            SenseLabel.TabIndex = 32;
            SenseLabel.Text = "Sense:";
            SnarkyTips.SetToolTip(SenseLabel, "Your monster's ability to train. Gets stronger through continuous fighting.");
            // 
            // MoneyLabel
            // 
            MoneyLabel.AutoSize = true;
            MoneyLabel.Location = new Point(444, 8);
            MoneyLabel.Name = "MoneyLabel";
            MoneyLabel.Size = new Size(47, 15);
            MoneyLabel.TabIndex = 26;
            MoneyLabel.Text = "Money:";
            SnarkyTips.SetToolTip(MoneyLabel, "If this hits 0, you will automatically feed your monster Nothing at the start of a month.\r\nYou cannot Game Over in MR3. :)");
            // 
            // LifeTypeLabel
            // 
            LifeTypeLabel.AutoSize = true;
            LifeTypeLabel.Location = new Point(4, 84);
            LifeTypeLabel.Name = "LifeTypeLabel";
            LifeTypeLabel.Size = new Size(56, 15);
            LifeTypeLabel.TabIndex = 28;
            LifeTypeLabel.Text = "Life Type:";
            SnarkyTips.SetToolTip(LifeTypeLabel, "Your monster's life type. \r\nDetermines how stat growth is distributed through your monster's life.");
            // 
            // LifespanLabel
            // 
            LifespanLabel.AutoSize = true;
            LifespanLabel.Location = new Point(120, 84);
            LifespanLabel.Name = "LifespanLabel";
            LifespanLabel.Size = new Size(54, 15);
            LifespanLabel.TabIndex = 30;
            LifespanLabel.Text = "Lifespan:";
            SnarkyTips.SetToolTip(LifespanLabel, "When this hits 0, it's lights out for your monster.\r\nPossible to be somewhat extended by feeding a Monster Heart. \r\nCan also be +/- 12.7 weeks the listed values on LegendCup thanks to CD generation.");
            // 
            // PersonalityLabel
            // 
            PersonalityLabel.AutoSize = true;
            PersonalityLabel.Location = new Point(267, 404);
            PersonalityLabel.Name = "PersonalityLabel";
            PersonalityLabel.Size = new Size(104, 15);
            PersonalityLabel.TabIndex = 34;
            PersonalityLabel.Text = "Personality Values:";
            SnarkyTips.SetToolTip(PersonalityLabel, resources.GetString("PersonalityLabel.ToolTip"));
            // 
            // MonTagsLabel
            // 
            MonTagsLabel.AutoSize = true;
            MonTagsLabel.Location = new Point(460, 404);
            MonTagsLabel.Name = "MonTagsLabel";
            MonTagsLabel.Size = new Size(80, 15);
            MonTagsLabel.TabIndex = 35;
            MonTagsLabel.Text = "Monster Tags:";
            SnarkyTips.SetToolTip(MonTagsLabel, "These determine important things like:\r\n\"Does my monster have feet?\", \"Is my monster a mecha?\" and \"Just how many defence up/evasion down traits can I stack?!\"");
            // 
            // StressLabel
            // 
            StressLabel.AutoSize = true;
            StressLabel.Location = new Point(236, 84);
            StressLabel.Name = "StressLabel";
            StressLabel.Size = new Size(40, 15);
            StressLabel.TabIndex = 38;
            StressLabel.Text = "Stress:";
            SnarkyTips.SetToolTip(StressLabel, "Somewhat hidden value that builds up over time.\r\nCan be reduced by battle, resting, or by passive items from the shop.");
            // 
            // FatigueLabel
            // 
            FatigueLabel.AutoSize = true;
            FatigueLabel.Location = new Point(285, 84);
            FatigueLabel.Name = "FatigueLabel";
            FatigueLabel.Size = new Size(49, 15);
            FatigueLabel.TabIndex = 40;
            FatigueLabel.Text = "Fatigue:";
            SnarkyTips.SetToolTip(FatigueLabel, "Somewhat hidden value that builds up over time.\r\nCan be reduced by resting, or by passive items from the shop.\r\n");
            // 
            // FearLabel
            // 
            FearLabel.AutoSize = true;
            FearLabel.Location = new Point(385, 84);
            FearLabel.Name = "FearLabel";
            FearLabel.Size = new Size(32, 15);
            FearLabel.TabIndex = 44;
            FearLabel.Text = "Fear:";
            SnarkyTips.SetToolTip(FearLabel, "One of two values contributing to the heart bar.\r\nIncreases by either challenging your monster, or being mean to them.");
            // 
            // SpoilLabel
            // 
            SpoilLabel.AutoSize = true;
            SpoilLabel.Location = new Point(335, 84);
            SpoilLabel.Name = "SpoilLabel";
            SpoilLabel.Size = new Size(36, 15);
            SpoilLabel.TabIndex = 42;
            SpoilLabel.Text = "Spoil:";
            SnarkyTips.SetToolTip(SpoilLabel, resources.GetString("SpoilLabel.ToolTip"));
            // 
            // AgeLabel
            // 
            AgeLabel.AutoSize = true;
            AgeLabel.Location = new Point(4, 129);
            AgeLabel.Name = "AgeLabel";
            AgeLabel.Size = new Size(31, 15);
            AgeLabel.TabIndex = 46;
            AgeLabel.Text = "Age:";
            SnarkyTips.SetToolTip(AgeLabel, "Your monster's life type. \r\nDetermines how stat growth is distributed through your monster's life.");
            // 
            // LifeStageLabel
            // 
            LifeStageLabel.AutoSize = true;
            LifeStageLabel.Location = new Point(120, 129);
            LifeStageLabel.Name = "LifeStageLabel";
            LifeStageLabel.Size = new Size(61, 15);
            LifeStageLabel.TabIndex = 48;
            LifeStageLabel.Text = "Life Stage:";
            SnarkyTips.SetToolTip(LifeStageLabel, "Which of the 16 life stages your monster is on.\r\nSize growths happen between 4-5, 8-9, 12-13.\r\nOn 4->5 and 8->9, you can also transform if you feed enough of that region's food whilst training there.");
            // 
            // FormLabel
            // 
            FormLabel.AutoSize = true;
            FormLabel.Location = new Point(236, 129);
            FormLabel.Name = "FormLabel";
            FormLabel.Size = new Size(38, 15);
            FormLabel.TabIndex = 50;
            FormLabel.Text = "Form:";
            SnarkyTips.SetToolTip(FormLabel, "How skinny or fat your monster is.\r\nIt is currently untested if this has any effect on SPD or DEF.");
            // 
            // GrowthLabel
            // 
            GrowthLabel.AutoSize = true;
            GrowthLabel.Location = new Point(256, 58);
            GrowthLabel.Name = "GrowthLabel";
            GrowthLabel.Size = new Size(98, 15);
            GrowthLabel.TabIndex = 51;
            GrowthLabel.Text = "<- Growth Values";
            SnarkyTips.SetToolTip(GrowthLabel, "These are how good your monster is at training these stats.\r\nIf you're doing two-stat drills, more than 7 on your main stat is a bit of a waste.");
            // 
            // MoveSpdLabel
            // 
            MoveSpdLabel.AutoSize = true;
            MoveSpdLabel.Location = new Point(356, 8);
            MoveSpdLabel.Name = "MoveSpdLabel";
            MoveSpdLabel.Size = new Size(65, 15);
            MoveSpdLabel.TabIndex = 53;
            MoveSpdLabel.Text = "Arena SPD:";
            SnarkyTips.SetToolTip(MoveSpdLabel, "I have no idea what the ranges are for this but I know one thing.\r\nMORE NUMBER MAKE MONSTER GO FAST MROE GOODER");
            // 
            // Trait1Label
            // 
            Trait1Label.AutoSize = true;
            Trait1Label.Location = new Point(444, 85);
            Trait1Label.Name = "Trait1Label";
            Trait1Label.Size = new Size(41, 15);
            Trait1Label.TabIndex = 65;
            Trait1Label.Text = "Trait 1:";
            SnarkyTips.SetToolTip(Trait1Label, "One of your 9 Monster Traits.\r\nIf you have no active personality, the 9th is invisible in game.\r\n");
            // 
            // Trait3Label
            // 
            Trait3Label.AutoSize = true;
            Trait3Label.Location = new Point(676, 85);
            Trait3Label.Name = "Trait3Label";
            Trait3Label.Size = new Size(41, 15);
            Trait3Label.TabIndex = 63;
            Trait3Label.Text = "Trait 3:";
            SnarkyTips.SetToolTip(Trait3Label, "One of your 9 Monster Traits.\r\nIf you have no active personality, the 9th is invisible in game.\r\n");
            // 
            // Trait4Label
            // 
            Trait4Label.AutoSize = true;
            Trait4Label.Location = new Point(444, 130);
            Trait4Label.Name = "Trait4Label";
            Trait4Label.Size = new Size(41, 15);
            Trait4Label.TabIndex = 68;
            Trait4Label.Text = "Trait 4:";
            SnarkyTips.SetToolTip(Trait4Label, "One of your 9 Monster Traits.\r\nIf you have no active personality, the 9th is invisible in game.\r\n");
            // 
            // Trait6Label
            // 
            Trait6Label.AutoSize = true;
            Trait6Label.Location = new Point(676, 130);
            Trait6Label.Name = "Trait6Label";
            Trait6Label.Size = new Size(41, 15);
            Trait6Label.TabIndex = 66;
            Trait6Label.Text = "Trait 6:";
            SnarkyTips.SetToolTip(Trait6Label, "One of your 9 Monster Traits.\r\nIf you have no active personality, the 9th is invisible in game.\r\n");
            // 
            // Trait7Label
            // 
            Trait7Label.AutoSize = true;
            Trait7Label.Location = new Point(444, 175);
            Trait7Label.Name = "Trait7Label";
            Trait7Label.Size = new Size(41, 15);
            Trait7Label.TabIndex = 71;
            Trait7Label.Text = "Trait 7:";
            SnarkyTips.SetToolTip(Trait7Label, "One of your 9 Monster Traits.\r\nIf you have no active personality, the 9th is invisible in game.\r\n");
            // 
            // Trait9Label
            // 
            Trait9Label.AutoSize = true;
            Trait9Label.Location = new Point(676, 175);
            Trait9Label.Name = "Trait9Label";
            Trait9Label.Size = new Size(41, 15);
            Trait9Label.TabIndex = 69;
            Trait9Label.Text = "Trait 9:";
            SnarkyTips.SetToolTip(Trait9Label, "One of your 9 Monster Traits.\r\nIf you have no active personality, the 9th is invisible in game.\r\n");
            // 
            // Trait2Label
            // 
            Trait2Label.AutoSize = true;
            Trait2Label.Location = new Point(560, 85);
            Trait2Label.Name = "Trait2Label";
            Trait2Label.Size = new Size(41, 15);
            Trait2Label.TabIndex = 64;
            Trait2Label.Text = "Trait 2:";
            SnarkyTips.SetToolTip(Trait2Label, "One of your 9 Monster Traits.\r\nIf you have no active personality, the 9th is invisible in game.\r\n");
            // 
            // Trait5Label
            // 
            Trait5Label.AutoSize = true;
            Trait5Label.Location = new Point(560, 130);
            Trait5Label.Name = "Trait5Label";
            Trait5Label.Size = new Size(41, 15);
            Trait5Label.TabIndex = 67;
            Trait5Label.Text = "Trait 5:";
            SnarkyTips.SetToolTip(Trait5Label, "One of your 9 Monster Traits.\r\nIf you have no active personality, the 9th is invisible in game.\r\n");
            // 
            // Trait8Label
            // 
            Trait8Label.AutoSize = true;
            Trait8Label.Location = new Point(560, 175);
            Trait8Label.Name = "Trait8Label";
            Trait8Label.Size = new Size(41, 15);
            Trait8Label.TabIndex = 70;
            Trait8Label.Text = "Trait 8:";
            SnarkyTips.SetToolTip(Trait8Label, "One of your 9 Monster Traits.\r\nIf you have no active personality, the 9th is invisible in game.\r\n");
            // 
            // ProteinLabel
            // 
            ProteinLabel.AutoSize = true;
            ProteinLabel.Location = new Point(4, 174);
            ProteinLabel.Name = "ProteinLabel";
            ProteinLabel.Size = new Size(48, 15);
            ProteinLabel.TabIndex = 73;
            ProteinLabel.Text = "Protein:";
            SnarkyTips.SetToolTip(ProteinLabel, resources.GetString("ProteinLabel.ToolTip"));
            // 
            // VitaminLabel
            // 
            VitaminLabel.AutoSize = true;
            VitaminLabel.Location = new Point(54, 174);
            VitaminLabel.Name = "VitaminLabel";
            VitaminLabel.Size = new Size(51, 15);
            VitaminLabel.TabIndex = 75;
            VitaminLabel.Text = "Vitamin:";
            SnarkyTips.SetToolTip(VitaminLabel, resources.GetString("VitaminLabel.ToolTip"));
            // 
            // MineralLabel
            // 
            MineralLabel.AutoSize = true;
            MineralLabel.Location = new Point(104, 174);
            MineralLabel.Name = "MineralLabel";
            MineralLabel.Size = new Size(50, 15);
            MineralLabel.TabIndex = 77;
            MineralLabel.Text = "Mineral:";
            SnarkyTips.SetToolTip(MineralLabel, resources.GetString("MineralLabel.ToolTip"));
            // 
            // GRLabel
            // 
            GRLabel.AutoSize = true;
            GRLabel.Location = new Point(354, 129);
            GRLabel.Name = "GRLabel";
            GRLabel.Size = new Size(60, 15);
            GRLabel.TabIndex = 79;
            GRLabel.Text = "Guts Rate:";
            SnarkyTips.SetToolTip(GRLabel, "How fast your monster generates resource (Guts... or GATS) in battle.\r\nFaster values might reduce the accuracy/damage bonus you get from having more, but you can swing more so... *shrug*");
            // 
            // DMLabel
            // 
            DMLabel.AutoSize = true;
            DMLabel.Location = new Point(566, 404);
            DMLabel.Name = "DMLabel";
            DMLabel.Size = new Size(107, 15);
            DMLabel.TabIndex = 83;
            DMLabel.Text = "Damage Modifiers:";
            SnarkyTips.SetToolTip(DMLabel, resources.GetString("DMLabel.ToolTip"));
            // 
            // PersonalityMatrix
            // 
            PersonalityMatrix.BackColor = SystemColors.ButtonFace;
            PersonalityMatrix.BorderStyle = BorderStyle.FixedSingle;
            PersonalityMatrix.ForeColor = Color.Black;
            PersonalityMatrix.Location = new Point(269, 422);
            PersonalityMatrix.Name = "PersonalityMatrix";
            PersonalityMatrix.ReadOnly = true;
            PersonalityMatrix.Size = new Size(187, 23);
            PersonalityMatrix.TabIndex = 33;
            PersonalityMatrix.Text = "---";
            PersonalityMatrix.TextAlign = HorizontalAlignment.Center;
            SnarkyTips.SetToolTip(PersonalityMatrix, resources.GetString("PersonalityMatrix.ToolTip"));
            // 
            // TagMatrix
            // 
            TagMatrix.BackColor = SystemColors.ButtonFace;
            TagMatrix.BorderStyle = BorderStyle.FixedSingle;
            TagMatrix.ForeColor = Color.Black;
            TagMatrix.Location = new Point(462, 422);
            TagMatrix.Name = "TagMatrix";
            TagMatrix.ReadOnly = true;
            TagMatrix.Size = new Size(100, 23);
            TagMatrix.TabIndex = 36;
            TagMatrix.Text = "---";
            TagMatrix.TextAlign = HorizontalAlignment.Center;
            SnarkyTips.SetToolTip(TagMatrix, "These determine important things like:\r\n\"Does my monster have feet?\", \"Is my monster a mecha?\" and \"Just how many defence up/evasion down traits can I stack?!\"\r\n");
            // 
            // DamageModText
            // 
            DamageModText.BackColor = SystemColors.ButtonFace;
            DamageModText.BorderStyle = BorderStyle.FixedSingle;
            DamageModText.ForeColor = Color.Black;
            DamageModText.Location = new Point(568, 422);
            DamageModText.Name = "DamageModText";
            DamageModText.ReadOnly = true;
            DamageModText.Size = new Size(220, 23);
            DamageModText.TabIndex = 82;
            DamageModText.Text = "---";
            DamageModText.TextAlign = HorizontalAlignment.Center;
            SnarkyTips.SetToolTip(DamageModText, resources.GetString("DamageModText.ToolTip"));
            // 
            // CostLabel
            // 
            CostLabel.AutoSize = true;
            CostLabel.Location = new Point(234, 223);
            CostLabel.Name = "CostLabel";
            CostLabel.Size = new Size(34, 15);
            CostLabel.TabIndex = 89;
            CostLabel.Text = "Cost:";
            SnarkyTips.SetToolTip(CostLabel, "How much (in Guts) it costs to use this move in battle.");
            // 
            // HitLabel
            // 
            HitLabel.AutoSize = true;
            HitLabel.Location = new Point(283, 223);
            HitLabel.Name = "HitLabel";
            HitLabel.Size = new Size(36, 15);
            HitLabel.TabIndex = 91;
            HitLabel.Text = "Hit%:";
            SnarkyTips.SetToolTip(HitLabel, "The percentage chance to hit, if all factors* are equal.\r\n*Factors include: Guts rate, total guts, speed, accuracy buffs/debuffs through traits, etc.");
            // 
            // CritLabel
            // 
            CritLabel.AutoSize = true;
            CritLabel.Location = new Point(333, 223);
            CritLabel.Name = "CritLabel";
            CritLabel.Size = new Size(39, 15);
            CritLabel.TabIndex = 93;
            CritLabel.Text = "Crit%:";
            SnarkyTips.SetToolTip(CritLabel, "How likely the move is to score a critical hit, dealing 50% extra damage.");
            // 
            // WitherLabel
            // 
            WitherLabel.AutoSize = true;
            WitherLabel.Location = new Point(383, 223);
            WitherLabel.Name = "WitherLabel";
            WitherLabel.Size = new Size(45, 15);
            WitherLabel.TabIndex = 95;
            WitherLabel.Text = "Wither:";
            SnarkyTips.SetToolTip(WitherLabel, "How much Guts the move will remove from the opponent on hit.\r\nWorth noting: MR3 will limit Guts damage on low Guts opponents to prevent a complete lockout situation.");
            // 
            // ForceLabel
            // 
            ForceLabel.AutoSize = true;
            ForceLabel.Location = new Point(432, 223);
            ForceLabel.Name = "ForceLabel";
            ForceLabel.Size = new Size(39, 15);
            ForceLabel.TabIndex = 97;
            ForceLabel.Text = "Force:";
            SnarkyTips.SetToolTip(ForceLabel, "How much damage the move does.\r\n(For healing techs, this is how much healing it does.)");
            // 
            // MoveNameLabel
            // 
            MoveNameLabel.AutoSize = true;
            MoveNameLabel.Location = new Point(4, 223);
            MoveNameLabel.Name = "MoveNameLabel";
            MoveNameLabel.Size = new Size(75, 15);
            MoveNameLabel.TabIndex = 85;
            MoveNameLabel.Text = "Move Name:";
            SnarkyTips.SetToolTip(MoveNameLabel, "It's the name of the move in this slot.\r\nIf the box is highlighted yellow; it's a Power move.\r\nIf the box is highlighted green; it's an Intelligence move.");
            // 
            // XPLvlLabel
            // 
            XPLvlLabel.AutoSize = true;
            XPLvlLabel.Location = new Point(120, 223);
            XPLvlLabel.Name = "XPLvlLabel";
            XPLvlLabel.Size = new Size(56, 15);
            XPLvlLabel.TabIndex = 87;
            XPLvlLabel.Text = "Level/XP:";
            SnarkyTips.SetToolTip(XPLvlLabel, "The move's current level, how much XP it has gained from Noisy Halls\r\nand how much XP it has to gain to hit the next level.");
            // 
            // EffectLabel
            // 
            EffectLabel.AutoSize = true;
            EffectLabel.Location = new Point(482, 223);
            EffectLabel.Name = "EffectLabel";
            EffectLabel.Size = new Size(75, 15);
            EffectLabel.TabIndex = 99;
            EffectLabel.Text = "Status Effect:";
            SnarkyTips.SetToolTip(EffectLabel, "Any status effects a move has, as well as their duration and activation chance.\r\n");
            // 
            // ElementLabel
            // 
            ElementLabel.AutoSize = true;
            ElementLabel.Location = new Point(641, 223);
            ElementLabel.Name = "ElementLabel";
            ElementLabel.Size = new Size(58, 15);
            ElementLabel.TabIndex = 101;
            ElementLabel.Text = "Elements:";
            SnarkyTips.SetToolTip(ElementLabel, "The elements of the move. \r\nThese are checked against the Damage Modifiers, but the effect is uncertain.");
            // 
            // OldHitPercent
            // 
            OldHitPercent.AutoSize = true;
            OldHitPercent.Location = new Point(567, 273);
            OldHitPercent.Name = "OldHitPercent";
            OldHitPercent.Size = new Size(74, 19);
            OldHitPercent.TabIndex = 102;
            OldHitPercent.Text = "Old Hit%";
            SnarkyTips.SetToolTip(OldHitPercent, "If you prefer your accuracy readout with 0 being 50%, this is the box for you!");
            OldHitPercent.UseVisualStyleBackColor = true;
            OldHitPercent.CheckedChanged += OldHitPercent_CheckedChanged;
            // 
            // MoveSlotID
            // 
            MoveSlotID.DropDownStyle = ComboBoxStyle.DropDownList;
            MoveSlotID.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MoveSlotID.FormattingEnabled = true;
            MoveSlotID.Items.AddRange(new object[] { "Slot 1", "Slot 2", "Slot 3", "Slot 4" });
            MoveSlotID.Location = new Point(712, 270);
            MoveSlotID.MaxDropDownItems = 4;
            MoveSlotID.Name = "MoveSlotID";
            MoveSlotID.Size = new Size(76, 23);
            MoveSlotID.TabIndex = 103;
            SnarkyTips.SetToolTip(MoveSlotID, "Which move slot you want to look at.\r\n");
            MoveSlotID.SelectedIndexChanged += MoveSlotID_SelectedIndexChanged;
            // 
            // MoveSlotLabel
            // 
            MoveSlotLabel.AutoSize = true;
            MoveSlotLabel.Location = new Point(646, 274);
            MoveSlotLabel.Name = "MoveSlotLabel";
            MoveSlotLabel.Size = new Size(63, 15);
            MoveSlotLabel.TabIndex = 104;
            MoveSlotLabel.Text = "Move Slot:";
            SnarkyTips.SetToolTip(MoveSlotLabel, "Which move slot you want to look at.");
            // 
            // DateLabel
            // 
            DateLabel.AutoSize = true;
            DateLabel.Location = new Point(560, 8);
            DateLabel.Name = "DateLabel";
            DateLabel.Size = new Size(77, 15);
            DateLabel.TabIndex = 19;
            DateLabel.Text = "Current Date:";
            // 
            // MonsterName
            // 
            MonsterName.BackColor = SystemColors.ButtonFace;
            MonsterName.BorderStyle = BorderStyle.FixedSingle;
            MonsterName.ForeColor = Color.Black;
            MonsterName.Location = new Point(678, 26);
            MonsterName.MaxLength = 12;
            MonsterName.Name = "MonsterName";
            MonsterName.ReadOnly = true;
            MonsterName.Size = new Size(110, 23);
            MonsterName.TabIndex = 16;
            MonsterName.Text = "---";
            MonsterName.TextAlign = HorizontalAlignment.Center;
            // 
            // IngameDate
            // 
            IngameDate.BackColor = SystemColors.ButtonFace;
            IngameDate.BorderStyle = BorderStyle.FixedSingle;
            IngameDate.ForeColor = Color.Black;
            IngameDate.Location = new Point(562, 26);
            IngameDate.Name = "IngameDate";
            IngameDate.ReadOnly = true;
            IngameDate.Size = new Size(110, 23);
            IngameDate.TabIndex = 18;
            IngameDate.Text = "---";
            IngameDate.TextAlign = HorizontalAlignment.Center;
            // 
            // LifeGRText
            // 
            LifeGRText.BackColor = Color.Gold;
            LifeGRText.BorderStyle = BorderStyle.FixedSingle;
            LifeGRText.Location = new Point(6, 55);
            LifeGRText.Name = "LifeGRText";
            LifeGRText.ReadOnly = true;
            LifeGRText.Size = new Size(44, 23);
            LifeGRText.TabIndex = 20;
            LifeGRText.Text = "---";
            LifeGRText.TextAlign = HorizontalAlignment.Center;
            // 
            // PowerGRText
            // 
            PowerGRText.BackColor = Color.OrangeRed;
            PowerGRText.BorderStyle = BorderStyle.FixedSingle;
            PowerGRText.Location = new Point(56, 55);
            PowerGRText.Name = "PowerGRText";
            PowerGRText.ReadOnly = true;
            PowerGRText.Size = new Size(44, 23);
            PowerGRText.TabIndex = 21;
            PowerGRText.Text = "---";
            PowerGRText.TextAlign = HorizontalAlignment.Center;
            // 
            // IntelGRText
            // 
            IntelGRText.BackColor = Color.GreenYellow;
            IntelGRText.BorderStyle = BorderStyle.FixedSingle;
            IntelGRText.Location = new Point(106, 55);
            IntelGRText.Name = "IntelGRText";
            IntelGRText.ReadOnly = true;
            IntelGRText.Size = new Size(44, 23);
            IntelGRText.TabIndex = 22;
            IntelGRText.Text = "---";
            IntelGRText.TextAlign = HorizontalAlignment.Center;
            // 
            // SpeedGRText
            // 
            SpeedGRText.BackColor = Color.Turquoise;
            SpeedGRText.BorderStyle = BorderStyle.FixedSingle;
            SpeedGRText.Location = new Point(156, 55);
            SpeedGRText.Name = "SpeedGRText";
            SpeedGRText.ReadOnly = true;
            SpeedGRText.Size = new Size(44, 23);
            SpeedGRText.TabIndex = 23;
            SpeedGRText.Text = "---";
            SpeedGRText.TextAlign = HorizontalAlignment.Center;
            // 
            // DefenGRText
            // 
            DefenGRText.BackColor = Color.MediumPurple;
            DefenGRText.BorderStyle = BorderStyle.FixedSingle;
            DefenGRText.Location = new Point(206, 55);
            DefenGRText.Name = "DefenGRText";
            DefenGRText.ReadOnly = true;
            DefenGRText.Size = new Size(44, 23);
            DefenGRText.TabIndex = 24;
            DefenGRText.Text = "---";
            DefenGRText.TextAlign = HorizontalAlignment.Center;
            // 
            // MoneyText
            // 
            MoneyText.BackColor = SystemColors.ButtonFace;
            MoneyText.BorderStyle = BorderStyle.FixedSingle;
            MoneyText.ForeColor = Color.Black;
            MoneyText.Location = new Point(446, 26);
            MoneyText.Name = "MoneyText";
            MoneyText.ReadOnly = true;
            MoneyText.Size = new Size(110, 23);
            MoneyText.TabIndex = 25;
            MoneyText.Text = "---";
            MoneyText.TextAlign = HorizontalAlignment.Center;
            // 
            // LifeTypeText
            // 
            LifeTypeText.BackColor = SystemColors.ButtonFace;
            LifeTypeText.BorderStyle = BorderStyle.FixedSingle;
            LifeTypeText.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LifeTypeText.ForeColor = Color.Black;
            LifeTypeText.Location = new Point(6, 102);
            LifeTypeText.Name = "LifeTypeText";
            LifeTypeText.ReadOnly = true;
            LifeTypeText.Size = new Size(110, 22);
            LifeTypeText.TabIndex = 27;
            LifeTypeText.Text = "---";
            LifeTypeText.TextAlign = HorizontalAlignment.Center;
            // 
            // LifespanText
            // 
            LifespanText.BackColor = SystemColors.ButtonFace;
            LifespanText.BorderStyle = BorderStyle.FixedSingle;
            LifespanText.ForeColor = Color.Black;
            LifespanText.Location = new Point(122, 102);
            LifespanText.Name = "LifespanText";
            LifespanText.ReadOnly = true;
            LifespanText.Size = new Size(110, 23);
            LifespanText.TabIndex = 29;
            LifespanText.Text = "---";
            LifespanText.TextAlign = HorizontalAlignment.Center;
            // 
            // SenseText
            // 
            SenseText.BackColor = Color.SeaShell;
            SenseText.BorderStyle = BorderStyle.FixedSingle;
            SenseText.ForeColor = Color.Black;
            SenseText.Location = new Point(306, 26);
            SenseText.Name = "SenseText";
            SenseText.ReadOnly = true;
            SenseText.Size = new Size(50, 23);
            SenseText.TabIndex = 31;
            SenseText.Text = "---";
            SenseText.TextAlign = HorizontalAlignment.Center;
            // 
            // StressText
            // 
            StressText.BackColor = SystemColors.ButtonFace;
            StressText.BorderStyle = BorderStyle.FixedSingle;
            StressText.ForeColor = Color.Black;
            StressText.Location = new Point(238, 102);
            StressText.Name = "StressText";
            StressText.ReadOnly = true;
            StressText.Size = new Size(44, 23);
            StressText.TabIndex = 37;
            StressText.Text = "---";
            StressText.TextAlign = HorizontalAlignment.Center;
            // 
            // FatigueText
            // 
            FatigueText.BackColor = SystemColors.ButtonFace;
            FatigueText.BorderStyle = BorderStyle.FixedSingle;
            FatigueText.ForeColor = Color.Black;
            FatigueText.Location = new Point(288, 102);
            FatigueText.Name = "FatigueText";
            FatigueText.ReadOnly = true;
            FatigueText.Size = new Size(44, 23);
            FatigueText.TabIndex = 39;
            FatigueText.Text = "---";
            FatigueText.TextAlign = HorizontalAlignment.Center;
            // 
            // FearText
            // 
            FearText.BackColor = SystemColors.ButtonFace;
            FearText.BorderStyle = BorderStyle.FixedSingle;
            FearText.ForeColor = Color.Black;
            FearText.Location = new Point(388, 102);
            FearText.Name = "FearText";
            FearText.ReadOnly = true;
            FearText.Size = new Size(44, 23);
            FearText.TabIndex = 43;
            FearText.Text = "---";
            FearText.TextAlign = HorizontalAlignment.Center;
            // 
            // SpoilText
            // 
            SpoilText.BackColor = SystemColors.ButtonFace;
            SpoilText.BorderStyle = BorderStyle.FixedSingle;
            SpoilText.ForeColor = Color.Black;
            SpoilText.Location = new Point(338, 102);
            SpoilText.Name = "SpoilText";
            SpoilText.ReadOnly = true;
            SpoilText.Size = new Size(44, 23);
            SpoilText.TabIndex = 41;
            SpoilText.Text = "---";
            SpoilText.TextAlign = HorizontalAlignment.Center;
            // 
            // AgeText
            // 
            AgeText.BackColor = SystemColors.ButtonFace;
            AgeText.BorderStyle = BorderStyle.FixedSingle;
            AgeText.ForeColor = Color.Black;
            AgeText.Location = new Point(6, 147);
            AgeText.Name = "AgeText";
            AgeText.ReadOnly = true;
            AgeText.Size = new Size(110, 23);
            AgeText.TabIndex = 45;
            AgeText.Text = "---";
            AgeText.TextAlign = HorizontalAlignment.Center;
            // 
            // LifeStageText
            // 
            LifeStageText.BackColor = SystemColors.ButtonFace;
            LifeStageText.BorderStyle = BorderStyle.FixedSingle;
            LifeStageText.ForeColor = Color.Black;
            LifeStageText.Location = new Point(122, 147);
            LifeStageText.Name = "LifeStageText";
            LifeStageText.ReadOnly = true;
            LifeStageText.Size = new Size(110, 23);
            LifeStageText.TabIndex = 47;
            LifeStageText.Text = "---";
            LifeStageText.TextAlign = HorizontalAlignment.Center;
            // 
            // FormText
            // 
            FormText.BackColor = SystemColors.ButtonFace;
            FormText.BorderStyle = BorderStyle.FixedSingle;
            FormText.ForeColor = Color.Black;
            FormText.Location = new Point(238, 147);
            FormText.Name = "FormText";
            FormText.ReadOnly = true;
            FormText.Size = new Size(110, 23);
            FormText.TabIndex = 49;
            FormText.Text = "---";
            FormText.TextAlign = HorizontalAlignment.Center;
            // 
            // ArenaSPDText
            // 
            ArenaSPDText.BackColor = Color.BlanchedAlmond;
            ArenaSPDText.BorderStyle = BorderStyle.FixedSingle;
            ArenaSPDText.ForeColor = Color.Black;
            ArenaSPDText.Location = new Point(362, 26);
            ArenaSPDText.Name = "ArenaSPDText";
            ArenaSPDText.ReadOnly = true;
            ArenaSPDText.Size = new Size(50, 23);
            ArenaSPDText.TabIndex = 52;
            ArenaSPDText.Text = "---";
            ArenaSPDText.TextAlign = HorizontalAlignment.Center;
            // 
            // Trait1Text
            // 
            Trait1Text.BackColor = SystemColors.ButtonFace;
            Trait1Text.BorderStyle = BorderStyle.FixedSingle;
            Trait1Text.ForeColor = Color.Black;
            Trait1Text.Location = new Point(446, 102);
            Trait1Text.Name = "Trait1Text";
            Trait1Text.ReadOnly = true;
            Trait1Text.Size = new Size(110, 23);
            Trait1Text.TabIndex = 56;
            Trait1Text.Text = "---";
            Trait1Text.TextAlign = HorizontalAlignment.Center;
            // 
            // Trait2Text
            // 
            Trait2Text.BackColor = SystemColors.ButtonFace;
            Trait2Text.BorderStyle = BorderStyle.FixedSingle;
            Trait2Text.ForeColor = Color.Black;
            Trait2Text.Location = new Point(562, 102);
            Trait2Text.Name = "Trait2Text";
            Trait2Text.ReadOnly = true;
            Trait2Text.Size = new Size(110, 23);
            Trait2Text.TabIndex = 55;
            Trait2Text.Text = "---";
            Trait2Text.TextAlign = HorizontalAlignment.Center;
            // 
            // Trait3Text
            // 
            Trait3Text.BackColor = SystemColors.ButtonFace;
            Trait3Text.BorderStyle = BorderStyle.FixedSingle;
            Trait3Text.ForeColor = Color.Black;
            Trait3Text.Location = new Point(678, 102);
            Trait3Text.Name = "Trait3Text";
            Trait3Text.ReadOnly = true;
            Trait3Text.Size = new Size(110, 23);
            Trait3Text.TabIndex = 54;
            Trait3Text.Text = "---";
            Trait3Text.TextAlign = HorizontalAlignment.Center;
            // 
            // Trait4Text
            // 
            Trait4Text.BackColor = SystemColors.ButtonFace;
            Trait4Text.BorderStyle = BorderStyle.FixedSingle;
            Trait4Text.ForeColor = Color.Black;
            Trait4Text.Location = new Point(446, 147);
            Trait4Text.Name = "Trait4Text";
            Trait4Text.ReadOnly = true;
            Trait4Text.Size = new Size(110, 23);
            Trait4Text.TabIndex = 59;
            Trait4Text.Text = "---";
            Trait4Text.TextAlign = HorizontalAlignment.Center;
            // 
            // Trait5Text
            // 
            Trait5Text.BackColor = SystemColors.ButtonFace;
            Trait5Text.BorderStyle = BorderStyle.FixedSingle;
            Trait5Text.ForeColor = Color.Black;
            Trait5Text.Location = new Point(562, 147);
            Trait5Text.Name = "Trait5Text";
            Trait5Text.ReadOnly = true;
            Trait5Text.Size = new Size(110, 23);
            Trait5Text.TabIndex = 58;
            Trait5Text.Text = "---";
            Trait5Text.TextAlign = HorizontalAlignment.Center;
            // 
            // Trait6Text
            // 
            Trait6Text.BackColor = SystemColors.ButtonFace;
            Trait6Text.BorderStyle = BorderStyle.FixedSingle;
            Trait6Text.ForeColor = Color.Black;
            Trait6Text.Location = new Point(678, 147);
            Trait6Text.Name = "Trait6Text";
            Trait6Text.ReadOnly = true;
            Trait6Text.Size = new Size(110, 23);
            Trait6Text.TabIndex = 57;
            Trait6Text.Text = "---";
            Trait6Text.TextAlign = HorizontalAlignment.Center;
            // 
            // Trait7Text
            // 
            Trait7Text.BackColor = SystemColors.ButtonFace;
            Trait7Text.BorderStyle = BorderStyle.FixedSingle;
            Trait7Text.ForeColor = Color.Black;
            Trait7Text.Location = new Point(446, 192);
            Trait7Text.Name = "Trait7Text";
            Trait7Text.ReadOnly = true;
            Trait7Text.Size = new Size(110, 23);
            Trait7Text.TabIndex = 62;
            Trait7Text.Text = "---";
            Trait7Text.TextAlign = HorizontalAlignment.Center;
            // 
            // Trait8Text
            // 
            Trait8Text.BackColor = SystemColors.ButtonFace;
            Trait8Text.BorderStyle = BorderStyle.FixedSingle;
            Trait8Text.ForeColor = Color.Black;
            Trait8Text.Location = new Point(562, 192);
            Trait8Text.Name = "Trait8Text";
            Trait8Text.ReadOnly = true;
            Trait8Text.Size = new Size(110, 23);
            Trait8Text.TabIndex = 61;
            Trait8Text.Text = "---";
            Trait8Text.TextAlign = HorizontalAlignment.Center;
            // 
            // Trait9Text
            // 
            Trait9Text.BackColor = SystemColors.ButtonFace;
            Trait9Text.BorderStyle = BorderStyle.FixedSingle;
            Trait9Text.ForeColor = Color.Black;
            Trait9Text.Location = new Point(678, 192);
            Trait9Text.Name = "Trait9Text";
            Trait9Text.ReadOnly = true;
            Trait9Text.Size = new Size(110, 23);
            Trait9Text.TabIndex = 60;
            Trait9Text.Text = "---";
            Trait9Text.TextAlign = HorizontalAlignment.Center;
            // 
            // ProteinText
            // 
            ProteinText.BackColor = SystemColors.ButtonFace;
            ProteinText.BorderStyle = BorderStyle.FixedSingle;
            ProteinText.ForeColor = Color.Black;
            ProteinText.Location = new Point(6, 192);
            ProteinText.Name = "ProteinText";
            ProteinText.ReadOnly = true;
            ProteinText.Size = new Size(44, 23);
            ProteinText.TabIndex = 72;
            ProteinText.Text = "---";
            ProteinText.TextAlign = HorizontalAlignment.Center;
            // 
            // VitaminText
            // 
            VitaminText.BackColor = SystemColors.ButtonFace;
            VitaminText.BorderStyle = BorderStyle.FixedSingle;
            VitaminText.ForeColor = Color.Black;
            VitaminText.Location = new Point(56, 192);
            VitaminText.Name = "VitaminText";
            VitaminText.ReadOnly = true;
            VitaminText.Size = new Size(44, 23);
            VitaminText.TabIndex = 74;
            VitaminText.Text = "---";
            VitaminText.TextAlign = HorizontalAlignment.Center;
            // 
            // MineralText
            // 
            MineralText.BackColor = SystemColors.ButtonFace;
            MineralText.BorderStyle = BorderStyle.FixedSingle;
            MineralText.ForeColor = Color.Black;
            MineralText.Location = new Point(106, 192);
            MineralText.Name = "MineralText";
            MineralText.ReadOnly = true;
            MineralText.Size = new Size(44, 23);
            MineralText.TabIndex = 76;
            MineralText.Text = "---";
            MineralText.TextAlign = HorizontalAlignment.Center;
            // 
            // GRText
            // 
            GRText.BackColor = SystemColors.ButtonFace;
            GRText.BorderStyle = BorderStyle.FixedSingle;
            GRText.ForeColor = Color.Black;
            GRText.Location = new Point(354, 147);
            GRText.Name = "GRText";
            GRText.ReadOnly = true;
            GRText.Size = new Size(78, 23);
            GRText.TabIndex = 78;
            GRText.Text = "---";
            GRText.TextAlign = HorizontalAlignment.Center;
            // 
            // RenameAction
            // 
            RenameAction.Enabled = false;
            RenameAction.Location = new Point(678, 55);
            RenameAction.Name = "RenameAction";
            RenameAction.Size = new Size(110, 23);
            RenameAction.TabIndex = 80;
            RenameAction.Text = "Rename";
            RenameAction.UseVisualStyleBackColor = true;
            RenameAction.Click += RenameAction_Click;
            // 
            // CancelRename
            // 
            CancelRename.Location = new Point(562, 55);
            CancelRename.Name = "CancelRename";
            CancelRename.Size = new Size(110, 23);
            CancelRename.TabIndex = 81;
            CancelRename.Text = "Cancel";
            CancelRename.UseVisualStyleBackColor = true;
            CancelRename.Visible = false;
            CancelRename.Click += CancelRename_Click;
            // 
            // MoveNameBox
            // 
            MoveNameBox.BackColor = SystemColors.ButtonFace;
            MoveNameBox.BorderStyle = BorderStyle.FixedSingle;
            MoveNameBox.ForeColor = Color.Black;
            MoveNameBox.Location = new Point(6, 241);
            MoveNameBox.Name = "MoveNameBox";
            MoveNameBox.ReadOnly = true;
            MoveNameBox.Size = new Size(110, 23);
            MoveNameBox.TabIndex = 84;
            MoveNameBox.Text = "---";
            MoveNameBox.TextAlign = HorizontalAlignment.Center;
            // 
            // LvlXPBox
            // 
            LvlXPBox.BackColor = SystemColors.ButtonFace;
            LvlXPBox.BorderStyle = BorderStyle.FixedSingle;
            LvlXPBox.ForeColor = Color.Black;
            LvlXPBox.Location = new Point(122, 241);
            LvlXPBox.Name = "LvlXPBox";
            LvlXPBox.ReadOnly = true;
            LvlXPBox.Size = new Size(110, 23);
            LvlXPBox.TabIndex = 86;
            LvlXPBox.Text = "---";
            LvlXPBox.TextAlign = HorizontalAlignment.Center;
            // 
            // CostBox
            // 
            CostBox.BackColor = SystemColors.ButtonFace;
            CostBox.BorderStyle = BorderStyle.FixedSingle;
            CostBox.ForeColor = Color.Black;
            CostBox.Location = new Point(236, 241);
            CostBox.Name = "CostBox";
            CostBox.ReadOnly = true;
            CostBox.Size = new Size(44, 23);
            CostBox.TabIndex = 88;
            CostBox.Text = "---";
            CostBox.TextAlign = HorizontalAlignment.Center;
            // 
            // AccuracyBox
            // 
            AccuracyBox.BackColor = SystemColors.ButtonFace;
            AccuracyBox.BorderStyle = BorderStyle.FixedSingle;
            AccuracyBox.ForeColor = Color.Black;
            AccuracyBox.Location = new Point(285, 241);
            AccuracyBox.Name = "AccuracyBox";
            AccuracyBox.ReadOnly = true;
            AccuracyBox.Size = new Size(44, 23);
            AccuracyBox.TabIndex = 90;
            AccuracyBox.Text = "---";
            AccuracyBox.TextAlign = HorizontalAlignment.Center;
            // 
            // CritBox
            // 
            CritBox.BackColor = SystemColors.ButtonFace;
            CritBox.BorderStyle = BorderStyle.FixedSingle;
            CritBox.ForeColor = Color.Black;
            CritBox.Location = new Point(335, 241);
            CritBox.Name = "CritBox";
            CritBox.ReadOnly = true;
            CritBox.Size = new Size(44, 23);
            CritBox.TabIndex = 92;
            CritBox.Text = "---";
            CritBox.TextAlign = HorizontalAlignment.Center;
            // 
            // WitherBox
            // 
            WitherBox.BackColor = SystemColors.ButtonFace;
            WitherBox.BorderStyle = BorderStyle.FixedSingle;
            WitherBox.ForeColor = Color.Black;
            WitherBox.Location = new Point(385, 241);
            WitherBox.Name = "WitherBox";
            WitherBox.ReadOnly = true;
            WitherBox.Size = new Size(44, 23);
            WitherBox.TabIndex = 94;
            WitherBox.Text = "---";
            WitherBox.TextAlign = HorizontalAlignment.Center;
            // 
            // ForceBox
            // 
            ForceBox.BackColor = SystemColors.ButtonFace;
            ForceBox.BorderStyle = BorderStyle.FixedSingle;
            ForceBox.ForeColor = Color.Black;
            ForceBox.Location = new Point(434, 241);
            ForceBox.Name = "ForceBox";
            ForceBox.ReadOnly = true;
            ForceBox.Size = new Size(44, 23);
            ForceBox.TabIndex = 96;
            ForceBox.Text = "---";
            ForceBox.TextAlign = HorizontalAlignment.Center;
            // 
            // StatusBox
            // 
            StatusBox.BackColor = SystemColors.ButtonFace;
            StatusBox.BorderStyle = BorderStyle.FixedSingle;
            StatusBox.ForeColor = Color.Black;
            StatusBox.Location = new Point(484, 241);
            StatusBox.Name = "StatusBox";
            StatusBox.ReadOnly = true;
            StatusBox.Size = new Size(153, 23);
            StatusBox.TabIndex = 98;
            StatusBox.Text = "---";
            StatusBox.TextAlign = HorizontalAlignment.Center;
            // 
            // ElementBox
            // 
            ElementBox.BackColor = SystemColors.ButtonFace;
            ElementBox.BorderStyle = BorderStyle.FixedSingle;
            ElementBox.ForeColor = Color.Black;
            ElementBox.Location = new Point(643, 241);
            ElementBox.Name = "ElementBox";
            ElementBox.ReadOnly = true;
            ElementBox.Size = new Size(145, 23);
            ElementBox.TabIndex = 100;
            ElementBox.Text = "---";
            ElementBox.TextAlign = HorizontalAlignment.Center;
            // 
            // SEMain
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(800, 473);
            Controls.Add(MoveSlotLabel);
            Controls.Add(MoveSlotID);
            Controls.Add(OldHitPercent);
            Controls.Add(ElementLabel);
            Controls.Add(ElementBox);
            Controls.Add(EffectLabel);
            Controls.Add(StatusBox);
            Controls.Add(ForceLabel);
            Controls.Add(ForceBox);
            Controls.Add(WitherLabel);
            Controls.Add(WitherBox);
            Controls.Add(CritLabel);
            Controls.Add(CritBox);
            Controls.Add(HitLabel);
            Controls.Add(AccuracyBox);
            Controls.Add(CostLabel);
            Controls.Add(CostBox);
            Controls.Add(XPLvlLabel);
            Controls.Add(LvlXPBox);
            Controls.Add(MoveNameLabel);
            Controls.Add(MoveNameBox);
            Controls.Add(DMLabel);
            Controls.Add(DamageModText);
            Controls.Add(CancelRename);
            Controls.Add(RenameAction);
            Controls.Add(GRLabel);
            Controls.Add(GRText);
            Controls.Add(MineralLabel);
            Controls.Add(MineralText);
            Controls.Add(VitaminLabel);
            Controls.Add(VitaminText);
            Controls.Add(ProteinLabel);
            Controls.Add(ProteinText);
            Controls.Add(Trait7Label);
            Controls.Add(Trait8Label);
            Controls.Add(Trait9Label);
            Controls.Add(Trait4Label);
            Controls.Add(Trait5Label);
            Controls.Add(Trait6Label);
            Controls.Add(Trait1Label);
            Controls.Add(Trait2Label);
            Controls.Add(Trait3Label);
            Controls.Add(Trait7Text);
            Controls.Add(Trait8Text);
            Controls.Add(Trait9Text);
            Controls.Add(Trait4Text);
            Controls.Add(Trait5Text);
            Controls.Add(Trait6Text);
            Controls.Add(Trait1Text);
            Controls.Add(Trait2Text);
            Controls.Add(Trait3Text);
            Controls.Add(MoveSpdLabel);
            Controls.Add(ArenaSPDText);
            Controls.Add(GrowthLabel);
            Controls.Add(FormLabel);
            Controls.Add(FormText);
            Controls.Add(LifeStageLabel);
            Controls.Add(LifeStageText);
            Controls.Add(AgeLabel);
            Controls.Add(AgeText);
            Controls.Add(FearLabel);
            Controls.Add(FearText);
            Controls.Add(SpoilLabel);
            Controls.Add(SpoilText);
            Controls.Add(FatigueLabel);
            Controls.Add(FatigueText);
            Controls.Add(StressLabel);
            Controls.Add(StressText);
            Controls.Add(TagMatrix);
            Controls.Add(MonTagsLabel);
            Controls.Add(PersonalityLabel);
            Controls.Add(PersonalityMatrix);
            Controls.Add(SenseLabel);
            Controls.Add(SenseText);
            Controls.Add(LifespanLabel);
            Controls.Add(LifespanText);
            Controls.Add(LifeTypeLabel);
            Controls.Add(LifeTypeText);
            Controls.Add(MoneyLabel);
            Controls.Add(MoneyText);
            Controls.Add(DefenGRText);
            Controls.Add(SpeedGRText);
            Controls.Add(IntelGRText);
            Controls.Add(PowerGRText);
            Controls.Add(LifeGRText);
            Controls.Add(DateLabel);
            Controls.Add(IngameDate);
            Controls.Add(MonsterNameLabel);
            Controls.Add(MonsterName);
            Controls.Add(BSTLabel);
            Controls.Add(BaseText);
            Controls.Add(DefenLabel);
            Controls.Add(SpeedLabel);
            Controls.Add(IntelLabel);
            Controls.Add(PowerLabel);
            Controls.Add(LifLabel);
            Controls.Add(DefenText);
            Controls.Add(SpeedText);
            Controls.Add(IntelText);
            Controls.Add(PowerText);
            Controls.Add(LifeText);
            Controls.Add(EmuVerLabel);
            Controls.Add(ShamelessPlugs);
            Controls.Add(EmulatorSelector);
            Controls.Add(AttachButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "SEMain";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Suezo's Eye";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AttachButton;
        internal ComboBox EmulatorSelector;
        private StatusStrip ShamelessPlugs;
        private Label EmuVerLabel;
        private TextBox LifeText;
        private TextBox PowerText;
        private TextBox IntelText;
        private TextBox SpeedText;
        private TextBox DefenText;
        private Label LifLabel;
        private Label PowerLabel;
        private Label IntelLabel;
        private Label SpeedLabel;
        private Label DefenLabel;
        private System.Windows.Forms.Timer UpdateStatTimer;
        private ToolTip SnarkyTips;
        private TextBox BaseText;
        private Label BSTLabel;
        private TextBox MonsterName;
        private Label MonsterNameLabel;
        private TextBox IngameDate;
        private Label DateLabel;
        private TextBox LifeGRText;
        private TextBox PowerGRText;
        private TextBox IntelGRText;
        private TextBox SpeedGRText;
        private TextBox DefenGRText;
        private TextBox MoneyText;
        private Label MoneyLabel;
        private TextBox LifeTypeText;
        private Label LifeTypeLabel;
        private TextBox LifespanText;
        private Label LifespanLabel;
        private TextBox SenseText;
        private Label SenseLabel;
        private TextBox PersonalityMatrix;
        private Label PersonalityLabel;
        private Label MonTagsLabel;
        private TextBox TagMatrix;
        private TextBox StressText;
        private Label StressLabel;
        private TextBox FatigueText;
        private Label FatigueLabel;
        private Label FearLabel;
        private TextBox FearText;
        private Label SpoilLabel;
        private TextBox SpoilText;
        private TextBox AgeText;
        private Label AgeLabel;
        private TextBox LifeStageText;
        private Label LifeStageLabel;
        private TextBox FormText;
        private Label FormLabel;
        private Label GrowthLabel;
        private TextBox ArenaSPDText;
        private Label MoveSpdLabel;
        private TextBox Trait1Text;
        private TextBox Trait2Text;
        private TextBox Trait3Text;
        private TextBox Trait4Text;
        private TextBox Trait5Text;
        private TextBox Trait6Text;
        private TextBox Trait7Text;
        private TextBox Trait8Text;
        private TextBox Trait9Text;
        private Label Trait1Label;
        private Label Trait2Label;
        private Label Trait3Label;
        private Label Trait4Label;
        private Label Trait5Label;
        private Label Trait6Label;
        private Label Trait7Label;
        private Label Trait8Label;
        private Label Trait9Label;
        private Label ProteinLabel;
        private TextBox ProteinText;
        private Label VitaminLabel;
        private TextBox VitaminText;
        private Label MineralLabel;
        private TextBox MineralText;
        private TextBox GRText;
        private Label GRLabel;
        private Button RenameAction;
        private Button CancelRename;
        private TextBox DamageModText;
        private Label DMLabel;
        private TextBox MoveNameBox;
        private Label MoveNameLabel;
        private TextBox LvlXPBox;
        private Label XPLvlLabel;
        private Label CostLabel;
        private TextBox CostBox;
        private Label HitLabel;
        private TextBox AccuracyBox;
        private Label CritLabel;
        private TextBox CritBox;
        private Label WitherLabel;
        private TextBox WitherBox;
        private Label ForceLabel;
        private TextBox ForceBox;
        private Label EffectLabel;
        private TextBox StatusBox;
        private Label ElementLabel;
        private TextBox ElementBox;
        private CheckBox OldHitPercent;
        private ComboBox MoveSlotID;
        private Label MoveSlotLabel;
    }
}
