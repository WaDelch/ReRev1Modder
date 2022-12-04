namespace Rev1Modder
{
    partial class frm_MainFrame
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbc_Main = new System.Windows.Forms.TabControl();
            this.tbp_Weapons = new System.Windows.Forms.TabPage();
            this.btn_ApplyWeapons = new System.Windows.Forms.Button();
            this.rdb_TagRate = new System.Windows.Forms.RadioButton();
            this.rdb_SlotRate = new System.Windows.Forms.RadioButton();
            this.rdb_WeaponLevel = new System.Windows.Forms.RadioButton();
            this.rdb_WeaponRate = new System.Windows.Forms.RadioButton();
            this.tbp_Player = new System.Windows.Forms.TabPage();
            this.btn_ApplyPlayers = new System.Windows.Forms.Button();
            this.tlp_Player = new System.Windows.Forms.TableLayoutPanel();
            this.txt_Recov = new System.Windows.Forms.TextBox();
            this.txt_Evade = new System.Windows.Forms.TextBox();
            this.txt_Invinc = new System.Windows.Forms.TextBox();
            this.txt_KnifeSpd = new System.Windows.Forms.TextBox();
            this.txt_Knife = new System.Windows.Forms.TextBox();
            this.txt_Melee = new System.Windows.Forms.TextBox();
            this.txt_GndRad = new System.Windows.Forms.TextBox();
            this.txt_MgmRel = new System.Windows.Forms.TextBox();
            this.txt_MgmFr = new System.Windows.Forms.TextBox();
            this.txt_RifleRel = new System.Windows.Forms.TextBox();
            this.txt_RifleFr = new System.Windows.Forms.TextBox();
            this.txt_MhgRel = new System.Windows.Forms.TextBox();
            this.txt_MhgFr = new System.Windows.Forms.TextBox();
            this.txt_ShgRel = new System.Windows.Forms.TextBox();
            this.txt_ShgFr = new System.Windows.Forms.TextBox();
            this.txt_HdgRel = new System.Windows.Forms.TextBox();
            this.txt_HP = new System.Windows.Forms.TextBox();
            this.lbl_HP = new System.Windows.Forms.Label();
            this.lbl_HandgunFr = new System.Windows.Forms.Label();
            this.lbl_HandgunRel = new System.Windows.Forms.Label();
            this.lbl_ShotgunFr = new System.Windows.Forms.Label();
            this.lbl_ShotgunRel = new System.Windows.Forms.Label();
            this.lbl_MachineGFr = new System.Windows.Forms.Label();
            this.lbl_MachineGRel = new System.Windows.Forms.Label();
            this.lbl_RifleFr = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_MagnumFr = new System.Windows.Forms.Label();
            this.lbl_MagnumRel = new System.Windows.Forms.Label();
            this.lbl_GrenadeRad = new System.Windows.Forms.Label();
            this.lbl_Melee = new System.Windows.Forms.Label();
            this.lbl_Knife = new System.Windows.Forms.Label();
            this.lbl_KnifeSpeed = new System.Windows.Forms.Label();
            this.lbl_Invincible = new System.Windows.Forms.Label();
            this.lbl_Evade = new System.Windows.Forms.Label();
            this.lbl_Recovery = new System.Windows.Forms.Label();
            this.txt_HdgFr = new System.Windows.Forms.TextBox();
            this.lbx_PlayerSelect = new System.Windows.Forms.ListBox();
            this.weaponSlotRate = new Rev1Modder.WeaponSlotRate();
            this.weaponTagRate = new Rev1Modder.WeaponTagRate();
            this.weaponLevelRate = new Rev1Modder.WeaponLevelRate();
            this.weaponRate = new Rev1Modder.WeaponRate();
            this.tbc_Main.SuspendLayout();
            this.tbp_Weapons.SuspendLayout();
            this.tbp_Player.SuspendLayout();
            this.tlp_Player.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbc_Main
            // 
            this.tbc_Main.Controls.Add(this.tbp_Weapons);
            this.tbc_Main.Controls.Add(this.tbp_Player);
            this.tbc_Main.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbc_Main.Location = new System.Drawing.Point(0, 0);
            this.tbc_Main.Name = "tbc_Main";
            this.tbc_Main.SelectedIndex = 0;
            this.tbc_Main.Size = new System.Drawing.Size(866, 448);
            this.tbc_Main.TabIndex = 0;
            // 
            // tbp_Weapons
            // 
            this.tbp_Weapons.BackColor = System.Drawing.SystemColors.Control;
            this.tbp_Weapons.Controls.Add(this.btn_ApplyWeapons);
            this.tbp_Weapons.Controls.Add(this.weaponSlotRate);
            this.tbp_Weapons.Controls.Add(this.weaponTagRate);
            this.tbp_Weapons.Controls.Add(this.weaponLevelRate);
            this.tbp_Weapons.Controls.Add(this.weaponRate);
            this.tbp_Weapons.Controls.Add(this.rdb_TagRate);
            this.tbp_Weapons.Controls.Add(this.rdb_SlotRate);
            this.tbp_Weapons.Controls.Add(this.rdb_WeaponLevel);
            this.tbp_Weapons.Controls.Add(this.rdb_WeaponRate);
            this.tbp_Weapons.Location = new System.Drawing.Point(4, 25);
            this.tbp_Weapons.Name = "tbp_Weapons";
            this.tbp_Weapons.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_Weapons.Size = new System.Drawing.Size(858, 419);
            this.tbp_Weapons.TabIndex = 0;
            this.tbp_Weapons.Text = "Weapons";
            // 
            // btn_ApplyWeapons
            // 
            this.btn_ApplyWeapons.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ApplyWeapons.Location = new System.Drawing.Point(743, 364);
            this.btn_ApplyWeapons.Name = "btn_ApplyWeapons";
            this.btn_ApplyWeapons.Size = new System.Drawing.Size(94, 37);
            this.btn_ApplyWeapons.TabIndex = 5;
            this.btn_ApplyWeapons.Text = "Apply";
            this.btn_ApplyWeapons.UseVisualStyleBackColor = true;
            this.btn_ApplyWeapons.Click += new System.EventHandler(this.btn_ApplyWeapons_Click);
            // 
            // rdb_TagRate
            // 
            this.rdb_TagRate.AutoSize = true;
            this.rdb_TagRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_TagRate.Location = new System.Drawing.Point(415, 15);
            this.rdb_TagRate.Name = "rdb_TagRate";
            this.rdb_TagRate.Size = new System.Drawing.Size(76, 20);
            this.rdb_TagRate.TabIndex = 0;
            this.rdb_TagRate.TabStop = true;
            this.rdb_TagRate.Text = "Tag rate";
            this.rdb_TagRate.UseVisualStyleBackColor = true;
            this.rdb_TagRate.CheckedChanged += new System.EventHandler(this.rdb_TagRate_CheckedChanged);
            // 
            // rdb_SlotRate
            // 
            this.rdb_SlotRate.AutoSize = true;
            this.rdb_SlotRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_SlotRate.Location = new System.Drawing.Point(615, 15);
            this.rdb_SlotRate.Name = "rdb_SlotRate";
            this.rdb_SlotRate.Size = new System.Drawing.Size(74, 20);
            this.rdb_SlotRate.TabIndex = 0;
            this.rdb_SlotRate.TabStop = true;
            this.rdb_SlotRate.Text = "Slot rate";
            this.rdb_SlotRate.UseVisualStyleBackColor = true;
            this.rdb_SlotRate.CheckedChanged += new System.EventHandler(this.rdb_SlotRate_CheckedChanged);
            // 
            // rdb_WeaponLevel
            // 
            this.rdb_WeaponLevel.AutoSize = true;
            this.rdb_WeaponLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_WeaponLevel.Location = new System.Drawing.Point(215, 15);
            this.rdb_WeaponLevel.Name = "rdb_WeaponLevel";
            this.rdb_WeaponLevel.Size = new System.Drawing.Size(135, 20);
            this.rdb_WeaponLevel.TabIndex = 0;
            this.rdb_WeaponLevel.TabStop = true;
            this.rdb_WeaponLevel.Text = "Weapon level rate";
            this.rdb_WeaponLevel.UseVisualStyleBackColor = true;
            this.rdb_WeaponLevel.CheckedChanged += new System.EventHandler(this.rdb_WeaponLevel_CheckedChanged);
            // 
            // rdb_WeaponRate
            // 
            this.rdb_WeaponRate.AutoSize = true;
            this.rdb_WeaponRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_WeaponRate.Location = new System.Drawing.Point(15, 15);
            this.rdb_WeaponRate.Name = "rdb_WeaponRate";
            this.rdb_WeaponRate.Size = new System.Drawing.Size(134, 20);
            this.rdb_WeaponRate.TabIndex = 0;
            this.rdb_WeaponRate.TabStop = true;
            this.rdb_WeaponRate.Text = "Weapon drop rate";
            this.rdb_WeaponRate.UseVisualStyleBackColor = true;
            this.rdb_WeaponRate.CheckedChanged += new System.EventHandler(this.rdb_WeaponRate_CheckedChanged);
            // 
            // tbp_Player
            // 
            this.tbp_Player.BackColor = System.Drawing.SystemColors.Control;
            this.tbp_Player.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tbp_Player.Controls.Add(this.btn_ApplyPlayers);
            this.tbp_Player.Controls.Add(this.tlp_Player);
            this.tbp_Player.Controls.Add(this.lbx_PlayerSelect);
            this.tbp_Player.Location = new System.Drawing.Point(4, 25);
            this.tbp_Player.Name = "tbp_Player";
            this.tbp_Player.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_Player.Size = new System.Drawing.Size(858, 419);
            this.tbp_Player.TabIndex = 1;
            this.tbp_Player.Text = "Player";
            this.tbp_Player.Enter += new System.EventHandler(this.lbx_PlayerSelect_SelectedIndexChanged);
            // 
            // btn_ApplyPlayers
            // 
            this.btn_ApplyPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ApplyPlayers.Location = new System.Drawing.Point(752, 192);
            this.btn_ApplyPlayers.Name = "btn_ApplyPlayers";
            this.btn_ApplyPlayers.Size = new System.Drawing.Size(94, 37);
            this.btn_ApplyPlayers.TabIndex = 4;
            this.btn_ApplyPlayers.Text = "Apply";
            this.btn_ApplyPlayers.UseVisualStyleBackColor = true;
            this.btn_ApplyPlayers.Click += new System.EventHandler(this.btn_ApplyPlayers_Click);
            // 
            // tlp_Player
            // 
            this.tlp_Player.ColumnCount = 7;
            this.tlp_Player.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlp_Player.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlp_Player.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlp_Player.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlp_Player.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlp_Player.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlp_Player.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlp_Player.Controls.Add(this.txt_Recov, 3, 5);
            this.tlp_Player.Controls.Add(this.txt_Evade, 2, 5);
            this.tlp_Player.Controls.Add(this.txt_Invinc, 1, 5);
            this.tlp_Player.Controls.Add(this.txt_KnifeSpd, 0, 5);
            this.tlp_Player.Controls.Add(this.txt_Knife, 6, 3);
            this.tlp_Player.Controls.Add(this.txt_Melee, 5, 3);
            this.tlp_Player.Controls.Add(this.txt_GndRad, 4, 3);
            this.tlp_Player.Controls.Add(this.txt_MgmRel, 3, 3);
            this.tlp_Player.Controls.Add(this.txt_MgmFr, 2, 3);
            this.tlp_Player.Controls.Add(this.txt_RifleRel, 1, 3);
            this.tlp_Player.Controls.Add(this.txt_RifleFr, 0, 3);
            this.tlp_Player.Controls.Add(this.txt_MhgRel, 6, 1);
            this.tlp_Player.Controls.Add(this.txt_MhgFr, 5, 1);
            this.tlp_Player.Controls.Add(this.txt_ShgRel, 4, 1);
            this.tlp_Player.Controls.Add(this.txt_ShgFr, 3, 1);
            this.tlp_Player.Controls.Add(this.txt_HdgRel, 2, 1);
            this.tlp_Player.Controls.Add(this.txt_HP, 0, 1);
            this.tlp_Player.Controls.Add(this.lbl_HP, 0, 0);
            this.tlp_Player.Controls.Add(this.lbl_HandgunFr, 1, 0);
            this.tlp_Player.Controls.Add(this.lbl_HandgunRel, 2, 0);
            this.tlp_Player.Controls.Add(this.lbl_ShotgunFr, 3, 0);
            this.tlp_Player.Controls.Add(this.lbl_ShotgunRel, 4, 0);
            this.tlp_Player.Controls.Add(this.lbl_MachineGFr, 5, 0);
            this.tlp_Player.Controls.Add(this.lbl_MachineGRel, 6, 0);
            this.tlp_Player.Controls.Add(this.lbl_RifleFr, 0, 2);
            this.tlp_Player.Controls.Add(this.label2, 1, 2);
            this.tlp_Player.Controls.Add(this.lbl_MagnumFr, 2, 2);
            this.tlp_Player.Controls.Add(this.lbl_MagnumRel, 3, 2);
            this.tlp_Player.Controls.Add(this.lbl_GrenadeRad, 4, 2);
            this.tlp_Player.Controls.Add(this.lbl_Melee, 5, 2);
            this.tlp_Player.Controls.Add(this.lbl_Knife, 6, 2);
            this.tlp_Player.Controls.Add(this.lbl_KnifeSpeed, 0, 4);
            this.tlp_Player.Controls.Add(this.lbl_Invincible, 1, 4);
            this.tlp_Player.Controls.Add(this.lbl_Evade, 2, 4);
            this.tlp_Player.Controls.Add(this.lbl_Recovery, 3, 4);
            this.tlp_Player.Controls.Add(this.txt_HdgFr, 1, 1);
            this.tlp_Player.Location = new System.Drawing.Point(146, 6);
            this.tlp_Player.Name = "tlp_Player";
            this.tlp_Player.RowCount = 6;
            this.tlp_Player.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlp_Player.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlp_Player.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlp_Player.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlp_Player.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlp_Player.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlp_Player.Size = new System.Drawing.Size(700, 180);
            this.tlp_Player.TabIndex = 3;
            // 
            // txt_Recov
            // 
            this.txt_Recov.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_Recov.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Recov.Location = new System.Drawing.Point(303, 155);
            this.txt_Recov.MaxLength = 5;
            this.txt_Recov.Name = "txt_Recov";
            this.txt_Recov.Size = new System.Drawing.Size(42, 22);
            this.txt_Recov.TabIndex = 23;
            this.txt_Recov.Text = "00.00";
            this.txt_Recov.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_Evade
            // 
            this.txt_Evade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_Evade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Evade.Location = new System.Drawing.Point(203, 155);
            this.txt_Evade.MaxLength = 5;
            this.txt_Evade.Name = "txt_Evade";
            this.txt_Evade.Size = new System.Drawing.Size(42, 22);
            this.txt_Evade.TabIndex = 22;
            this.txt_Evade.Text = "00.00";
            this.txt_Evade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_Invinc
            // 
            this.txt_Invinc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_Invinc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Invinc.Location = new System.Drawing.Point(103, 155);
            this.txt_Invinc.MaxLength = 5;
            this.txt_Invinc.Name = "txt_Invinc";
            this.txt_Invinc.Size = new System.Drawing.Size(42, 22);
            this.txt_Invinc.TabIndex = 21;
            this.txt_Invinc.Text = "00.00";
            this.txt_Invinc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_KnifeSpd
            // 
            this.txt_KnifeSpd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_KnifeSpd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_KnifeSpd.Location = new System.Drawing.Point(3, 155);
            this.txt_KnifeSpd.MaxLength = 5;
            this.txt_KnifeSpd.Name = "txt_KnifeSpd";
            this.txt_KnifeSpd.Size = new System.Drawing.Size(42, 22);
            this.txt_KnifeSpd.TabIndex = 20;
            this.txt_KnifeSpd.Text = "00.00";
            this.txt_KnifeSpd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_Knife
            // 
            this.txt_Knife.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_Knife.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Knife.Location = new System.Drawing.Point(603, 95);
            this.txt_Knife.MaxLength = 5;
            this.txt_Knife.Name = "txt_Knife";
            this.txt_Knife.Size = new System.Drawing.Size(42, 22);
            this.txt_Knife.TabIndex = 16;
            this.txt_Knife.Text = "00.00";
            this.txt_Knife.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_Melee
            // 
            this.txt_Melee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_Melee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Melee.Location = new System.Drawing.Point(503, 95);
            this.txt_Melee.MaxLength = 5;
            this.txt_Melee.Name = "txt_Melee";
            this.txt_Melee.Size = new System.Drawing.Size(42, 22);
            this.txt_Melee.TabIndex = 15;
            this.txt_Melee.Text = "00.00";
            this.txt_Melee.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_GndRad
            // 
            this.txt_GndRad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_GndRad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_GndRad.Location = new System.Drawing.Point(403, 95);
            this.txt_GndRad.MaxLength = 5;
            this.txt_GndRad.Name = "txt_GndRad";
            this.txt_GndRad.Size = new System.Drawing.Size(42, 22);
            this.txt_GndRad.TabIndex = 14;
            this.txt_GndRad.Text = "00.00";
            this.txt_GndRad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_MgmRel
            // 
            this.txt_MgmRel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_MgmRel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MgmRel.Location = new System.Drawing.Point(303, 95);
            this.txt_MgmRel.MaxLength = 5;
            this.txt_MgmRel.Name = "txt_MgmRel";
            this.txt_MgmRel.Size = new System.Drawing.Size(42, 22);
            this.txt_MgmRel.TabIndex = 13;
            this.txt_MgmRel.Text = "00.00";
            this.txt_MgmRel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_MgmFr
            // 
            this.txt_MgmFr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_MgmFr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MgmFr.Location = new System.Drawing.Point(203, 95);
            this.txt_MgmFr.MaxLength = 5;
            this.txt_MgmFr.Name = "txt_MgmFr";
            this.txt_MgmFr.Size = new System.Drawing.Size(42, 22);
            this.txt_MgmFr.TabIndex = 12;
            this.txt_MgmFr.Text = "00.00";
            this.txt_MgmFr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_RifleRel
            // 
            this.txt_RifleRel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_RifleRel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_RifleRel.Location = new System.Drawing.Point(103, 95);
            this.txt_RifleRel.MaxLength = 5;
            this.txt_RifleRel.Name = "txt_RifleRel";
            this.txt_RifleRel.Size = new System.Drawing.Size(42, 22);
            this.txt_RifleRel.TabIndex = 11;
            this.txt_RifleRel.Text = "00.00";
            this.txt_RifleRel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_RifleFr
            // 
            this.txt_RifleFr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_RifleFr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_RifleFr.Location = new System.Drawing.Point(3, 95);
            this.txt_RifleFr.MaxLength = 5;
            this.txt_RifleFr.Name = "txt_RifleFr";
            this.txt_RifleFr.Size = new System.Drawing.Size(42, 22);
            this.txt_RifleFr.TabIndex = 10;
            this.txt_RifleFr.Text = "00.00";
            this.txt_RifleFr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_MhgRel
            // 
            this.txt_MhgRel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_MhgRel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MhgRel.Location = new System.Drawing.Point(603, 35);
            this.txt_MhgRel.MaxLength = 5;
            this.txt_MhgRel.Name = "txt_MhgRel";
            this.txt_MhgRel.Size = new System.Drawing.Size(42, 22);
            this.txt_MhgRel.TabIndex = 9;
            this.txt_MhgRel.Text = "00.00";
            this.txt_MhgRel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_MhgFr
            // 
            this.txt_MhgFr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_MhgFr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MhgFr.Location = new System.Drawing.Point(503, 35);
            this.txt_MhgFr.MaxLength = 5;
            this.txt_MhgFr.Name = "txt_MhgFr";
            this.txt_MhgFr.Size = new System.Drawing.Size(42, 22);
            this.txt_MhgFr.TabIndex = 8;
            this.txt_MhgFr.Text = "00.00";
            this.txt_MhgFr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_ShgRel
            // 
            this.txt_ShgRel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_ShgRel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ShgRel.Location = new System.Drawing.Point(403, 35);
            this.txt_ShgRel.MaxLength = 5;
            this.txt_ShgRel.Name = "txt_ShgRel";
            this.txt_ShgRel.Size = new System.Drawing.Size(42, 22);
            this.txt_ShgRel.TabIndex = 7;
            this.txt_ShgRel.Text = "00.00";
            this.txt_ShgRel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_ShgFr
            // 
            this.txt_ShgFr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_ShgFr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ShgFr.Location = new System.Drawing.Point(303, 35);
            this.txt_ShgFr.MaxLength = 5;
            this.txt_ShgFr.Name = "txt_ShgFr";
            this.txt_ShgFr.Size = new System.Drawing.Size(42, 22);
            this.txt_ShgFr.TabIndex = 6;
            this.txt_ShgFr.Text = "00.00";
            this.txt_ShgFr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_HdgRel
            // 
            this.txt_HdgRel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_HdgRel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_HdgRel.Location = new System.Drawing.Point(203, 35);
            this.txt_HdgRel.MaxLength = 5;
            this.txt_HdgRel.Name = "txt_HdgRel";
            this.txt_HdgRel.Size = new System.Drawing.Size(42, 22);
            this.txt_HdgRel.TabIndex = 5;
            this.txt_HdgRel.Text = "00.00";
            this.txt_HdgRel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_HP
            // 
            this.txt_HP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_HP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_HP.Location = new System.Drawing.Point(3, 35);
            this.txt_HP.MaxLength = 5;
            this.txt_HP.Name = "txt_HP";
            this.txt_HP.Size = new System.Drawing.Size(42, 22);
            this.txt_HP.TabIndex = 4;
            this.txt_HP.Text = "00.00";
            this.txt_HP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_HP
            // 
            this.lbl_HP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_HP.AutoSize = true;
            this.lbl_HP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HP.Location = new System.Drawing.Point(3, 14);
            this.lbl_HP.Name = "lbl_HP";
            this.lbl_HP.Size = new System.Drawing.Size(26, 16);
            this.lbl_HP.TabIndex = 2;
            this.lbl_HP.Text = "HP";
            // 
            // lbl_HandgunFr
            // 
            this.lbl_HandgunFr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_HandgunFr.AutoSize = true;
            this.lbl_HandgunFr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HandgunFr.Location = new System.Drawing.Point(103, 14);
            this.lbl_HandgunFr.Name = "lbl_HandgunFr";
            this.lbl_HandgunFr.Size = new System.Drawing.Size(77, 16);
            this.lbl_HandgunFr.TabIndex = 2;
            this.lbl_HandgunFr.Text = "Handgun Fr";
            // 
            // lbl_HandgunRel
            // 
            this.lbl_HandgunRel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_HandgunRel.AutoSize = true;
            this.lbl_HandgunRel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HandgunRel.Location = new System.Drawing.Point(203, 14);
            this.lbl_HandgunRel.Name = "lbl_HandgunRel";
            this.lbl_HandgunRel.Size = new System.Drawing.Size(86, 16);
            this.lbl_HandgunRel.TabIndex = 2;
            this.lbl_HandgunRel.Text = "Handgun Rel";
            // 
            // lbl_ShotgunFr
            // 
            this.lbl_ShotgunFr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_ShotgunFr.AutoSize = true;
            this.lbl_ShotgunFr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ShotgunFr.Location = new System.Drawing.Point(303, 14);
            this.lbl_ShotgunFr.Name = "lbl_ShotgunFr";
            this.lbl_ShotgunFr.Size = new System.Drawing.Size(71, 16);
            this.lbl_ShotgunFr.TabIndex = 2;
            this.lbl_ShotgunFr.Text = "Shotgun Fr";
            // 
            // lbl_ShotgunRel
            // 
            this.lbl_ShotgunRel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_ShotgunRel.AutoSize = true;
            this.lbl_ShotgunRel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ShotgunRel.Location = new System.Drawing.Point(403, 14);
            this.lbl_ShotgunRel.Name = "lbl_ShotgunRel";
            this.lbl_ShotgunRel.Size = new System.Drawing.Size(80, 16);
            this.lbl_ShotgunRel.TabIndex = 2;
            this.lbl_ShotgunRel.Text = "Shotgun Rel";
            // 
            // lbl_MachineGFr
            // 
            this.lbl_MachineGFr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_MachineGFr.AutoSize = true;
            this.lbl_MachineGFr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MachineGFr.Location = new System.Drawing.Point(503, 14);
            this.lbl_MachineGFr.Name = "lbl_MachineGFr";
            this.lbl_MachineGFr.Size = new System.Drawing.Size(83, 16);
            this.lbl_MachineGFr.TabIndex = 2;
            this.lbl_MachineGFr.Text = "MachineG Fr";
            // 
            // lbl_MachineGRel
            // 
            this.lbl_MachineGRel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_MachineGRel.AutoSize = true;
            this.lbl_MachineGRel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MachineGRel.Location = new System.Drawing.Point(603, 14);
            this.lbl_MachineGRel.Name = "lbl_MachineGRel";
            this.lbl_MachineGRel.Size = new System.Drawing.Size(92, 16);
            this.lbl_MachineGRel.TabIndex = 2;
            this.lbl_MachineGRel.Text = "MachineG Rel";
            // 
            // lbl_RifleFr
            // 
            this.lbl_RifleFr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_RifleFr.AutoSize = true;
            this.lbl_RifleFr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RifleFr.Location = new System.Drawing.Point(3, 74);
            this.lbl_RifleFr.Name = "lbl_RifleFr";
            this.lbl_RifleFr.Size = new System.Drawing.Size(49, 16);
            this.lbl_RifleFr.TabIndex = 2;
            this.lbl_RifleFr.Text = "Rifle Fr";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(103, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Rifle Rel";
            // 
            // lbl_MagnumFr
            // 
            this.lbl_MagnumFr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_MagnumFr.AutoSize = true;
            this.lbl_MagnumFr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MagnumFr.Location = new System.Drawing.Point(203, 74);
            this.lbl_MagnumFr.Name = "lbl_MagnumFr";
            this.lbl_MagnumFr.Size = new System.Drawing.Size(74, 16);
            this.lbl_MagnumFr.TabIndex = 2;
            this.lbl_MagnumFr.Text = "Magnum Fr";
            // 
            // lbl_MagnumRel
            // 
            this.lbl_MagnumRel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_MagnumRel.AutoSize = true;
            this.lbl_MagnumRel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MagnumRel.Location = new System.Drawing.Point(303, 74);
            this.lbl_MagnumRel.Name = "lbl_MagnumRel";
            this.lbl_MagnumRel.Size = new System.Drawing.Size(83, 16);
            this.lbl_MagnumRel.TabIndex = 2;
            this.lbl_MagnumRel.Text = "Magnum Rel";
            // 
            // lbl_GrenadeRad
            // 
            this.lbl_GrenadeRad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_GrenadeRad.AutoSize = true;
            this.lbl_GrenadeRad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GrenadeRad.Location = new System.Drawing.Point(403, 74);
            this.lbl_GrenadeRad.Name = "lbl_GrenadeRad";
            this.lbl_GrenadeRad.Size = new System.Drawing.Size(89, 16);
            this.lbl_GrenadeRad.TabIndex = 2;
            this.lbl_GrenadeRad.Text = "Grenade Rad";
            // 
            // lbl_Melee
            // 
            this.lbl_Melee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_Melee.AutoSize = true;
            this.lbl_Melee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Melee.Location = new System.Drawing.Point(503, 74);
            this.lbl_Melee.Name = "lbl_Melee";
            this.lbl_Melee.Size = new System.Drawing.Size(45, 16);
            this.lbl_Melee.TabIndex = 2;
            this.lbl_Melee.Text = "Melee";
            // 
            // lbl_Knife
            // 
            this.lbl_Knife.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_Knife.AutoSize = true;
            this.lbl_Knife.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Knife.Location = new System.Drawing.Point(603, 74);
            this.lbl_Knife.Name = "lbl_Knife";
            this.lbl_Knife.Size = new System.Drawing.Size(36, 16);
            this.lbl_Knife.TabIndex = 2;
            this.lbl_Knife.Text = "Knife";
            // 
            // lbl_KnifeSpeed
            // 
            this.lbl_KnifeSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_KnifeSpeed.AutoSize = true;
            this.lbl_KnifeSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_KnifeSpeed.Location = new System.Drawing.Point(3, 134);
            this.lbl_KnifeSpeed.Name = "lbl_KnifeSpeed";
            this.lbl_KnifeSpeed.Size = new System.Drawing.Size(80, 16);
            this.lbl_KnifeSpeed.TabIndex = 2;
            this.lbl_KnifeSpeed.Text = "Knife Speed";
            // 
            // lbl_Invincible
            // 
            this.lbl_Invincible.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_Invincible.AutoSize = true;
            this.lbl_Invincible.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Invincible.Location = new System.Drawing.Point(103, 134);
            this.lbl_Invincible.Name = "lbl_Invincible";
            this.lbl_Invincible.Size = new System.Drawing.Size(63, 16);
            this.lbl_Invincible.TabIndex = 2;
            this.lbl_Invincible.Text = "Invincible";
            // 
            // lbl_Evade
            // 
            this.lbl_Evade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_Evade.AutoSize = true;
            this.lbl_Evade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Evade.Location = new System.Drawing.Point(203, 134);
            this.lbl_Evade.Name = "lbl_Evade";
            this.lbl_Evade.Size = new System.Drawing.Size(47, 16);
            this.lbl_Evade.TabIndex = 2;
            this.lbl_Evade.Text = "Evade";
            // 
            // lbl_Recovery
            // 
            this.lbl_Recovery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_Recovery.AutoSize = true;
            this.lbl_Recovery.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Recovery.Location = new System.Drawing.Point(303, 134);
            this.lbl_Recovery.Name = "lbl_Recovery";
            this.lbl_Recovery.Size = new System.Drawing.Size(66, 16);
            this.lbl_Recovery.TabIndex = 2;
            this.lbl_Recovery.Text = "Recovery";
            // 
            // txt_HdgFr
            // 
            this.txt_HdgFr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_HdgFr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_HdgFr.Location = new System.Drawing.Point(103, 35);
            this.txt_HdgFr.MaxLength = 5;
            this.txt_HdgFr.Name = "txt_HdgFr";
            this.txt_HdgFr.Size = new System.Drawing.Size(42, 22);
            this.txt_HdgFr.TabIndex = 3;
            this.txt_HdgFr.Text = "00.00";
            this.txt_HdgFr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbx_PlayerSelect
            // 
            this.lbx_PlayerSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbx_PlayerSelect.FormattingEnabled = true;
            this.lbx_PlayerSelect.ItemHeight = 16;
            this.lbx_PlayerSelect.Items.AddRange(new object[] {
            "Jill Wetsuit",
            "Jill Beach",
            "Jill Pirate",
            "Chris Snow",
            "Chris BSAA",
            "Chris Sailor",
            "Parker Wetsuit",
            "Parker Beach",
            "Parker FBC",
            "Keith Snow",
            "Keith BSAA",
            "Keith Ninja",
            "Jessica Snow",
            "Jessica Wetsuit",
            "Jessica FBC",
            "Quint Snow",
            "Quint BSAA",
            "Raymond",
            "O\'Brian",
            "Lansdale",
            "Norman",
            "Rachael",
            "Rachael Ooze",
            "Hunk",
            "Lady Hunk"});
            this.lbx_PlayerSelect.Location = new System.Drawing.Point(6, 6);
            this.lbx_PlayerSelect.Name = "lbx_PlayerSelect";
            this.lbx_PlayerSelect.Size = new System.Drawing.Size(114, 404);
            this.lbx_PlayerSelect.TabIndex = 1;
            this.lbx_PlayerSelect.SelectedIndexChanged += new System.EventHandler(this.lbx_PlayerSelect_SelectedIndexChanged);
            // 
            // weaponSlotRate
            // 
            this.weaponSlotRate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.weaponSlotRate.Location = new System.Drawing.Point(8, 55);
            this.weaponSlotRate.Name = "weaponSlotRate";
            this.weaponSlotRate.Size = new System.Drawing.Size(840, 360);
            this.weaponSlotRate.TabIndex = 4;
            this.weaponSlotRate.Visible = false;
            // 
            // weaponTagRate
            // 
            this.weaponTagRate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.weaponTagRate.Location = new System.Drawing.Point(8, 55);
            this.weaponTagRate.Name = "weaponTagRate";
            this.weaponTagRate.Size = new System.Drawing.Size(840, 360);
            this.weaponTagRate.TabIndex = 3;
            this.weaponTagRate.Visible = false;
            // 
            // weaponLevelRate
            // 
            this.weaponLevelRate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.weaponLevelRate.Location = new System.Drawing.Point(8, 55);
            this.weaponLevelRate.Name = "weaponLevelRate";
            this.weaponLevelRate.Size = new System.Drawing.Size(840, 360);
            this.weaponLevelRate.TabIndex = 2;
            this.weaponLevelRate.Visible = false;
            // 
            // weaponRate
            // 
            this.weaponRate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.weaponRate.Location = new System.Drawing.Point(8, 55);
            this.weaponRate.Name = "weaponRate";
            this.weaponRate.Size = new System.Drawing.Size(840, 360);
            this.weaponRate.TabIndex = 1;
            // 
            // frm_MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 460);
            this.Controls.Add(this.tbc_Main);
            this.Name = "frm_MainFrame";
            this.Text = "Resident Evil Revelations 1 Modder";
            this.Load += new System.EventHandler(this.frm_MainFrame_Load);
            this.tbc_Main.ResumeLayout(false);
            this.tbp_Weapons.ResumeLayout(false);
            this.tbp_Weapons.PerformLayout();
            this.tbp_Player.ResumeLayout(false);
            this.tlp_Player.ResumeLayout(false);
            this.tlp_Player.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbc_Main;
        private System.Windows.Forms.TabPage tbp_Weapons;
        private System.Windows.Forms.TabPage tbp_Player;
        private System.Windows.Forms.RadioButton rdb_WeaponRate;
        private System.Windows.Forms.RadioButton rdb_TagRate;
        private System.Windows.Forms.RadioButton rdb_SlotRate;
        private System.Windows.Forms.RadioButton rdb_WeaponLevel;
        private System.Windows.Forms.ListBox lbx_PlayerSelect;
        private System.Windows.Forms.TableLayoutPanel tlp_Player;
        private System.Windows.Forms.TextBox txt_Recov;
        private System.Windows.Forms.TextBox txt_Evade;
        private System.Windows.Forms.TextBox txt_Invinc;
        private System.Windows.Forms.TextBox txt_KnifeSpd;
        private System.Windows.Forms.TextBox txt_Knife;
        private System.Windows.Forms.TextBox txt_Melee;
        private System.Windows.Forms.TextBox txt_GndRad;
        private System.Windows.Forms.TextBox txt_MgmRel;
        private System.Windows.Forms.TextBox txt_MgmFr;
        private System.Windows.Forms.TextBox txt_RifleRel;
        private System.Windows.Forms.TextBox txt_RifleFr;
        private System.Windows.Forms.TextBox txt_MhgRel;
        private System.Windows.Forms.TextBox txt_MhgFr;
        private System.Windows.Forms.TextBox txt_ShgRel;
        private System.Windows.Forms.TextBox txt_ShgFr;
        private System.Windows.Forms.TextBox txt_HdgRel;
        private System.Windows.Forms.TextBox txt_HP;
        private System.Windows.Forms.Label lbl_HP;
        private System.Windows.Forms.Label lbl_HandgunFr;
        private System.Windows.Forms.Label lbl_HandgunRel;
        private System.Windows.Forms.Label lbl_ShotgunFr;
        private System.Windows.Forms.Label lbl_ShotgunRel;
        private System.Windows.Forms.Label lbl_MachineGFr;
        private System.Windows.Forms.Label lbl_MachineGRel;
        private System.Windows.Forms.Label lbl_RifleFr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_MagnumFr;
        private System.Windows.Forms.Label lbl_MagnumRel;
        private System.Windows.Forms.Label lbl_GrenadeRad;
        private System.Windows.Forms.Label lbl_Melee;
        private System.Windows.Forms.Label lbl_Knife;
        private System.Windows.Forms.Label lbl_KnifeSpeed;
        private System.Windows.Forms.Label lbl_Invincible;
        private System.Windows.Forms.Label lbl_Evade;
        private System.Windows.Forms.Label lbl_Recovery;
        private System.Windows.Forms.TextBox txt_HdgFr;
        private System.Windows.Forms.Button btn_ApplyPlayers;
        private WeaponRate weaponRate;
        private WeaponSlotRate weaponSlotRate;
        private WeaponTagRate weaponTagRate;
        private WeaponLevelRate weaponLevelRate;
        private System.Windows.Forms.Button btn_ApplyWeapons;
    }
}

