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
    public partial class MonitorForm : Form
    {
        public KitchenForm kitchenForm { get; set; }
        public MonitorForm(KitchenForm kitchenForm)
        {
            InitializeComponent();
            this.kitchenForm = kitchenForm;
        }

        private void Blenders_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MonitorForm_Load(object sender, EventArgs e)
        {
            labelBlenderStockNumber.Text = kitchenForm.model.blender.quantity + "";
            labelBlenderAvailableNumber.Text = kitchenForm.model.blender.quantity + "";
            labelChefNumber.Text = kitchenForm.model.chefs.Length + "";
            labelAvailableChefNumber.Text = kitchenForm.model.chefs.Length + "";
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
