using System.Windows.Forms;

namespace Курсовая_работа_БОЯП
{
    public partial class Enter : Form
    {
        public Enter()
        {
            InitializeComponent();
            this.FormClosed += (object s, FormClosedEventArgs ev) => Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e) // кнопка авторизации
        {
            Auth auth = new Auth();
            this.TopLevel = true;
            this.Hide();
            auth.TopLevel = true;
            auth.Show();
            auth.FormClosed += (object s, FormClosedEventArgs ev) => this.Show();
        }

        private void button1_Click(object sender, EventArgs e) //кнопка регистрации
        {
            Registration reg = new Registration();
            this.TopLevel = true;
            this.Hide();
            reg.TopLevel = true;
            reg.Show();
            reg.FormClosed += (object s, FormClosedEventArgs ev) => this.Show();
        }
    }
}
