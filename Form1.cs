namespace LoginScreen
{
    public partial class Form1 : Form
    {
        private const string CorrectId = "abc";
        private const string CorrectPassword = "123";
        private const string IdPlaceholder = "아이디 입력";
        private const string PasswordPlaceholder = "패스워드 입력";

        public Form1()
        {
            InitializeComponent();
            SetIdPlaceholder();
            SetPasswordPlaceholder();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string inputId = txtId.ForeColor == Color.Gray ? string.Empty : txtId.Text;
            // 패스워드 입력란이 회색이면 빈 문자열로 간주
            string inputPassword = txtPassword.ForeColor == Color.Gray ? string.Empty : txtPassword.Text;
            
            if (inputId == CorrectId && inputPassword == CorrectPassword) // 입력된 아이디와 패스워드가 모두 일치하는 경우
            {
                MessageBox.Show("로그인 성공", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            MessageBox.Show("로그인 실패", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error); // 입력된 아이디 또는 패스워드가 하나라도 일치하지 않는 경우
        }

        private void txtId_Enter(object sender, EventArgs e)
        {
            if (txtId.ForeColor != Color.Gray)// 아이디 입력란이 회색이 아닌 경우 (즉, 이미 사용자가 입력한 텍스트가 있는 경우)
            {
                return;
            }

            txtId.Clear();
            txtId.ForeColor = Color.Black;
        }

        private void txtId_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtId.Text))
            {
                return;
            }

            SetIdPlaceholder();
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.ForeColor != Color.Gray)
            {
                return;
            }

            txtPassword.Clear();
            txtPassword.ForeColor = Color.Black;
            txtPassword.UseSystemPasswordChar = true;
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                return;
            }

            SetPasswordPlaceholder();
        }

        private void SetIdPlaceholder()
        {
            txtId.Text = IdPlaceholder;
            txtId.ForeColor = Color.Gray;
        }

        private void SetPasswordPlaceholder()
        {
            txtPassword.UseSystemPasswordChar = false;
            txtPassword.Text = PasswordPlaceholder;
            txtPassword.ForeColor = Color.Gray;
        }
    }
}
