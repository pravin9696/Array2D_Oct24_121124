namespace Array2D_Oct24_121124
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //single D Array

            //int[]a=new int[5];

            //int[] a = new int[5];

            
            //Console.WriteLine("enter 5 elements");

            //for (int i = 0; i <= a.Length-1; i++)
            //{
            //    a[i]=int.Parse(Console.ReadLine()); 
            //}

            //Console.WriteLine("All elements of Array");

            //for(int i = 0;i < a.Length; i++)
            //{
            //    Console.WriteLine(a[i]);
            //}



            ////1 
            //int[] b = new int[] { 33,22,11,88,99};
            ////Console.WriteLine(b.Length);
            //int[] c = { 1111, 2222, 3333, 4444 };
            //for (int i = 0; i < c.Length; i++)
            //{
            //    Console.WriteLine(c[i]);
            //}

            //string[] strArray=new string[] {"aa","bbb","ccc" };
            //Console.WriteLine(strArray.Length);
            //string[] st2 = { "pune", "nshik", "nagar" };
            //Console.WriteLine(st2.Length);
            //for (int i = 0; i < st2.Length; i++)
            //{
            //    Console.WriteLine(st2[i]);
            //}


            //Multi Diamential Array

            //fixed size MD Array

            //syntax

            //Data type [ , ]array_name=new Data type[size,colsize];

            //int[,] intAr = new int[5,4];

            //Console.WriteLine("length="+intAr.Length);
            //Console.WriteLine(intAr.GetLength(0));//for row
            //Console.WriteLine(intAr.GetLength(1));//for column

            //for (int i = 0; i < intAr.GetLength(0); i++)
            //{
            //    Console.WriteLine("Enter elements");
            //    for (int j = 0; j < intAr.GetLength(1); j++)
            //    {
            //        intAr[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //Console.WriteLine("All elements from Array:");

            //for (int i = 0; i < intAr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < intAr.GetLength(1); j++)
            //    {
            //        Console.Write(" " + intAr[i,j]);
            //    }
            //    Console.WriteLine();
            //}

            //Jagged MD Array

            //data type [][]arra_name=new data_type[size][];
            int[][] ar3 = new int[3][];

            Console.WriteLine("ar3.Getlength(0)="+ar3.GetLength(0));
            for (int i = 0; i < ar3.GetLength(0); i++)
            {
                Console.WriteLine("enter size of column:");
                int size = int.Parse(Console.ReadLine());
                ar3[i] = new int[size];

                Console.WriteLine("enter elements");
                for (int j = 0; j < ar3[i].Length; j++)
                {
                    ar3[i][j] = int.Parse(Console.ReadLine());
                }                
            }

            Console.WriteLine("Jagged Array Elements are:");

            for (int i = 0; i < ar3.GetLength(0); i++)
            {
                for (int j = 0; j < ar3[i].Length; j++)
                {
                    Console.Write(" " + ar3[i][j]);
                }
                Console.WriteLine();
            }
        }
    }
}
