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
        public static void Show(string message)
        {
            MessageBox.Show(message);
        }

        /// Shows the error message box.
        /// </summary>
        /// <param name="message">
        /// The message to be displayed.
        /// </param>
        /// <returns>
        /// One of the <see cref="System.Windows.Forms.DialogResult"/> values.
        /// </returns>
        public static DialogResult ShowError(string message)
        {
            return ShowMessage(message, null, MessageBoxIcon.Error, MessageBoxButtons.OK);
        }

        /// <summary>
        /// Shows the error.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="exception">The exception.</param>
        /// <returns>
        /// One of the <see cref="System.Windows.Forms.DialogResult"/> values.
        /// </returns>
        public static DialogResult ShowError(string message, string exception)
        {
            return ShowMessage(message, exception, MessageBoxIcon.Error, MessageBoxButtons.OK);
        }

        /// <summary>
        /// Shows the advance message.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="exceptionMessage">The exception message.</param>
        /// <param name="messageBoxType">Type of the message box.</param>
        /// <param name="messageButtonType">Type of the message button.</param>
        /// <returns>
        /// DialogResult value
        /// </returns>
        private static DialogResult ShowMessage(string message, string exceptionMessage,
            MessageBoxIcon messageBoxType, MessageBoxButtons messageButtonType)
        {
            DialogResult result = MessageBox.Show(message, exceptionMessage, messageButtonType, messageBoxType);

            return result;
        }

        /// <summary>
        /// Shows the error message box.
        /// </summary>
        /// <param name="parent">
        /// The parent window.
        /// </param>
        /// <param name="message">
        /// The message to be displayed.
        /// </param>
        /// <returns>
        /// One of the <see cref="System.Windows.Forms.DialogResult"/> values.
        /// </returns>
        public static DialogResult ShowError(IWin32Window parent, string message)
        {
            return MessageBox.Show(parent,
                message,
                Application.ProductName,
                MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1);
        }

        /// <summary>
        /// Shows the information message box.
        /// </summary>
        /// <param name="parent">
        /// The parent window.
        /// </param>
        /// <param name="message">
        /// The message to be displayed.
        /// </param>
        /// <returns>
        /// One of the <see cref="System.Windows.Forms.DialogResult"/> values.
        /// </returns>
        public static DialogResult ShowInformation(IWin32Window parent, string message)
        {
            return MessageBox.Show(parent,
                message,
                Application.ProductName,
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);
        }

        /// <summary>
        /// Shows the warning message box.
        /// </summary>
        /// <param name="parent">
        /// The parent window.
        /// </param>
        /// <param name="message">
        /// The message to be displayed.
        /// </param>
        /// <returns>
        /// One of the <see cref="System.Windows.Forms.DialogResult"/> values.
        /// </returns>
        public static DialogResult ShowWarning(IWin32Window parent, string message)
        {
            return MessageBox.Show(parent,
                message,
                Application.ProductName,
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button1);
        }
    }
}
