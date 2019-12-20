using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputInt = 0;
            double inputDouble = 0.0;
            string input = "";
            string[] inputArray;
            Console.WriteLine("10進制轉2進制");
            Console.Write("輸入數字: ");
            input = Console.ReadLine();
            inputArray = input.Split('.');
            try
            {
                if (inputArray.Length == 2)
                {
                    inputInt = Convert.ToInt32(inputArray[0]);
                    inputDouble = Convert.ToDouble(inputArray[1].Insert(0, "0."));
                    Console.WriteLine(input + " = " + BinaryInt(inputInt) + "." + BinaryDouble(inputDouble));
                }
                else if (inputArray.Length == 1)
                {
                    inputInt = Convert.ToInt32(inputArray[0]);
                    Console.WriteLine(input + " = " + BinaryInt(inputInt));
                }
                else
                {
                    Console.WriteLine("輸入錯誤");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("輸入錯誤");
            }
            catch (Exception)
            {
                Console.WriteLine("輸入錯誤");
            }
            finally
            {
                Console.ReadKey();
            }
        }
        static string BinaryInt(int inputInt)
        {
            string binaryInt = "";
            if (inputInt == 0)
            {
                return "0";
            }
            while (inputInt != 0)
            {
                binaryInt = binaryInt.Insert(0, Convert.ToString(inputInt % 2));
                inputInt /= 2;
            }
            return binaryInt;
        }
        static string BinaryDouble(double inputDouble)
        {
            string binaryDouble = "";
            for (int i = 0; i < 50; i++)
            {
                inputDouble *= 2;
                string[] binaryDoubleArray = Convert.ToString(inputDouble).Split('.');
                binaryDouble += binaryDoubleArray[0];
                if (binaryDoubleArray.Length == 2)
                {
                    inputDouble = Convert.ToDouble(binaryDoubleArray[1].Insert(0, "0."));
                }
                else
                {
                    break;
                }
            }
            return binaryDouble;
        }
    }
}
