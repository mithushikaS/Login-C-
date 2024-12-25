namespace LoginApplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            txtPass = new TextBox();
            txtUser = new TextBox();
            checkBox1 = new CheckBox();
            linkLabel1 = new LinkLabel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(351, 215);
            button1.Name = "button1";
            button1.Size = new Size(83, 34);
            button1.TabIndex = 0;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Green;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Transparent;
            button2.Location = new Point(242, 215);
            button2.Name = "button2";
            button2.Size = new Size(82, 34);
            button2.TabIndex = 1;
            button2.Text = "Login";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(163, 71);
            label1.Name = "label1";
            label1.Size = new Size(81, 21);
            label1.TabIndex = 2;
            label1.Text = "Username";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(163, 133);
            label2.Name = "label2";
            label2.Size = new Size(76, 21);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // txtPass
            // 
            txtPass.Location = new Point(259, 125);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(175, 23);
            txtPass.TabIndex = 4;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(259, 68);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(175, 23);
            txtUser.TabIndex = 5;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox1.Location = new Point(296, 170);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(138, 25);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.LinkColor = Color.White;
            linkLabel1.Location = new Point(301, 266);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(133, 21);
            linkLabel1.TabIndex = 7;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Forgot Password?";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(40, 68);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(82, 85);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Purple;
            ClientSize = new Size(555, 337);
            Controls.Add(pictureBox1);
            Controls.Add(linkLabel1);
            Controls.Add(checkBox1);
            Controls.Add(txtUser);
            Controls.Add(txtPass);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private TextBox txtPass;
        private TextBox txtUser;
        private CheckBox checkBox1;
        private LinkLabel linkLabel1;
        private PictureBox pictureBox1;
    }
}
