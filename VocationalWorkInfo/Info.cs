using System;
using System.Collections.Generic;
using System.Text;

namespace InternetBar
{
    public class Info
    {
        private static string name;

        public static string Name
        {
            get { return Info.name; }
            set { Info.name = value; }
        }



        private static string pass;

        public static string Pass
        {
            get { return Info.pass; }
            set { Info.pass = value; }
        }

       


    }
}
