using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOdev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //str
            string name;
            name = "İsmail";
            Console.WriteLine(name);

            string name2;
            name2 = Console.ReadLine();
            Console.WriteLine("Your name: " + name2);

            //int int16 int32 int64 int.parse()
            int num1;
            int num2;
            int num3;
            string result;


            num1 = 1;
            num2 = 12;
            num3 = num2 * num1;
            result = num3.ToString();
            Console.WriteLine(result);


            int num4;
            string num5;

            num5 = "30";
            num4 = Convert.ToInt32(num5);
            Console.WriteLine(num4);

            //double
            double db1;
            double db2;
            double result2;

            db1 = 9.9;
            db2 = Double.Parse(Console.ReadLine());
            result2 = db1 * db2;
            Console.WriteLine(result2);



            //float
            float f1;
            float f2;
            float fresult;
            Console.WriteLine("Birinci değer:");
            f1 = float.Parse(Console.ReadLine());
            Console.WriteLine("İkinci değer:");
            f2 = float.Parse(Console.ReadLine());
            fresult = f1 * f2;
            Console.WriteLine(fresult);


            //decimal

            decimal d1;
            decimal d2;
            d1 = 5;
            d2 = 5;
            decimal d3 = d1 / d2;
            Console.WriteLine(d3);

            //bool
            bool b1 = 10 < 3;
            bool b2 = 10 > 3;

            //object
            object o1 = 10;
            object o2 = "yaş";
            Console.WriteLine(o2 + " " + o1);

            //DateTime

            DateTime date = DateTime.Now;
            Console.WriteLine(date);

            string date2 = DateTime.Now.ToString("dd.mm.yyyy");
            string time = DateTime.Now.ToString("HH.mm");
            Console.WriteLine(date2);
            Console.WriteLine(time);


        }
    }
}
