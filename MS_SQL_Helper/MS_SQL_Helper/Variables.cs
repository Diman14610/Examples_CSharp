using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS_SQL_Helper
{
    class Variables
    {
        /* Params for Form1 */
        public static int Width { get; set; }
        public static int Height { get; set; }
        public static int Top { get; set; }
        public static int Left { get; set; }


        /* Params for Form2 */
        public static bool PK { get; set; }
        public static bool AI { get; set; }

        public static string[] CollectionTypesSQL = { "INT","SMALLINT", "TINYINT", "DATE()", "MONEY()", "NVARCHAR()" };


        /* Params for ReleationShip */
        public static int MaxHeight { get; set; }
        public static string PK_FK { get; set; }


        /* Params for CreateTableFC */
        public static string[] CollectionTypesCsharp =  { "int", "string" };
    }
}
