using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decimal_to_Binary_and_vise_versa
{
    class Program
    {
        private static bool BinaryConversionMain()
        {

            Console.Clear();
            Console.WriteLine("---------------------------Decimal/Binary Vise Versa Converter-------------------------\n" );
            
            Console.WriteLine("For Decimal to Binary conversion, Press '1': ");
            Console.WriteLine("For Binary to Decimal conversion, Press '2': \n");
            Console.WriteLine("To 'Exit', press '3'");

            switch(Console.ReadLine())
            {
                case "1":
                    
                    string DecimalToBinaryResult = DecimalToBinary();
                    Console.Write("\nThe converted Binary number is: ");
                    Console.WriteLine(DecimalToBinaryResult);
                    Console.WriteLine("Press a kay to return to main menu");
                    Console.ReadKey();
                    return true;
                case "2":                    
                    int BinaryToDecimalResult = BinaryToDecimal();
                    Console.Write("\nThe converted Decimal number is: ");
                    Console.WriteLine(BinaryToDecimalResult);
                    Console.WriteLine("Press a key to return to main menu");
                    Console.ReadKey();
                    return true;
                case "3":
                    return false;
                default:
                    return true;

            }

        }
        private static string DecimalToBinary()
        {

            Console.Clear();
            Console.Write("Decimal to Binary conversion: \n");
            Console.WriteLine("-------------------------------");
            Console.Write("Enter Decimal Number: ");
            int decimalNumber = Convert.ToInt32(Console.ReadLine());            
            string binaryFinal = Convert.ToString(decimalNumber, 2);
            return binaryFinal;

            
        }


        private static int BinaryToDecimal()
        {
            Console.Clear();
            Console.WriteLine("Binary to Decimal conversion: \n");
            Console.WriteLine("-------------------------------");
            Console.Write("Enter Binary Number: ");
            int binaryNumber = Convert.ToInt32(Console.ReadLine());
            int decimalNumber = BinaryToDecimalCalculation(binaryNumber);
            return decimalNumber;
        }

        private static int BinaryToDecimalCalculation(int binaryNumber)
        {
            int flag, remainValue, decimalFromBinary;
            flag = 1;
            decimalFromBinary = 0;

            while (binaryNumber > 0)
            {
                remainValue = binaryNumber % 10;
                binaryNumber = binaryNumber / 10;
                decimalFromBinary += remainValue * flag;
                flag = flag * 2;

            }
            return decimalFromBinary;
        }

        static void Main(string[] args)
            
        {
            //bool displayMenu = true;
            //   while (displayMenu)
            //    {
            //    displayMenu = BinaryConversionMain();
                
            //}
            //while (BinaryConversionMain() == true);
            while (BinaryConversionMain());



        }
    }
}
