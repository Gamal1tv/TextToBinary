namespace TextToBinaryConversion
{
    partial class Form1
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
            this.txtBox2 = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.lblBox1 = new System.Windows.Forms.Label();
            this.lblBox2 = new System.Windows.Forms.Label();
            this.btnSwitch = new System.Windows.Forms.Button();
            this.txtBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtBox2
            // 
            this.txtBox2.Location = new System.Drawing.Point(470, 22);
            this.txtBox2.Multiline = true;
            this.txtBox2.Name = "txtBox2";
            this.txtBox2.Size = new System.Drawing.Size(318, 416);
            this.txtBox2.TabIndex = 1;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(360, 183);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 51);
            this.btnConvert.TabIndex = 2;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // lblBox1
            // 
            this.lblBox1.AutoSize = true;
            this.lblBox1.Location = new System.Drawing.Point(12, 6);
            this.lblBox1.Name = "lblBox1";
            this.lblBox1.Size = new System.Drawing.Size(28, 13);
            this.lblBox1.TabIndex = 3;
            this.lblBox1.Text = "Text";
            // 
            // lblBox2
            // 
            this.lblBox2.AutoSize = true;
            this.lblBox2.Location = new System.Drawing.Point(467, 6);
            this.lblBox2.Name = "lblBox2";
            this.lblBox2.Size = new System.Drawing.Size(36, 13);
            this.lblBox2.TabIndex = 4;
            this.lblBox2.Text = "Binary";
            // 
            // btnSwitch
            // 
            this.btnSwitch.Location = new System.Drawing.Point(360, 240);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(75, 51);
            this.btnSwitch.TabIndex = 5;
            this.btnSwitch.Text = "Switch";
            this.btnSwitch.UseVisualStyleBackColor = true;
            this.btnSwitch.Click += new System.EventHandler(this.btnSwitch_Click);
            // 
            // txtBox1
            // 
            this.txtBox1.Location = new System.Drawing.Point(12, 22);
            this.txtBox1.Multiline = true;
            this.txtBox1.Name = "txtBox1";
            this.txtBox1.Size = new System.Drawing.Size(318, 416);
            this.txtBox1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBox1);
            this.Controls.Add(this.btnSwitch);
            this.Controls.Add(this.lblBox2);
            this.Controls.Add(this.lblBox1);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txtBox2);
            this.Name = "Form1";
            this.Text = "Binary Text Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBox2;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label lblBox1;
        private System.Windows.Forms.Label lblBox2;
        private System.Windows.Forms.Button btnSwitch;
        private System.Windows.Forms.TextBox txtBox1;
    }
}

