namespace WindowsFormsApplication1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.REGNO_FIELD = new System.Windows.Forms.TextBox();
            this.PWD_FIELD = new System.Windows.Forms.TextBox();
            this.OK_Button = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Register Number : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password : ";
            // 
            // REGNO_FIELD
            // 
            this.REGNO_FIELD.Location = new System.Drawing.Point(113, 101);
            this.REGNO_FIELD.MaxLength = 15;
            this.REGNO_FIELD.Name = "REGNO_FIELD";
            this.REGNO_FIELD.Size = new System.Drawing.Size(197, 20);
            this.REGNO_FIELD.TabIndex = 2;
            this.REGNO_FIELD.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // PWD_FIELD
            // 
            this.PWD_FIELD.Location = new System.Drawing.Point(113, 161);
            this.PWD_FIELD.MaxLength = 50;
            this.PWD_FIELD.Name = "PWD_FIELD";
            this.PWD_FIELD.Size = new System.Drawing.Size(197, 20);
            this.PWD_FIELD.TabIndex = 3;
            this.PWD_FIELD.UseSystemPasswordChar = true;
            this.PWD_FIELD.TextChanged += new System.EventHandler(this.PWD_FIELD_TextChanged);
            // 
            // OK_Button
            // 
            this.OK_Button.Location = new System.Drawing.Point(235, 215);
            this.OK_Button.Name = "OK_Button";
            this.OK_Button.Size = new System.Drawing.Size(75, 23);
            this.OK_Button.TabIndex = 4;
            this.OK_Button.Text = "OK";
            this.OK_Button.UseVisualStyleBackColor = true;
            this.OK_Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.CausesValidation = false;
            this.webBrowser1.Location = new System.Drawing.Point(40, 215);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(67, 34);
            this.webBrowser1.TabIndex = 5;
            this.webBrowser1.Url = new System.Uri("https://192.168.10.3/connect/PortalMain", System.UriKind.Absolute);
            this.webBrowser1.Visible = false;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(135, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 282);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.OK_Button);
            this.Controls.Add(this.PWD_FIELD);
            this.Controls.Add(this.REGNO_FIELD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Network Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox REGNO_FIELD;
        private System.Windows.Forms.TextBox PWD_FIELD;
        private System.Windows.Forms.Button OK_Button;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

