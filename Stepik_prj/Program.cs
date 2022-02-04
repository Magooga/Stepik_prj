using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Stepik_prj
{
    class Stepik
    {
        private static int prv = 10;

        int prv1 = 11;

        public int pbl = 10;

        public static int stpbl = 0;

        int[] arr = new int[4] {1, 2, 3, 4 };

        string str;

        public string change()
        {
            string str1 = "ggh";
            str1 = str1 + "hjkhj";

            return str1;
        }

        public static int getStep()
        {
            
            return stpbl;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Stepik st = new Stepik();
            

            Stepik.stpbl = 1;

            Stepik.getStep();
            

            Console.WriteLine("Hollow wax!!!");

            int intNumber;
            double d = 11.12;

            checked
            {
                intNumber = (int)d;
            }
            

            var perem = 1.0f;

            intNumber = int.Parse("234");

            int[] arr = new int[]{1, 2, 3};

            int il = arr.Length;
         

            foreach (var i in arr)
            {
               int j = i + 23;
            }

            List<int> l = new List<int>();
            l.Add(1);

            Dictionary<string, int> dic = new Dictionary<string, int>();
            dic["ab"] = 1;

            Convert.ToInt32("23");

            List<string> str = new List<string>();

            

            str.Add("gggg");

            int a = 1;
            object b = a;
            int c = (int)b;                     
        }
    }
}
