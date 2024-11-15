namespace Exercises_1
{
    internal class session07
    {
        private static void Main()
        {
            ex01();
        }


        /// <summary>
        /// Create an integermatrix N x M (N,M was prompted from user) randomly.
        //- Printthe matrix.
        //- Print the i th row/column. (i was prompted from user)
        //- Find the max value of the matrix.
        //- Find the min value of i
        //th row/col of the matrix.
        //- Transpose the matrix.
        //- Print the main/secondarydiagonal values of the matrix.
        /// </summary>
        static void ex01()
        {
            Console.Write("Ban muon nhap bao nhieu dong? ");
            int rows = int.Parse( Console.ReadLine());
            Console.Write("Ban muon nhap bao nhieu cot? ");
            int cols = int.Parse(Console.ReadLine());
            if (rows != cols)
            {
                Console.WriteLine("so cot phai bang so dong"); return;
            }
            int[,] a = new int[rows, cols];
            EnterArrayRandomly(a);
            PrintMatrix(a);

            Console.Write("Ban muon in cot thu bao nhieu? ");
            int indexcol = int.Parse(Console.ReadLine());
            Printith(a, indexcol);
            Console.WriteLine();

            Console.WriteLine("Ma tran chuyen vi la ");
            transpose(a);
            PrintMatrix(a);

            Console.WriteLine("Duong cheo chinh la ");
            maindiagonal(a);


            Console.WriteLine("Duong cheo phu la ");
            secondarydiagonal(a);
  

        }
        static void secondarydiagonal(int[,] a)
        {
            for (int i = 0; i< a.GetLength(0); i++)
            {
                for (int j = 0; j< a.GetLength(1); j++)
                {
                    if ( i+ j == a.GetLength(0) )
                    {
                        Console.WriteLine(a[i,j]+"\t");
                    }
                }
            }
        }
        static void maindiagonal(int[,] a)
        {
            for (int i = 0; i< a.GetLength(0); i++)
            {
                for (int j=0; j< a.GetLength(1); j++)
                {
                    if (i==j)
                    {
                        Console.WriteLine(a[i, j] + "\t");
                    }
                }
            }
        }
            static void transpose(int[,] a)
            {
                for (int i = 0; i < a.GetLength(0); i++)
                {
                    for (int j = 0; j < a.GetLength(1); j++)
                    {
                        a[j, i] = a[i, j];
                    }
                }
            }
            static void Printith(int[,] a, int indexcol)
            {
                if (indexcol < 0 || indexcol > a.GetLength(0))
                {
                    Console.WriteLine("So cot phai lon hon 0 va nho hon so luong cot da nhap o tren");
                }
                else
                {
                    for (int i = 0; i < a.GetLength(0); i++)
                    {
                        Console.WriteLine($"{a[i, indexcol - 1]}\t");
                    }
                }
            }
            static void PrintMatrix(int[,] a)
            {
                for (int i = 0; i < a.GetLength(0); i++)
                {
                    for (int j = 0; j < a.GetLength(1); j++)
                    {
                        Console.Write(a[i, j] + "\t");
                    }
                    Console.WriteLine();

                }
            }
            static void EnterArrayRandomly(int[,] a)
            {
                Random random = new Random();
                for (int i = 0; i < a.GetLength(0); i++)
                    for (int j = 0; j < a.GetLength(1); j++)
                    {
                        a[i, j] = random.Next(100);
                    }

            }

        }
    }
