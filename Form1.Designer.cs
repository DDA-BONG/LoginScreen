namespace LoginScreen
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
            lblId = new Label();
            lblPassword = new Label();
            txtId = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            lbl_main = new Label();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("맑은 고딕", 10F);
            lblId.Location = new Point(86, 182);
            lblId.Margin = new Padding(4, 0, 4, 0);
            lblId.Name = "lblId";
            lblId.Size = new Size(61, 23);
            lblId.TabIndex = 0;
            lblId.Text = "아이디";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("맑은 고딕", 10F);
            lblPassword.Location = new Point(78, 253);
            lblPassword.Margin = new Padding(4, 0, 4, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(78, 23);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "패스워드";
            // 
            // txtId
            // 
            txtId.Font = new Font("맑은 고딕", 20F);
            txtId.Location = new Point(155, 171);
            txtId.Margin = new Padding(4);
            txtId.Name = "txtId";
            txtId.Size = new Size(258, 52);
            txtId.TabIndex = 2;
            txtId.Enter += txtId_Enter;
            txtId.Leave += txtId_Leave;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("맑은 고딕", 20F);
            txtPassword.Location = new Point(155, 238);
            txtPassword.Margin = new Padding(4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(258, 52);
            txtPassword.TabIndex = 3;
            txtPassword.Enter += txtPassword_Enter;
            txtPassword.Leave += txtPassword_Leave;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.ActiveCaption;
            btnLogin.ForeColor = Color.FromArgb(0, 0, 192);
            btnLogin.Location = new Point(187, 320);
            btnLogin.Margin = new Padding(4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(185, 43);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "로그인";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lbl_main
            // 
            lbl_main.AutoSize = true;
            lbl_main.Font = new Font("맑은 고딕", 50F);
            lbl_main.Location = new Point(155, 18);
            lbl_main.Name = "lbl_main";
            lbl_main.Size = new Size(258, 112);
            lbl_main.TabIndex = 5;
            lbl_main.Text = "Login";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(571, 516);
            Controls.Add(lbl_main);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtId);
            Controls.Add(lblPassword);
            Controls.Add(lblId);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login Screen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblId;
        private Label lblPassword;
        private TextBox txtId;
        private TextBox txtPassword;
        private Button btnLogin;
        private Label lbl_main;
    }
}
