using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace StringArt
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 96);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 978);
            this.Controls.Add(this.button1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        private void Draw()
        {
            // create a canvas for painting on
            /*
            Bitmap pg = new Bitmap((int)(8.5 * 72), (int)(11 * 72));
            Graphics gr = Graphics.FromImage(pg);

            // clear the canvas to white
            Rectangle pgRect = new Rectangle(0, 0, pg.Width, pg.Height);
            SolidBrush solidWhite = new SolidBrush(Color.White);
            gr.FillRectangle(solidWhite, pgRect);
            */
            /*
            // load a new image and draw it centered on our canvas
            Stream stm = Assembly.GetExecutingAssembly().GetManifestResourceStream("Examples.pic1.jpg");
            Image img = Image.FromStream(stm);
            int w = img.Width * 2;
            int h = img.Height * 2;
            Rectangle rc = new Rectangle((pg.Width - w) / 2, (pg.Height - h) / 2, w, h);
            gr.DrawImage(img, rc);
            img.Dispose();
            stm.Close();
            */
            // frame the image with a black border
            //gr.DrawRectangle(new Pen(Color.Black, 4), rc);
            // add some text at the top left of the canvas
            /*
            Font fn = new Font("Comic Sans MS", 72);
            SolidBrush solidBlack = new SolidBrush(Color.Black);
            gr.DrawString("My Picture", fn, solidBlack, (int)(pg.Width * 0.1), (int)(pg.Height * 0.1));
            */
            // save the output
            //pg.Save("../../abcpdf.drawing.gif", System.Drawing.Imaging.ImageFormat.Gif);
            Graphics graphics = this.CreateGraphics();
            Rectangle rectangle = new Rectangle(
               50, 50, 150, 150);
            graphics.DrawEllipse(Pens.Black, rectangle);
            graphics.DrawRectangle(Pens.Red, rectangle);
        }

        #endregion

        private Button button1;
    }
}

