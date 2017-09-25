using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SBW.Core
{
    public class MessageBoxHelper
    {
        public static void showError(string message)
        {
            MessageBox.Show(message);
        }
    }
}
