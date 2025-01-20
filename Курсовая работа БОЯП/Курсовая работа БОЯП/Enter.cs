using System.Windows.Forms;

namespace Курсовая_работа_БОЯП
{
    public partial class Enter : Form
    {
        public Enter()
        {
            InitializeComponent();
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
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
