using ConsoleApp1.Model;
using Windows.Media.Protection.PlayReady;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frame));
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
           
            // 
            // Frame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 600);
            Controls.Add(pictureBox1);
            Name = "Frame";
            Text = "Frame";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void Frame_Paint(object sender, PaintEventArgs e)
        {
            this.drawBg(e);
            this.drawTables(e);
            this.drawClients(e);
            this.drawMH(e);
        }

        private void drawBg(PaintEventArgs e)
        {
            for (int i = 0; i < (salle.width / 80) - 1; i++)
            {
                for (int j = 0; j < (salle.height / 60) - 1; j++)
                {
                    // Create Point for upper-left corner of image.
                    Point ulCorner = new Point(i * 95, j * 75);

                    // Draw image to screen.
                    e.Graphics.DrawImage(salle.sol[i * j].sprite, ulCorner);
                }

            }
        }

        private void drawTables(PaintEventArgs e)
        {
            foreach(Table table in salle.tables)
            {
                // Create Point for upper-left corner of image.
                Point ulCorner = new Point(table.x, table.y);

                // Draw image to screen.
                e.Graphics.DrawImage(table.sprite, ulCorner);
            }
        }

        private void drawClients(PaintEventArgs e)
        {
            foreach (GroupeClients client in salle.clients)
            { 

                // Draw image to screen.
                e.Graphics.DrawImage(client.sprite, client.x, client.y, client.sprite.Width, client.sprite.Height);

                TextRenderer.DrawText(e.Graphics, client.nbreClients.ToString(), this.Font,
                new Rectangle(client.x, client.y, 70, 70), SystemColors.ControlText,
                SystemColors.ControlDark);
            }
        } 

        private void drawMH(PaintEventArgs e)
        {
            // Create Point for upper-left corner of image.
            // Draw image to screen.
            e.Graphics.DrawImage(this.salle.mh.sprite, this.salle.mh.x, this.salle.mh.y, this.salle.mh.sprite.Width, this.salle.mh.sprite.Height);
        }
        #endregion

        private PictureBox pictureBox1;
    }
}