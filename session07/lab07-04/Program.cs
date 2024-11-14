﻿namespace lab07_04
{
    public class InvalidInputNumber : Exception
    { 
        public InvalidInputNumber() : base("Hay nhap mot so > 0") { }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int intCnt;
            int intNum = 0;
            Console.Write("Nhap mot so: ");
            //Nhap va tung ngoai le
            try
            {
                intNum = Convert.ToInt32(Console.ReadLine());
                if (intNum <= 0)
                {
                    throw new InvalidInputNumber();
                }
            }
            catch (InvalidInputNumber objInvalidInput)
            {
                Console.WriteLine(objInvalidInput.Message);
            }
            catch (System.FormatException objFormatException)
            {
                Console.WriteLine(objFormatException.Message);
            }
            finally 
            {
                if (intNum > 0)
                { 
                    for (intCnt = 1; intCnt <= 10; intCnt++)
                        Console.WriteLine(intCnt * intNum);
                }
            }
            Console.ReadLine();
        }
    }
}
