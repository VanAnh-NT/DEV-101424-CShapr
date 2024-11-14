namespace lab05_01
{
    internal class Program
    {
        /// <summary>
        /// Một số thao tác với mảng 1 chiều 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Khai báo mảng 1 chiều này 
            int[] arr = { 5, 8, 3, 0, 2, 1, 7, 8 };

            //Duyẹt từng phân tử của mảng và in ra phân tử 
            Console.WriteLine("Cac phân tử của mảng là: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("{0 }", arr[i]);
            }

            //Tìm phân tử lớn nhất này 
            int max = arr[0];
            for (int i = 0; i < arr.Length; i++) { 
                if (max < arr[i]) max = arr[i];
            }
            Console.WriteLine("\nPhần tử lớn nhất: " + max);

            //Kiểm tra mảng có đối xứng khoong 
            bool kt = true;
            for (int i = 0; i < arr.Length / 2; i++) {
                if (arr[i] != arr[arr.Length - 1 - i])
                { 
                    kt = false; break;
                }
            }

            if (kt)
                Console.WriteLine("Mảng đối xứng");
            else
                Console.WriteLine("Mảng không đối xứng");

        }
    }
}
