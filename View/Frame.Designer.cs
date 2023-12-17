using ConsoleApp1.Model;

namespace ConsoleApp1.View
{
    partial class Frame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Salle salle;

        public Frame(Salle salle)
        {
            this.salle = salle;
            this.Size = new Size(salle.width, salle.height);
            this.Paint += new PaintEventHandler(this.Frame_Paint);
        }

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);

            this.Text = "Frame";
        }
        
        private void Frame_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < (salle.width / 80) - 1; i++) 
            {
                for  (int j = 0; j < (salle.height / 60) - 1; j++) 
                {
                    // Create Point for upper-left corner of image.
                    Point ulCorner = new Point(i * 95, j * 75);

                    // Draw image to screen.
                    e.Graphics.DrawImage(salle.sol[i * j].sprite, ulCorner) ;
                }
               
            }
           
        }


        #endregion
    }
}