using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Rev1Modder
{
    public partial class frm_MainFrame : Form
    {
        public string Path, wRatePath, wLevelPath, wTagPath, wSlotPath, pTalentPath, storePricesPath;
        public enum FType { weaponRate, weaponLevelRate, weaponTagRate, weaponSlotRate, playerTalent, storePrices }

        readonly string[] storeUpgrades = { "fire rate: pistol", "fire rate: shotgun", "fire rate: machine gun", "fire rate: rifle", "fire rate: magnum",
                                    "capacity: pistol", "capacity: shotgun", "capacity: machine gun", "capacity: rifle", "capacity: magnum",
                                    "firepower: pistol", "firepower: shotgun", "firepower: machine gun", "firepower: rifle", "firepower: magnum" };

        readonly string[] storeTags = { "short range", "long range", "easy grip", "speed shot", "steady hand", "speed load", "sonic assist",
                                "light weight", "sonic assist+", "short range+", "long range+" };

        public frm_MainFrame(string p)
        {
            InitializeComponent();
            this.Path = p;
            this.wRatePath = this.Path + "\\weaponRate.0A3E643B";
            this.wLevelPath = this.Path + "\\weaponRarityRate.0A3E643B";
            this.wTagPath = this.Path + "\\weaponTagRate.0A3E643B";
            this.wSlotPath = this.Path + "\\weaponSlotRate.0A3E643B";
            this.pTalentPath = this.Path + "\\playerTalent.0A3E643B";
            this.storePricesPath = this.Path + "\\ItemValue.0A3E643B";
            PopulateFields();
        }

        IEnumerable<TextBox> GetTextFields(FType fType)
        {
            IEnumerable<TextBox> tempTexts = Enumerable.Empty<TextBox>();
            switch (fType)
            {
                case FType.weaponRate:
                    tempTexts = this.weaponRate.tlp_WeaponRate.GetChildControls<TextBox>();
                    break;
                case FType.weaponLevelRate:
                    tempTexts = this.weaponLevelRate.tlp_WeaponLevelRate.GetChildControls<TextBox>();
                    break;
                case FType.weaponTagRate:
                    tempTexts = this.weaponTagRate.tlp_WeaponTagRate.GetChildControls<TextBox>();
                    break;
                case FType.weaponSlotRate:
                    tempTexts = this.weaponSlotRate.tlp_WeaponSlotRate.GetChildControls<TextBox>();
                    break;
                case FType.playerTalent:
                    tempTexts = this.tlp_Player.GetChildControls<TextBox>();
                    break;
            }
            return tempTexts;
        }

        void PopulateFields()
        {
            try
            {
                Program.readBytes(GetTextFields(FType.weaponRate).ToArray(), wRatePath, 32, 11, 1, true);
                Program.readBytes(GetTextFields(FType.weaponLevelRate).ToArray(), wLevelPath, 30, 6, 100, true);
                Program.readBytes(GetTextFields(FType.weaponTagRate).ToArray(), wTagPath, 30, 6, 1, true);
                for (int i = 0; i < 6; i++)
                    Program.readBytes(GetTextFields(FType.weaponSlotRate).Skip(5 * i).Take(5).ToArray(), wSlotPath, 38 + (30 * i), 1, 100, true);
                //Program.readBytes(GetTextFields("weaponSlotRate").ToArray(), wSlotPath, 188, 1, 100); //reads only set 6
            }
            catch
            {
                this.Close();
            }
        }

        private void frm_MainFrame_Load(object sender, EventArgs e)
        {
            lbx_PlayerSelect.SelectedIndex = 0;
            rdb_WeaponRate.Select();
            rdb_StoreUpgrades.Select();
            lbx_StoreItemSelect.SelectedIndex = 0;
        }

        private void rdb_WeaponRate_CheckedChanged(object sender, EventArgs e)
        {
            weaponRate.Visible = true;
            weaponLevelRate.Visible = false;
            weaponTagRate.Visible = false;
            weaponSlotRate.Visible = false;
        }

        private void rdb_WeaponLevel_CheckedChanged(object sender, EventArgs e)
        {
            weaponRate.Visible = false;
            weaponLevelRate.Visible = true;
            weaponTagRate.Visible = false;
            weaponSlotRate.Visible = false;
        }

        private void rdb_TagRate_CheckedChanged(object sender, EventArgs e)
        {
            weaponRate.Visible = false;
            weaponLevelRate.Visible = false;
            weaponTagRate.Visible = true;
            weaponSlotRate.Visible = false;
        }

        private void rdb_SlotRate_CheckedChanged(object sender, EventArgs e)
        {
            weaponRate.Visible = false;
            weaponLevelRate.Visible = false;
            weaponTagRate.Visible = false;
            weaponSlotRate.Visible = true;
        }

        private void btn_ApplyWeapons_Click(object sender, EventArgs e)
        {
            TextBox[] weaponRateBoxes = GetTextFields(FType.weaponRate).ToArray();
            TextBox[] weaponLevelRateBoxes = GetTextFields(FType.weaponLevelRate).ToArray();
            TextBox[] weaponTagRateBoxes = GetTextFields(FType.weaponTagRate).ToArray();
            TextBox[] weaponSlotRateBoxes = GetTextFields(FType.weaponSlotRate).ToArray();
            TextBox[] splitBoxes;

            if (rdb_WeaponRate.Checked)
            {
                if (Program.InputCheck(weaponRateBoxes))
                {
                    Program.writeBytes(weaponRateBoxes, wRatePath, 32, 11, 1, true);
                    MessageBox.Show("Writing complete.");
                }
            }

            else if (rdb_WeaponLevelRate.Checked)
            {
                if (Program.InputCheck(weaponLevelRateBoxes))
                {
                    Program.writeBytes(weaponLevelRateBoxes, wLevelPath, 30, 6, 100, true);
                    MessageBox.Show("Writing complete.");
                }
            }

            else if (rdb_WeaponTagRate.Checked)
            {
                if (Program.InputCheck(weaponTagRateBoxes))
                {
                    Program.writeBytes(weaponTagRateBoxes, wTagPath, 30, 6, 1, true);
                    MessageBox.Show("Writing complete.");
                }
            }

            else if (rdb_WeaponSlotRate.Checked)
            {

                for (int i = 0; i < 6; i++)
                {
                    splitBoxes = weaponSlotRateBoxes.Skip(5 * i).Take(5).ToArray();
                    if (Program.InputCheck(splitBoxes))
                        Program.writeBytes(splitBoxes, wSlotPath, 38 + (30 * i), 1, 100, true);
                    else
                        MessageBox.Show("Error in Set " + (i + 1));
                }
                MessageBox.Show("Writing complete.");
            }
        }

        //############################# Player Data ###################################

        private void lbx_PlayerSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbx_PlayerSelect.SelectedIndex < 0)
            {
                MessageBox.Show("Select a Player!");
                return;
            }
            Program.readBytes(GetTextFields(FType.playerTalent).ToArray(), pTalentPath, 64 + (95 * lbx_PlayerSelect.SelectedIndex), 1, 100, true);
        }

        private void btn_ApplyPlayers_Click(object sender, EventArgs e)
        {
            TextBox[] playerTalentBoxes = GetTextFields(FType.playerTalent).ToArray();
            float tempFloat;
            foreach (TextBox tb in playerTalentBoxes)
            {
                if (!Single.TryParse(tb.Text, out tempFloat) || tb.Text.Contains('-'))
                {
                    MessageBox.Show("Input error!");
                    return;
                }
            }
            Program.writeBytes(playerTalentBoxes, pTalentPath, 64 + (95 * lbx_PlayerSelect.SelectedIndex), 1, 100, true);
            MessageBox.Show("Writing complete.");
        }


        //############################ Store Data ######################################

        private void rdb_StoreUpgrades_CheckedChanged(object sender, EventArgs e)
        {
            lbl_StoreItemSelect.Text = "Select upgrade";
            Program.FillCbx(storeUpgrades, lbx_StoreItemSelect);
        }

        private void rdb_StoreTags_CheckedChanged(object sender, EventArgs e)
        {
            lbl_StoreItemSelect.Text = "Select tag";
            Program.FillCbx(storeTags, lbx_StoreItemSelect);
        }

        private void lbx_StoreItemSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextBox[] tempBox = { txt_StorePrice };
            if (rdb_StoreUpgrades.Checked)
                Program.readBytes(tempBox, storePricesPath, 1399 + (15 * lbx_StoreItemSelect.SelectedIndex), 0, 1, false);
            else
                Program.readBytes(tempBox, storePricesPath, 1624 + (15 * lbx_StoreItemSelect.SelectedIndex), 0, 1, false);
        }

        private void btn_ApplyStore_Click(object sender, EventArgs e)
        {
            uint tempInt;
            if (!uint.TryParse(txt_StorePrice.Text, out tempInt))
            {
                MessageBox.Show("Input error!");
                return;
            }
            TextBox[] tempBox = { txt_StorePrice };
            if (rdb_StoreUpgrades.Checked)
                Program.writeBytes(tempBox, storePricesPath, 1399 + (15 * lbx_StoreItemSelect.SelectedIndex), 0, 1, false);
            else
                Program.writeBytes(tempBox, storePricesPath, 1624 + (15 * lbx_StoreItemSelect.SelectedIndex), 0, 1, false);
            MessageBox.Show("Writing complete.");
        }
    }
}
