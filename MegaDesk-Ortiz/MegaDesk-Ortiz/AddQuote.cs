using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Ortiz
{
    public partial class AddQuoteForm : Form
    {
        public AddQuoteForm()
        {
            InitializeComponent();
            listDesktopMaterial();
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();
            Close();
        }

        private void customerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void sizeWidth_TextChanged(object sender, EventArgs e)
        {

        }
        private void SizeWidthValiding(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
        public bool ValidRangeSizeWidth(int number)
        {
            if (number >= 1 && number <= 20)
            {
                return true;
            }
            else if (number <= 0 || number > 20)
            {
                return false;
            }
            else
            {
                return false;
            }
        }

        private void surfaceMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void listDesktopMaterial()
        {
            surfaceMaterial.Items.AddRange(new object[] { "laminate", "oak", "rosewood", "veneer", "pine" });
            rushOrder.Items.AddRange(new object[] { "Normal - 14 days", "3 days", "5 days", "7 days" });
        }

    }
}
