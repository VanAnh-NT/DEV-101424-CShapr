namespace lab05_02
{
    internal class Program
    {
        /// <summary>
        /// Chương trình inh họa một số thao tác trên mảng 2 chiều 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //khai báo và khởi tạo mảng hai chiều là có thêm dấu , nằm trong [] nhé 
            int[,] arr = {
                {4, 9, 6}, 
                {2, 6, 8}, 
                {5, 6, 3}, 
                {4, 2, 1}, 
                {8, 7 ,4}, 
                {3, 3, 2}
            };

            //duyệt mảng và in theo hàng cột 
            Console.WriteLine("Nội dung mảng: ");
            for (int i = 0; i <= arr.GetUpperBound(0); i++)
            { 
                Console.WriteLine();
                for (int j = 0; j <= arr.GetUpperBound(1); j++)
                { 
                    Console.Write(" {0}", arr[i,j]);
                }
                Console.WriteLine();
            }
            //Tìm các phân tử có chỉ số hằng bằng chỉ số cột 
            Console.WriteLine("Cac phan tu co so hang bang so cot la: ");
            for (int i = 0; i <= arr.GetUpperBound(0); i++) {
                for (int j = 0; j <= arr.GetUpperBound(1); j++)
                { 
                    if (i == j)
                    {
                        Console.WriteLine(" {0}", arr[i, j]);
                    }
                }
            }

            //Cac phan tu lon nhat tren hang 
            Console.WriteLine("Cac phan tu lon nhat tren mot hang: ") ;
            for (int i = 0; i <= arr.GetUpperBound(0); i++)
            {
                int max = arr[i, 0];
                for (int j = 0; j <= arr.GetUpperBound(1); j++)
                { 
                    if (max < arr[i, j]) max = arr[i, j];
                }
                Console.WriteLine("hang {0}: {1}", i, max) ;
            }
        }
    }
}
