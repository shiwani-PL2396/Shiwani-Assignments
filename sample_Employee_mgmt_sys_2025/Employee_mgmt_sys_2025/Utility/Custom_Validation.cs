using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Employee_mgmt_sys_2025.Utility
{
    public class Custom_Validation
    {
        #region 1-Name Vakidation
        // Name should not be empty
        // Name should  cotain only letters , numbers , underscore & dot
        // ^[a-zA-Z0-9_.][a-zA-Z0-9_.]+$
        public static bool IsValidName(string name)
        {
         !string.IsNullOrWhiteSpace(name) &&
          name.IsLength <= 20 &&
         Regex.IsMatch(name, @"^[a-zA-Z]+ $");

            /*  
             *  ^ indicates the start of the string
             *  define the character set that allows
             *  a-z  Lowercase letters (a to z)
             *  A-Z  Uppercase letters (A to Z)
             *  0-9  digits (0 to 9)
             *  _   Underscore character
             *  .  Period / dot character
             
             @"^[a-zA-Z0-9_.][a-zA-Z0-9_.]+$"  
            + Means one or more occurence of the preceding charecter set . 
            Ensures that the name is not empty and contains at least one character.
            $: Indicates the end of the string.

            */

        }
    }
}
