using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KitchenApp.view
{
    public partial class ControlForm : Form
    {
        public KitchenForm kitchenForm { get; set; }
        public ControlForm(KitchenForm kitchenForm)
        {
            InitializeComponent();
            this.kitchenForm = kitchenForm; 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int chefNumber = Convert.ToInt32(numericUpDown1.Value);
            int partChefNumber = Convert.ToInt32(numericUpDown2.Value);
            int clerkNumber = Convert.ToInt32(numericUpDown3.Value);
            int washerNumber = Convert.ToInt32(numericUpDown4.Value);

            int cookingFireNumber = Convert.ToInt32(inputCookingFireNumber.Value);
            int panNumber = Convert.ToInt32(inputPanNumber.Value);
            int blenderNumber = Convert.ToInt32(inputBlenderNumber.Value);
            int ovenNumber = Convert.ToInt32(inputOvenNumber.Value);
            int kitchenKnifeNumber = Convert.ToInt32(inputKitchenKnifeNumber.Value);

            kitchenForm.model.SetEmployeeConfig(chefNumber, partChefNumber, clerkNumber, washerNumber);
            kitchenForm.model.SetMaterialConfig(cookingFireNumber, ovenNumber, blenderNumber, panNumber, kitchenKnifeNumber);

            this.Close();
        }

        private void ControlForm_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown8_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
