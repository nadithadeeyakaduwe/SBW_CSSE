using SBW.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SBW.UI.Common
{
    public class ValidationHelper
    {
        public static bool IsValidNIC (string NIC)
        {
            bool isValidNIC = false;
            string pattern = @"^([0-9]{9})([vV])?$";

            if (Regex.IsMatch(NIC, pattern))
            {
                isValidNIC = true;
            }

            return isValidNIC;
        }

        public static bool IsValidEmail (string email)
        {
            bool isValidEmail = false;
            string pattern = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";

            if (Regex.IsMatch(email, pattern))
            {
                isValidEmail = true;
            }

            return isValidEmail;
        }

        public static bool IsOkToRecruite (DateTime dateOfBirth)
        {
            bool isOkToRecruite = false;
            DateTime cyear = DateTime.Now;
            int age = cyear.Year - dateOfBirth.Year;

            if (age > 17 && age < 55)
            {
                isOkToRecruite = true;
            }
            else
            {
                isOkToRecruite = false;
            }

            return isOkToRecruite;
        }

        /// <summary>
        /// Determines whether the specified letter is digit.
        /// </summary>
        /// <param name="letter">The letter.</param>
        /// <returns>
        ///   <c>true</c> if the specified letter is digit; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsDigit(char letter)
        {
            bool isDigit = true;

            if (!Char.IsDigit(letter) && letter != 8)
            {
                isDigit = false;
            }

            return isDigit;
        }

        /// <summary>
        /// Determines whether [is money text box] [the specified letter].
        /// </summary>
        /// <param name="letter">The letter.</param>
        /// <param name="text">The text.</param>
        /// <returns>
        ///   <c>true</c> if [is money text box] [the specified letter]; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsMoneyTextBox(char letter, string text)
        {
            bool isMoneyTextBox = false;
            string pattern = @"^(\d)+(\.\d{1,2})?$"; // accepts strings like in the format of 1234.12
            int indexOftheDecimal = text.LastIndexOf('.'); 

            if(letter != 8) //8 = Backspace
            {
                text += letter;
            }

            if (!string.IsNullOrWhiteSpace(text))
            {
                if (IsDigit(letter) || letter == 46 || letter == 8) // 46 = decimal point
                {
                    if ((letter == 46 && indexOftheDecimal == -1 && text.Length > 1) || (letter == 8 && text.Last() == '.'))
                    {
                        isMoneyTextBox = true;
                    }
                    else
                    {
                        isMoneyTextBox = Regex.IsMatch(text, pattern);
                    }
                }
            }

            return isMoneyTextBox;
        }
    }
}
