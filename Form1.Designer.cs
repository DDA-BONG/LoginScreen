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
            txtID = new TextBox();
            txtPW = new TextBox();
            btnLogin = new Button();
            lblAppName = new Label();
            SuspendLayout();
            // 
            // txtID
            // 
            txtID.Font = new Font("맑은 고딕", 20F);
            txtID.ForeColor = Color.Silver;
            txtID.Location = new Point(103, 171);
            txtID.Margin = new Padding(4);
            txtID.Name = "txtID";
            txtID.Size = new Size(362, 52);
            txtID.TabIndex = 2;
            txtID.Text = "아이디";
            txtID.Enter += txtID_Enter;
            txtID.Leave += txtID_Leave;
            // 
            // txtPW
            // 
            txtPW.Font = new Font("맑은 고딕", 20F);
            txtPW.ForeColor = Color.Silver;
            txtPW.Location = new Point(103, 238);
            txtPW.Margin = new Padding(4);
            txtPW.Name = "txtPW";
            txtPW.Size = new Size(362, 52);
            txtPW.TabIndex = 3;
            txtPW.Text = "패스워드";
            txtPW.Enter += txtPW_Enter;
            txtPW.Leave += txtPW_Leave;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(128, 255, 255);
            btnLogin.Font = new Font("맑은 고딕", 20F);
            btnLogin.ForeColor = Color.FromArgb(0, 0, 192);
            btnLogin.Location = new Point(173, 355);
            btnLogin.Margin = new Padding(4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(222, 77);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "로그인";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("맑은 고딕", 50F);
            lblAppName.Location = new Point(155, 18);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(258, 112);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "Login";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(571, 516);
            Controls.Add(lblAppName);
            Controls.Add(btnLogin);
            Controls.Add(txtPW);
            Controls.Add(txtID);
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
        private TextBox txtID;
        private TextBox txtPW;
        private Button btnLogin;
        private Label lblAppName;
    }
}
