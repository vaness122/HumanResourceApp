namespace HumanResourceApp
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            Login_Btn = new Button();
            Log_ToRegBtn = new Button();
            label1 = new Label();
            Password_LogTxt = new TextBox();
            User_LogTxt = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            X_Btn = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Login_Btn
            // 
            Login_Btn.BackColor = Color.DarkSeaGreen;
            Login_Btn.FlatStyle = FlatStyle.Popup;
            Login_Btn.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Login_Btn.ForeColor = SystemColors.ControlLightLight;
            Login_Btn.Location = new Point(161, 295);
            Login_Btn.Name = "Login_Btn";
            Login_Btn.Size = new Size(75, 28);
            Login_Btn.TabIndex = 13;
            Login_Btn.Text = "Login";
            Login_Btn.UseVisualStyleBackColor = false;
            Login_Btn.Click += Login_Btn_Click;
            // 
            // Log_ToRegBtn
            // 
            Log_ToRegBtn.BackColor = SystemColors.ControlLightLight;
            Log_ToRegBtn.FlatStyle = FlatStyle.Popup;
            Log_ToRegBtn.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Log_ToRegBtn.ForeColor = Color.DarkSeaGreen;
            Log_ToRegBtn.Location = new Point(101, 284);
            Log_ToRegBtn.Name = "Log_ToRegBtn";
            Log_ToRegBtn.Size = new Size(75, 27);
            Log_ToRegBtn.TabIndex = 2;
            Log_ToRegBtn.Text = "Register";
            Log_ToRegBtn.UseVisualStyleBackColor = false;
            Log_ToRegBtn.Click += Log_ToRegBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(114, 263);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 1;
            label1.Text = "New User?";
            // 
            // Password_LogTxt
            // 
            Password_LogTxt.Font = new Font("Segoe UI", 10F);
            Password_LogTxt.Location = new Point(35, 254);
            Password_LogTxt.Name = "Password_LogTxt";
            Password_LogTxt.PasswordChar = '*';
            Password_LogTxt.Size = new Size(201, 25);
            Password_LogTxt.TabIndex = 12;
            // 
            // User_LogTxt
            // 
            User_LogTxt.Font = new Font("Segoe UI", 10F);
            User_LogTxt.Location = new Point(35, 191);
            User_LogTxt.Name = "User_LogTxt";
            User_LogTxt.Size = new Size(201, 25);
            User_LogTxt.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            label4.Location = new Point(35, 237);
            label4.Name = "label4";
            label4.Size = new Size(66, 14);
            label4.TabIndex = 10;
            label4.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            label3.Location = new Point(35, 174);
            label3.Name = "label3";
            label3.Size = new Size(66, 14);
            label3.TabIndex = 9;
            label3.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(47, 119);
            label2.Name = "label2";
            label2.Size = new Size(166, 19);
            label2.TabIndex = 8;
            label2.Text = "Login Your Account";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSeaGreen;
            panel1.Controls.Add(X_Btn);
            panel1.Controls.Add(Log_ToRegBtn);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(258, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(280, 450);
            panel1.TabIndex = 7;
            // 
            // X_Btn
            // 
            X_Btn.AutoSize = true;
            X_Btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            X_Btn.Location = new Point(265, 0);
            X_Btn.Name = "X_Btn";
            X_Btn.Size = new Size(15, 15);
            X_Btn.TabIndex = 8;
            X_Btn.Text = "X";
            X_Btn.Click += X_Btn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(80, 128);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(126, 115);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(538, 450);
            Controls.Add(Login_Btn);
            Controls.Add(Password_LogTxt);
            Controls.Add(User_LogTxt);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Login_Btn;
        private Button Log_ToRegBtn;
        private Label label1;
        private TextBox Password_LogTxt;
        private TextBox User_LogTxt;
        private Label label4;
        private Label label3;
        private Label label2;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label X_Btn;
    }
}