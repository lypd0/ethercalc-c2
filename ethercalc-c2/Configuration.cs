using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ethercalc_c2
{
    internal class Configuration
    {
        /// <summary>
        /// Ethercalc Spreadsheet Settings
        /// </summary>
        public static string ETHERCALC_ID = "2v292sn7860a";      // The ID assigned to your sheet
        public static int ETHERCALC_SHEET = 1;                   // The sheet number (1, 2, 3, 4) - Default 1

        /// <summary>
        /// Agent Settings
        /// </summary>
        public static int CHECKIN_DELAY = 10000;                 // 1000 = 1s (Default 30s)
        public static bool USE_ENCRYPTION = true;                // Enabled by default.
        public static string ENCRYPTION_KEY = "owM91BnA";        // Make as secure as you wish.
    }
}
