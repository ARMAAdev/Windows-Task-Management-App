using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace taskManager
{

    public partial class mainForm : Form
    {

        void useMyUI()
        {
            this.buttonSearch.IconColor = this.buttonSort.IconColor = this.buttonFilter.IconColor
                = this.buttonCalender.IconColor = this.buttonDelete.IconColor = this.buttonSelect.IconColor
                = this.searchCancel.ForeColor = myUI.Colors("lighterColorMain");
            this.buttonAdd.ForeColor = this.buttonAdd.IconColor = myUI.Colors("lightestColorMain");
            this.panelTop.BackColor = this.textBoxSearch.BackColor = this.textBoxSearch.BackColor =
                this.cmsSort.BackColor = this.panelTop.BackColor 
                = myUI.Colors("darkColorMain");

            this.lowerRightUC1.BackColor = myUI.Colors("lightColorMain");

            this.listBoxTasks.BackColor = this.panelLeft.BackColor = myUI.Colors("mediumColorMain");

            this.panelMain.BackColor = this.viewTask.BackColor = this.dateAddedToolStripMenuItem.ForeColor =
                this.alphabeticalToolStripMenuItem.ForeColor = this.dueDateToolStripMenuItem.ForeColor =
                this.dateAddedToolStripMenuItem.ForeColor = myUI.Colors("darkestColorMain");
        }

        Color tempForeColor = new Color();
        Color tempBackColor = new Color();

        private void buttonAdd_MouseEnter(object sender, EventArgs e)
        {
            IconButton thisButton = (IconButton)sender;
            tempForeColor = thisButton.IconColor;
            tempBackColor = thisButton.BackColor;

            thisButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            thisButton.BackColor = Color.Empty;
            thisButton.IconColor = thisButton.ForeColor = Color.White;
        }

        private void buttonAdd_MouseLeave(object sender, EventArgs e)
        {
            IconButton thisButton = (IconButton)sender;
            thisButton.BackColor = tempBackColor;
            thisButton.IconColor = thisButton.ForeColor = tempForeColor;

        }

        private void buttonTopPanel_MouseEnter(object sender, EventArgs e)
        {
            IconButton thisButton = (IconButton)sender;
            tempForeColor = thisButton.IconColor;
            tempBackColor = thisButton.BackColor;

            thisButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            thisButton.BackColor = Color.Empty;
            thisButton.IconColor = Color.White;
        }

        private void buttonTopPanel_MouseLeave(object sender, EventArgs e)
        {
            IconButton thisButton = (IconButton)sender;
            thisButton.BackColor = tempBackColor;
            thisButton.IconColor = tempForeColor;
        }

        private void searchCancel_MouseEnter(object sender, EventArgs e)
        {
            Label thisLabel = (Label)sender;
            tempForeColor = thisLabel.ForeColor;
            tempBackColor = thisLabel.BackColor;

            thisLabel.BackColor = Color.Empty;
            thisLabel.ForeColor = Color.White;
        }
        private void searchCancel_MouseLeave(object sender, EventArgs e)
        {
            Label thisLabel = (Label)sender;

            thisLabel.ForeColor = tempForeColor;
            thisLabel.BackColor = tempBackColor;
        }
    }

    public class myUI
    {
        public static int theme { get; set; }

        public static Color Colors(string _colorName)
        {
            switch (theme)
            {
                case 4:   //red theme
                    switch (_colorName) // Color derived from Orangle Teal Palette found on https://www.schemecolor.com/orange-and-teal.php
                    {
                        case "lightestColorMain":
                            return Color.FromArgb(43,45,66);
                            break;
                        case "lighterColorMain":
                            return Color.FromArgb(43, 45, 66);
                            break;
                        case "lightColorMain":
                            return Color.FromArgb(43, 45, 66);
                            break;
                        case "mediumColorMain":
                            return Color.FromArgb(239,35,60);
                            break;
                        case "darkColorMain":
                            return Color.FromArgb(216,0,50);
                            break;
                        case "darkestColorMain":
                            return Color.FromArgb(141, 153, 174);
                            break;
                        case "lightColorSecondary":
                            return Color.FromArgb(43, 45, 66);
                            break;
                        case "mediumColorSecondary":
                            return Color.FromArgb(216, 0, 50);
                            break;
                        case "darkColorSecondary":
                            return Color.FromArgb(43, 45, 66);
                            break;
                        default:
                            return Color.Black;
                            break;
                    }

                case 3:   //desert theme
                    switch (_colorName) // Color derived from Orangle Teal Palette found on https://www.schemecolor.com/orange-and-teal.php
                    {
                        case "lightestColorMain":
                            return Color.FromArgb(255, 155, 66);
                            break;
                        case "lighterColorMain":
                            return Color.FromArgb(15,163,177);
                            break;
                        case "lightColorMain": 
                            return Color.FromArgb(217,229,214);
                            break;
                        case "mediumColorMain": 
                            return Color.FromArgb(255, 155, 66);
                            break;
                        case "darkColorMain": 
                            return Color.FromArgb(237, 222, 164);
                            break;
                        case "darkestColorMain":
                            return Color.FromArgb(247,160,114);
                            break;
                        case "lightColorSecondary": 
                            return Color.FromArgb(247,160,114);
                            break;
                        case "mediumColorSecondary":
                            return Color.FromArgb(255,155,66); 
                            break;
                        case "darkColorSecondary":
                            return Color.FromArgb(255,155,66); 
                            break;
                        default:
                            return Color.Black;
                            break;
                    }

                case 2:   //purple theme 
                    switch (_colorName) // Color derived from Orangle Teal Palette found on https://www.schemecolor.com/orange-and-teal.php
                    {
                        case "lightestColorMain":
                            return Color.FromArgb(245,204,232);
                            break;
                        case "lighterColorMain":
                            return Color.FromArgb(245,204,232);
                            break;
                        case "lightColorMain":
                            return Color.FromArgb(236,157,237);
                            break;
                        case "mediumColorMain": 
                            return Color.FromArgb(236,157,237);
                            break;
                        case "darkColorMain": 
                            return Color.FromArgb(200,128,183);
                            break;
                        case "darkestColorMain":
                            return Color.FromArgb(159,107,160);
                            break;
                        case "lightColorSecondary": 
                            return Color.FromArgb(159,107,160);
                            break;
                        case "mediumColorSecondary":
                            return Color.FromArgb(74,32,64); 
                            break;
                        case "darkColorSecondary":
                            return Color.FromArgb(74, 32, 64); 
                            break;
                        default:
                            return Color.Black;
                            break;
                    }


                case 1:
                    switch (_colorName) // Color derived from Orangle Teal Palette found on https://www.schemecolor.com/orange-and-teal.php
                    {
                        case "lightestColorMain":
                            return Color.Yellow;
                            break;
                        case "lighterColorMain":
                            return Color.LightYellow;
                            break;
                        case "lightColorMain": // Light Sea Green
                            return Color.LightGoldenrodYellow;
                            break;
                        case "mediumColorMain": // Teal
                            return Color.YellowGreen;
                            break;
                        case "darkColorMain": // Bangladesh Green
                            return Color.YellowGreen;
                            break;
                        case "darkestColorMain":
                            return Color.Green;
                            break;
                        case "lightColorSecondary": // Yellow Orange
                            return Color.FromArgb(250, 171, 54);
                            break;
                        case "mediumColorSecondary":
                            return Color.FromArgb(247, 129, 4); // University Of Tennessee Orange
                            break;
                        case "darkColorSecondary":
                            return Color.FromArgb(253, 89, 1); // Willpower Orange
                            break;
                        default:
                            return Color.Black;
                            break;
                    }
                        case 0:
                default:
                    switch (_colorName) // Color derived from Orangle Teal Palette found on https://www.schemecolor.com/orange-and-teal.php
                    {
                        case "lightestColorMain":
                            return Color.FromArgb(211, 236, 236);
                            break;
                        case "lighterColorMain":
                            return Color.FromArgb(146, 207, 208);
                            break;
                        case "lightColorMain": // Light Sea Green
                            return Color.FromArgb(36, 158, 160);
                            break;
                        case "mediumColorMain": // Teal
                            return Color.FromArgb(0, 128, 131);
                            break;
                        case "darkColorMain": // Bangladesh Green
                            return Color.FromArgb(0, 95, 96);
                            break;
                        case "darkestColorMain": // Bangladesher Green
                            return Color.FromArgb(0, 64, 65);
                            break;
                        case "lightColorSecondary": // Yellow Orange
                            return Color.FromArgb(250, 171, 54);
                            break;
                        case "mediumColorSecondary":
                            return Color.FromArgb(247, 129, 4); // University Of Tennessee Orange
                            break;
                        case "darkColorSecondary":
                            return Color.FromArgb(253, 89, 1); // Willpower Orange
                            break;
                        default:
                            return Color.Black;
                            break;
                    }
            }
        }
    }
}
