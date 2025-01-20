namespace HumanResourceApp
{
    partial class Register
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
            panel1 = new Panel();
            Reg_ToLogBtn = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            User_RegTxt = new TextBox();
            Password_RegTxt = new TextBox();
            Reg_Btn = new Button();
            X_Btn = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSeaGreen;
            panel1.Controls.Add(Reg_ToLogBtn);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(280, 450);
            panel1.TabIndex = 0;
            // 
            // Reg_ToLogBtn
            // 
            Reg_ToLogBtn.BackColor = SystemColors.ControlLightLight;
            Reg_ToLogBtn.FlatStyle = FlatStyle.Popup;
            Reg_ToLogBtn.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Reg_ToLogBtn.ForeColor = Color.DarkSeaGreen;
            Reg_ToLogBtn.Location = new Point(101, 284);
            Reg_ToLogBtn.Name = "Reg_ToLogBtn";
            Reg_ToLogBtn.Size = new Size(75, 27);
            Reg_ToLogBtn.TabIndex = 2;
            Reg_ToLogBtn.Text = "Login";
            Reg_ToLogBtn.UseVisualStyleBackColor = false;
            Reg_ToLogBtn.Click += Reg_ToLogBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(71, 263);
            label1.Name = "label1";
            label1.Size = new Size(144, 15);
            label1.TabIndex = 1;
            label1.Text = "Already have an Account?";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.rila;
            pictureBox1.Location = new Point(80, 128);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(126, 115);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(316, 128);
            label2.Name = "label2";
            label2.Size = new Size(177, 19);
            label2.TabIndex = 1;
            label2.Text = "Create Your Account";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            label3.Location = new Point(304, 183);
            label3.Name = "label3";
            label3.Size = new Size(66, 14);
            label3.TabIndex = 2;
            label3.Text = "Username";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            label4.Location = new Point(304, 246);
            label4.Name = "label4";
            label4.Size = new Size(66, 14);
            label4.TabIndex = 3;
            label4.Text = "Password";
            // 
            // User_RegTxt
            // 
            User_RegTxt.Font = new Font("Segoe UI", 10F);
            User_RegTxt.Location = new Point(304, 200);
            User_RegTxt.Name = "User_RegTxt";
            User_RegTxt.Size = new Size(201, 25);
            User_RegTxt.TabIndex = 4;
            // 
            // Password_RegTxt
            // 
            Password_RegTxt.Font = new Font("Segoe UI", 10F);
            Password_RegTxt.Location = new Point(304, 263);
            Password_RegTxt.Name = "Password_RegTxt";
            Password_RegTxt.PasswordChar = '*';
            Password_RegTxt.Size = new Size(201, 25);
            Password_RegTxt.TabIndex = 5;
            Password_RegTxt.Tag = "";
            // 
            // Reg_Btn
            // 
            Reg_Btn.BackColor = Color.DarkSeaGreen;
            Reg_Btn.FlatStyle = FlatStyle.Popup;
            Reg_Btn.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Reg_Btn.ForeColor = SystemColors.ControlLightLight;
            Reg_Btn.Location = new Point(430, 304);
            Reg_Btn.Name = "Reg_Btn";
            Reg_Btn.Size = new Size(75, 28);
            Reg_Btn.TabIndex = 6;
            Reg_Btn.Text = "Register";
            Reg_Btn.UseVisualStyleBackColor = false;
            Reg_Btn.Click += Reg_Btn_Click;
            // 
            // X_Btn
            // 
            X_Btn.AutoSize = true;
            X_Btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            X_Btn.Location = new Point(525, 0);
            X_Btn.Name = "X_Btn";
            X_Btn.Size = new Size(15, 15);
            X_Btn.TabIndex = 7;
            X_Btn.Text = "X";
            X_Btn.Click += X_Btn_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(538, 450);
            Controls.Add(X_Btn);
            Controls.Add(Reg_Btn);
            Controls.Add(Password_RegTxt);
            Controls.Add(User_RegTxt);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Register";
            Text = "Register";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button Reg_ToLogBtn;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox User_RegTxt;
        private TextBox Password_RegTxt;
        private Button Reg_Btn;
        private Label X_Btn;
    }
}