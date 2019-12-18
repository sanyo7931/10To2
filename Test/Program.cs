using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            double z;
            string input= Console.ReadLine();
            string Inty = "";
            string Doubley = "";
            string[] inputArray = input.Split('.');
            if (inputArray.Length==2)
            {
                x = Convert.ToInt32(inputArray[0]);
                z = Convert.ToDouble(inputArray[1].Insert(0, "0."));
            }
            else
            {
                x = Convert.ToInt32(inputArray[0]);
                z = 0;
            }


            while(x!=0)
            {
                Inty = Inty.Insert(0,Convert.ToString(x % 2));
                x = x / 2;
            }
            for (int i=0;i<50;i++)
            { 
                z = z * 2;
                string[] DoubleyArray = Convert.ToString(z).Split('.');
                Doubley = Doubley + DoubleyArray[0];
                if (DoubleyArray.Length==2)
                {
                    z = Convert.ToDouble(DoubleyArray[1].Insert(0, "0."));
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(Inty+"."+Doubley);
        }
    }
}
