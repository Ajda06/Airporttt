namespace Airport
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
            Label label3;
            mySqlCommandBuilder1 = new MySqlConnector.MySqlCommandBuilder();
            textBoxUsername = new TextBox();
            textBoxPassword = new TextBox();
            labelUsername = new Label();
            labelPassword = new Label();
            buttonLogin = new Button();
            buttonExit = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.PapayaWhip;
            label3.Font = new Font("Algerian", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(274, 30);
            label3.Name = "label3";
            label3.Size = new Size(161, 34);
            label3.TabIndex = 5;
            label3.Text = "Welcome!";
            // 
            // mySqlCommandBuilder1
            // 
            mySqlCommandBuilder1.DataAdapter = null;
            mySqlCommandBuilder1.QuotePrefix = "`";
            mySqlCommandBuilder1.QuoteSuffix = "`";
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(310, 178);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(156, 27);
            textBoxUsername.TabIndex = 0;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(308, 233);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(156, 27);
            textBoxPassword.TabIndex = 1;
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.BackColor = SystemColors.ActiveCaption;
            labelUsername.ForeColor = SystemColors.ActiveCaptionText;
            labelUsername.Location = new Point(218, 178);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(78, 20);
            labelUsername.TabIndex = 2;
            labelUsername.Text = "UserName";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.BackColor = SystemColors.ActiveCaption;
            labelPassword.Location = new Point(226, 240);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(70, 20);
            labelPassword.TabIndex = 3;
            labelPassword.Text = "Password";
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = SystemColors.ActiveCaption;
            buttonLogin.Location = new Point(308, 286);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(156, 29);
            buttonLogin.TabIndex = 4;
            buttonLogin.Text = "LogIn";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click_1;
            // 
            // buttonExit
            // 
            buttonExit.BackColor = Color.RosyBrown;
            buttonExit.ForeColor = Color.Maroon;
            buttonExit.Location = new Point(604, 443);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(94, 29);
            buttonExit.TabIndex = 6;
            buttonExit.Text = "Exit";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Екранна_снимка__214_;
            ClientSize = new Size(710, 484);
            Controls.Add(buttonExit);
            Controls.Add(label3);
            Controls.Add(buttonLogin);
            Controls.Add(labelPassword);
            Controls.Add(labelUsername);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUsername);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Login Form";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MySqlConnector.MySqlCommandBuilder mySqlCommandBuilder1;
        private TextBox textBoxUsername;
        private TextBox textBoxPassword;
        private Label labelUsername;
        private Label labelPassword;
        private Button buttonLogin;
        private Label label3;
        private Button buttonExit;
    }
}
