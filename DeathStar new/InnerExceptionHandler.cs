using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeathStar_new
{
    internal class InnerExceptionHandler
    {
        public void handle(Exception ec)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(ec.Message);
            Exception er = ec.InnerException;
            int a = 4;
            while (er != null)
            {            
                sb.AppendLine($"{new string(' ', a)}-> {er.Message}");
                er = er.InnerException;
                a += 4;
            }
            MessageBox.Show(sb.ToString());
            return;
        }
    }
}
