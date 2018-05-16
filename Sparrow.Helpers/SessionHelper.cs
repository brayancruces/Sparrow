using System.Collections.Generic;

namespace Sparrow.Helpers
{
    public static class SessionHelper
    {
        public static int? userID { get; set; }
        public static int? productID { get; set; }
        public static string accion { get; set; }
        public static List<int> productsIDList { get; set; }
    }
}
