namespace FlatComboExample.Net
{
    partial class Form1
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
            this.flatComboBox1 = new FlatComboBox();
            this.flatComboBox2 = new FlatComboBox();
            this.flatComboBox3 = new FlatComboBox();
            this.flatComboBox4 = new FlatComboBox();
            this.flatComboBox5 = new FlatComboBox();
            this.SuspendLayout();
            // 
            // flatComboBox1
            // 
            this.flatComboBox1.BorderColor = System.Drawing.Color.Red;
            this.flatComboBox1.ButtonColor = System.Drawing.Color.PeachPuff;
            this.flatComboBox1.FormattingEnabled = true;
            this.flatComboBox1.Location = new System.Drawing.Point(27, 25);
            this.flatComboBox1.Name = "flatComboBox1";
            this.flatComboBox1.Size = new System.Drawing.Size(407, 39);
            this.flatComboBox1.TabIndex = 0;
            // 
            // flatComboBox2
            // 
            this.flatComboBox2.BorderColor = System.Drawing.Color.Green;
            this.flatComboBox2.ButtonColor = System.Drawing.Color.PaleGreen;
            this.flatComboBox2.FormattingEnabled = true;
            this.flatComboBox2.Location = new System.Drawing.Point(27, 86);
            this.flatComboBox2.Name = "flatComboBox2";
            this.flatComboBox2.Size = new System.Drawing.Size(407, 39);
            this.flatComboBox2.TabIndex = 0;
            // 
            // flatComboBox3
            // 
            this.flatComboBox3.BorderColor = System.Drawing.Color.Blue;
            this.flatComboBox3.ButtonColor = System.Drawing.Color.SkyBlue;
            this.flatComboBox3.FormattingEnabled = true;
            this.flatComboBox3.Location = new System.Drawing.Point(27, 147);
            this.flatComboBox3.Name = "flatComboBox3";
            this.flatComboBox3.Size = new System.Drawing.Size(407, 39);
            this.flatComboBox3.TabIndex = 0;
            // 
            // flatComboBox4
            // 
            this.flatComboBox4.BorderColor = System.Drawing.Color.Black;
            this.flatComboBox4.ButtonColor = System.Drawing.Color.Silver;
            this.flatComboBox4.FormattingEnabled = true;
            this.flatComboBox4.Location = new System.Drawing.Point(27, 208);
            this.flatComboBox4.Name = "flatComboBox4";
            this.flatComboBox4.Size = new System.Drawing.Size(407, 39);
            this.flatComboBox4.TabIndex = 0;
            // 
            // flatComboBox5
            // 
            this.flatComboBox5.Enabled = false;
            this.flatComboBox5.FormattingEnabled = true;
            this.flatComboBox5.Location = new System.Drawing.Point(27, 269);
            this.flatComboBox5.Name = "flatComboBox5";
            this.flatComboBox5.Size = new System.Drawing.Size(407, 39);
            this.flatComboBox5.TabIndex = 0;
            this.flatComboBox5.Text = "Disabled";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(16F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(609, 353);
            ClientSize = new Size(800, 450);
            Controls.Add(flatComboBox5);
            Controls.Add(flatComboBox4);
            Controls.Add(flatComboBox3);
            Controls.Add(flatComboBox2);
            Controls.Add(flatComboBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private FlatComboBox flatComboBox1;
        private FlatComboBox flatComboBox2;
        private FlatComboBox flatComboBox3;
        private FlatComboBox flatComboBox4;
        private FlatComboBox flatComboBox5;
    }
}