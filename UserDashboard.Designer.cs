namespace HumanResourceApp
{
    partial class UserDashboard
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            SignOut_Btn = new Button();
            Username_Label = new Label();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            Profile_ToUserProfileBtn = new Button();
            pictureBox1 = new PictureBox();
            welcomeLabel = new Label();
            panel2 = new Panel();
            updateUsernameTextBox = new TextBox();
            Delete_Btn = new Button();
            Update_Btn = new Button();
            UserDataGridView = new DataGridView();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            panel3 = new Panel();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UserDataGridView).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Honeydew;
            panel1.Controls.Add(SignOut_Btn);
            panel1.Controls.Add(Username_Label);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(Profile_ToUserProfileBtn);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(12, 35);
            panel1.Name = "panel1";
            panel1.Size = new Size(155, 294);
            panel1.TabIndex = 2;
            // 
            // SignOut_Btn
            // 
            SignOut_Btn.BackColor = Color.DarkSeaGreen;
            SignOut_Btn.FlatStyle = FlatStyle.Popup;
            SignOut_Btn.Font = new Font("Tahoma", 8.25F, FontStyle.Bold);
            SignOut_Btn.ForeColor = SystemColors.ButtonFace;
            SignOut_Btn.Location = new Point(11, 246);
            SignOut_Btn.Name = "SignOut_Btn";
            SignOut_Btn.Size = new Size(128, 23);
            SignOut_Btn.TabIndex = 5;
            SignOut_Btn.Text = "Sign Out";
            SignOut_Btn.UseVisualStyleBackColor = false;
            SignOut_Btn.Click += SignOut_Btn_Click;
            // 
            // Username_Label
            // 
            Username_Label.AutoSize = true;
            Username_Label.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Username_Label.ForeColor = Color.DarkSeaGreen;
            Username_Label.Location = new Point(43, 136);
            Username_Label.Name = "Username_Label";
            Username_Label.Size = new Size(66, 14);
            Username_Label.TabIndex = 3;
            Username_Label.Text = "Username";
            // 
            // button4
            // 
            button4.BackColor = Color.DarkSeaGreen;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Tahoma", 8.25F, FontStyle.Bold);
            button4.ForeColor = SystemColors.ButtonFace;
            button4.Location = new Point(11, 226);
            button4.Name = "button4";
            button4.Size = new Size(128, 23);
            button4.TabIndex = 4;
            button4.Text = "null";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.DarkSeaGreen;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Tahoma", 8.25F, FontStyle.Bold);
            button3.ForeColor = SystemColors.ButtonFace;
            button3.Location = new Point(11, 207);
            button3.Name = "button3";
            button3.Size = new Size(128, 23);
            button3.TabIndex = 4;
            button3.Text = "null";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkSeaGreen;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Tahoma", 8.25F, FontStyle.Bold);
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(11, 187);
            button2.Name = "button2";
            button2.Size = new Size(128, 23);
            button2.TabIndex = 4;
            button2.Text = "List Of Users";
            button2.UseVisualStyleBackColor = false;
            // 
            // Profile_ToUserProfileBtn
            // 
            Profile_ToUserProfileBtn.BackColor = Color.DarkSeaGreen;
            Profile_ToUserProfileBtn.FlatStyle = FlatStyle.Popup;
            Profile_ToUserProfileBtn.Font = new Font("Tahoma", 8.25F, FontStyle.Bold);
            Profile_ToUserProfileBtn.ForeColor = SystemColors.ButtonFace;
            Profile_ToUserProfileBtn.Location = new Point(11, 167);
            Profile_ToUserProfileBtn.Name = "Profile_ToUserProfileBtn";
            Profile_ToUserProfileBtn.Size = new Size(128, 23);
            Profile_ToUserProfileBtn.TabIndex = 3;
            Profile_ToUserProfileBtn.Text = "Profile";
            Profile_ToUserProfileBtn.UseVisualStyleBackColor = false;
            Profile_ToUserProfileBtn.Click += Profile_ToUserProfileBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._2277e900ef76e0bd6d75fab4d1b70cb0;
            pictureBox1.Location = new Point(26, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 96);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // welcomeLabel
            // 
            welcomeLabel.AutoSize = true;
            welcomeLabel.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            welcomeLabel.ForeColor = Color.DarkSeaGreen;
            welcomeLabel.Location = new Point(16, 6);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(88, 19);
            welcomeLabel.TabIndex = 1;
            welcomeLabel.Text = "Welcome ";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonFace;
            panel2.Controls.Add(updateUsernameTextBox);
            panel2.Controls.Add(Delete_Btn);
            panel2.Controls.Add(Update_Btn);
            panel2.Controls.Add(UserDataGridView);
            panel2.Location = new Point(159, 35);
            panel2.Name = "panel2";
            panel2.Size = new Size(304, 294);
            panel2.TabIndex = 5;
            // 
            // updateUsernameTextBox
            // 
            updateUsernameTextBox.Location = new Point(25, 176);
            updateUsernameTextBox.Name = "updateUsernameTextBox";
            updateUsernameTextBox.Size = new Size(180, 23);
            updateUsernameTextBox.TabIndex = 6;
            // 
            // Delete_Btn
            // 
            Delete_Btn.BackColor = Color.DarkOliveGreen;
            Delete_Btn.FlatStyle = FlatStyle.Popup;
            Delete_Btn.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            Delete_Btn.ForeColor = Color.DarkSeaGreen;
            Delete_Btn.Location = new Point(211, 205);
            Delete_Btn.Name = "Delete_Btn";
            Delete_Btn.Size = new Size(75, 23);
            Delete_Btn.TabIndex = 5;
            Delete_Btn.Text = "DELETE";
            Delete_Btn.UseVisualStyleBackColor = false;
            Delete_Btn.Click += Delete_Btn_Click;
            // 
            // Update_Btn
            // 
            Update_Btn.BackColor = Color.DarkOliveGreen;
            Update_Btn.FlatStyle = FlatStyle.Popup;
            Update_Btn.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            Update_Btn.ForeColor = Color.DarkSeaGreen;
            Update_Btn.Location = new Point(211, 176);
            Update_Btn.Name = "Update_Btn";
            Update_Btn.Size = new Size(75, 23);
            Update_Btn.TabIndex = 4;
            Update_Btn.Text = "UPDATE";
            Update_Btn.UseVisualStyleBackColor = false;
            Update_Btn.Click += Update_Btn_Click;
            // 
            // UserDataGridView
            // 
            UserDataGridView.BackgroundColor = SystemColors.ButtonFace;
            UserDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            UserDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.DarkSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            UserDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            UserDataGridView.Location = new Point(25, 37);
            UserDataGridView.Name = "UserDataGridView";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.DarkSeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            UserDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            UserDataGridView.Size = new Size(261, 133);
            UserDataGridView.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ButtonFace;
            panel3.Controls.Add(welcomeLabel);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(-4, -1);
            panel3.Name = "panel3";
            panel3.Size = new Size(487, 30);
            panel3.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(460, 0);
            label2.Name = "label2";
            label2.Size = new Size(24, 25);
            label2.TabIndex = 7;
            label2.Text = "X";
            label2.Click += label2_Click;
            // 
            // UserDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(475, 340);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserDashboard";
            Text = "UserDashboard";
            Load += UserDashboard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)UserDataGridView).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label Username_Label;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button Profile_ToUserProfileBtn;
        private Label welcomeLabel;
        private Panel panel2;
        private DataGridView UserDataGridView;
        private Button SignOut_Btn;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private Button Delete_Btn;
        private Button Update_Btn;
        private Panel panel3;
        private Label label2;
        private TextBox updateUsernameTextBox;
    }
}