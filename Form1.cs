using DeathStar.Forme;
using NHibernate;
using System.Text;

namespace DeathStar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                s.Close();
            }
            catch(Exception ec)
            {
                StringBuilder sb = new();
                sb.AppendLine(ec.Message);
                Exception er = ec.InnerException;

                while (er != null)   
                {
                    int a = 4;
                    sb.AppendLine($"{new string(' ', a)}-> {er.Message}");
                    er = er.InnerException;
                    a += 4;
                }
                MessageBox.Show(sb.ToString());
                return;
            }
        }
    }
}