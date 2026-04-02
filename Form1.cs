namespace LoginScreen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        String MyID = "admin";
        String MyPW = "superman";

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string inputID = txtID.Text;
            string inputPW = txtPW.Text;
            if (inputID == MyID && inputPW == MyPW)
            {
                lblErrorMsg.Visible = false;
                //MessageBox.Show("로그인 성공!", "로그인", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                lblErrorMsg.ForeColor = Color.Blue; lblErrorMsg.Text = "로그인 성공!"; 
                lblErrorMsg.Visible = true;

            }
            else
            {
                //MessageBox.Show("로그인 실패!", "로그인", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                lblErrorMsg.ForeColor = Color.Red; lblErrorMsg.Text = "아이디 또는 비밀번호가 잘못되었습니다.";
                lblErrorMsg.Visible = true;
            }
        }

        private void txtID_Enter(object sender, EventArgs e)
        {
            if (txtID.Text == "아이디")
            {
                txtID.Text = ""; // ID 텍스트박스 포커스 시 초기화
                txtID.ForeColor = Color.Black; // 텍스트 색상을 검정색으로 변경
            }

        }

        private void txtID_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                txtID.Text = "아이디"; // ID 텍스트박스 포커스 해제 시 초기값으로 설정
                txtID.ForeColor = Color.Silver; // 텍스트 색상을 회색으로 변경
            }
        }

        private void txtPW_Enter(object sender, EventArgs e)
        {
            if (txtPW.Text == "패스워드")
            {
                txtPW.Text = ""; // PW 텍스트박스 포커스 시 초기화
                txtPW.ForeColor = Color.Black; // 텍스트 색상을 검정색으로 변경
                txtPW.UseSystemPasswordChar = true; // PW 텍스트박스에 입력된 문자를 비밀번호 형태로 표시
            }
        }

        private void txtPW_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPW.Text))
            {
                txtPW.UseSystemPasswordChar = false; // PW 텍스트박스에 입력된 문자를 일반 텍스트로 표시
                txtPW.Text = "패스워드"; // PW 텍스트박스 포커스 해제 시 초기값으로 설정
                txtPW.ForeColor = Color.Silver; // 텍스트 색상을 회색으로 변경
            }
        }

        private void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Enter 키 입력 방지
                txtPW.Focus(); // PW 텍스트박스로 포커스 이동
            }
        }


        private void txtPW_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Enter 키 입력 방지
                btnLogin.PerformClick(); // 로그인 버튼 클릭 이벤트 실행
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnShowPW_Click(object sender, EventArgs e)
        {
            if (txtPW.UseSystemPasswordChar)
            {
                txtPW.UseSystemPasswordChar = false; // PW 텍스트박스에 입력된 문자를 일반 텍스트로 표시
                btnShowPW.Text = "숨기기"; // 버튼 텍스트 변경
            }
            else
            {
                txtPW.UseSystemPasswordChar = true; // PW 텍스트박스에 입력된 문자를 비밀번호 형태로 표시
                btnShowPW.Text = "보기"; // 버튼 텍스트 변경
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtID.Text = "아이디"; // ID 텍스트박스 초기값으로 설정
            txtID.ForeColor = Color.Silver; // ID 텍스트박스 텍스트 색상을 회색으로 변경
            txtPW.Text = "패스워드"; // PW 텍스트박스 초기값으로 설정
            txtPW.ForeColor = Color.Silver; // PW 텍스트박스 텍스트 색상을 회색으로 변경
            txtPW.UseSystemPasswordChar = false; // PW 텍스트박스에 입력된 문자를 일반 텍스트로 표시
        }
        
    }
}
