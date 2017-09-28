using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SBW.UI.Common
{
    public class Helper
    {
        /// <summary>
        /// Clears every control in the form or user control.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="Form">The form.</param>
        public static void ClearAll<T>(T Form) where T : ContainerControl
        {
            foreach(var obj in Form.Controls)
            {
                if (obj is TextBox)
                {
                    TextBox tb = (TextBox)obj;
                    tb.Text = string.Empty;
                }
                else if (obj is RichTextBox)
                {
                    RichTextBox rtb = (RichTextBox)obj;
                    rtb.Text = string.Empty;
                }
                else if (obj is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)obj;
                    dtp.Value = DateTime.Now;
                }
            }
        }
    }
}
