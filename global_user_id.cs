using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Army_Vechical_Entry
{
    static class global_user_id
    {
            private static int _globalVar = 0;

            public static int GlobalVar
            {
                get { return _globalVar; }
                set { _globalVar = value; }
            }
        
    }
}
