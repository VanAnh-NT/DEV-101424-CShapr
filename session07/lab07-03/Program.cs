namespace lab07_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //khai bao mang
            byte[] a = new byte[5];

            //nhập mảng 
            try
            {
                for (int i = 0; 1 <= 5; i++)
                {
                    Console.Write("a[{0}]=", i + 1);
                    a[i] = Convert.ToByte(Console.ReadLine());
                }
            }
            catch (FormatException ex)
            {
                //Console.Write(ex.Message);
                Console.WriteLine("Không nhập được kí tự cho mang số");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Khong nhap duoc gia tri ngoai mien 0-255");
            }
            catch (IndexOutOfRangeException ex)
            { 
                Console.WriteLine("Loi vuot qua pham vi cua mang");
            }

            //in mang
            Console.WriteLine("Noi dung mang");
            for (int i = 0; i < 5; i++) {
                Console.Write(" {0}", a[i]);
            }
        }
    }
}
