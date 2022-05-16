using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linercebir
{
    class Program
    {

        static void Topla()
        {
            int a, b, c, d, mn;
            Console.Write("1. Matrisin Sutun  Sayısını Giriniz : ");
            a = Convert.ToInt16(Console.ReadLine());
            Console.Write("1. Matrisin Satır  Sayısını Giriniz : ");
            b = Convert.ToInt16(Console.ReadLine());
            Console.Write("2. Matrisin Sutun  Sayısını Giriniz : ");
            c = Convert.ToInt16(Console.ReadLine());
            Console.Write("2. Matrisin Satır  Sayısını Giriniz : ");
            d = Convert.ToInt16(Console.ReadLine());
            if (a == c && b == d)
            {

                int[,] A = new int[10, 10];

                Console.Write("\nBirinci matrisi giriniz :\n ");
                for (int i = 0; i < a; i++)
                {
                    for (int j = 0; j < b; j++)
                    {
                        Console.Write("[" + (i + 1) + "]:[" + (j + 1) + "] =");
                        A[i, j] = Convert.ToInt16(Console.ReadLine());
                    }
                }
                int[,] B = new int[10, 10];
                Console.Write("\nikinci matrisi giriniz:\n");
                for (int i = 0; i < c; i++)
                {
                    for (int j = 0; j < d; j++)
                    {
                        Console.Write("[" + (i + 1) + "]:[" + (j + 1) + "] =");
                        B[i, j] = Convert.ToInt16(Console.ReadLine());
                    }
                }
                Console.Clear();
                Console.WriteLine("\nBirinci matris :\n ");
                for (int i = 0; i < a; i++)
                {
                    for (int j = 0; j < b; j++)
                    {
                        Console.Write(A[i, j] + "\t");

                    }
                    Console.WriteLine();
                }



                Console.WriteLine("\nikinci matris:\n ");
                for (int i = 0; i < c; i++)
                {
                    for (int j = 0; j < d; j++)
                    {
                        Console.Write(B[i, j] + "\t");

                    }
                    Console.WriteLine();
                }

                int[,] C = new int[10, 10];
                for (int i = 0; i < a; i++)
                {
                    for (int j = 0; j < b; j++)
                    {
                        C[i, j] = A[i, j] + B[i, j];
                    }
                }
                Console.Write("\nToplam Matris :\n");
                for (int i = 0; i < a; i++)
                {
                    for (int j = 0; j < b; j++)
                    {
                        Console.Write(C[i, j] + "\t");

                    }
                    Console.WriteLine();
                }
                Console.Write("Menuye gitmek için : 1 \n");
                Console.Write("Bitirmek için: 2 \n");
                Console.Write("işlem giriniz Giriniz : ");
                mn = Convert.ToInt16(Console.ReadLine());

                if (mn == 1)
                {
                    Menu();
                }
                else
                {
                    Environment.Exit(0);
                }
            }
            else
            {
                Console.Clear();
                int m;
                Console.Write("\nMatris boyutları eşit olmalıdır:\n");

                Console.Write("Menuye gitmek için : 1 \n");
                Console.Write("Tekrar Girmek için: 2 \n");
                Console.Write("işlem giriniz Giriniz : ");
                m = Convert.ToInt16(Console.ReadLine());

                if (m == 1)
                {
                    Menu();
                }
                else
                {
                    Topla();
                }
            }

        }
        static void Cıkar()
        {
            int a, b, c, d, mn;
            Console.Write("1. Matrisin Sutun  Sayısını Giriniz : ");
            a = Convert.ToInt16(Console.ReadLine());
            Console.Write("1. Matrisin Satır  Sayısını Giriniz : ");
            b = Convert.ToInt16(Console.ReadLine());
            Console.Write("2. Matrisin Sutun  Sayısını Giriniz : ");
            c = Convert.ToInt16(Console.ReadLine());
            Console.Write("2. Matrisin Satır  Sayısını Giriniz : ");
            d = Convert.ToInt16(Console.ReadLine());
            if (a == c && d == b)
            {
                int[,] A = new int[10, 10];

                Console.Write("\nBirinci matrisi giriniz :\n ");
                for (int i = 0; i < a; i++)
                {
                    for (int j = 0; j < b; j++)
                    {
                        Console.Write("[" + (i + 1) + "]:[" + (j + 1) + "] =");
                        A[i, j] = Convert.ToInt16(Console.ReadLine());
                    }
                }
                int[,] B = new int[10, 10];
                Console.Write("\nikinci matrisi giriniz:\n");
                for (int i = 0; i < c; i++)
                {
                    for (int j = 0; j < d; j++)
                    {
                        Console.Write("[" + (i + 1) + "]:[" + (j + 1) + "] =");
                        B[i, j] = Convert.ToInt16(Console.ReadLine());
                    }
                }
                Console.Clear();
                Console.WriteLine("\nBirinci Matris:\n ");
                for (int i = 0; i < a; i++)
                {
                    for (int j = 0; j < b; j++)
                    {
                        Console.Write(A[i, j] + "\t");

                    }
                    Console.WriteLine();
                }
                Console.WriteLine("\nİkinci Matris:\n ");
                for (int i = 0; i < c; i++)
                {
                    for (int j = 0; j < d; j++)
                    {
                        Console.Write(B[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                int[,] C = new int[10, 10];
                for (int i = 0; i < a; i++)
                {
                    for (int j = 0; j < b; j++)
                    {
                        C[i, j] = A[i, j] - B[i, j];
                    }
                }
                Console.Write("\niki Matisin Farkı :\n");
                for (int i = 0; i < a; i++)
                {
                    for (int j = 0; j < b; j++)
                    {
                        Console.Write(C[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                Console.Write("Menuye gitmek için : 1 \n");
                Console.Write("Bitirmek için: 2 \n");
                Console.Write("işlem giriniz Giriniz : ");
                mn = Convert.ToInt16(Console.ReadLine());

                if (mn == 1)
                {
                    Menu();
                }
                else
                {
                    Environment.Exit(0);
                }
            }
            else
            {
                Console.Clear();
                int m;
                Console.Write("\nMatris boyutları eşit olmalıdır:\n");
                Console.Write("Menuye gitmek için : 1 \n");
                Console.Write("Tekrar Girmek için: 2 \n");
                Console.Write("işlem giriniz Giriniz : ");
                m = Convert.ToInt16(Console.ReadLine());

                if (m == 1)
                {
                    Menu();
                }
                else
                {
                    Cıkar();
                }
            }

        }
        static void Sayı()
        {
            int a, b, c, mn;
            Console.Write(" Matrisin Sutun  Sayısını Giriniz : ");
            a = Convert.ToInt16(Console.ReadLine());
            Console.Write(" Matrisin Satır  Sayısını Giriniz : ");
            b = Convert.ToInt16(Console.ReadLine());
          

            int[,] A = new int[10, 10];

            Console.Write("\n Matrisi giriniz :\n ");
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    Console.Write("[" + (i + 1) + "]:[" + (j + 1) + "] =");
                    A[i, j] = Convert.ToInt16(Console.ReadLine());
                }
            }
            Console.Write("Çarpılacak Sayıyı Giriniz : ");
            c = Convert.ToInt16(Console.ReadLine());

            int[,] B = new int[10, 10];
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    B[i, j] = A[i, j] * c;
                }
            }
            Console.Write("\n Sabit Sayı  Çarpım Sonucu :\n");
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    Console.Write(B[i, j] + "\t");

                }
                Console.WriteLine();
            }

            Console.Write("Menuye gitmek için : 1 \n");
            Console.Write("Bitirmek için: 2 \n");
            Console.Write("işlem giriniz Giriniz : ");
            mn = Convert.ToInt16(Console.ReadLine());

            if (mn == 1)
            {
                Menu();
            }
            else
            {
                Environment.Exit(0);
            }
        }
        static void Carpma()
        {
            int a, b, c, d, mn; ;
            Console.Write(" 1.Matrisin Satır  Sayısını Giriniz : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("1. Matrisin Sutun  Sayısını  : ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("2.Matrisin Satır  Sayısını Giriniz");
            c = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. Matrisin Sutun  Sayısını Giriniz: ");
            d = Convert.ToInt32(Console.ReadLine());
            int[,] A = new int[a, b];
            int[,] B = new int[c, d];
            int[,] C = new int[a, d];
            if (b == c)
            {
                Console.Write("\nBirinci matrisi giriniz :\n ");
                for (int i = 0; i < a; i++)
                {
                    for (int j = 0; j < b; j++)
                    {
                        Console.Write("[" + (i + 1) + "]:[" + (j + 1) + "] =");
                        A[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }
                Console.Write("\nikinci matrisi giriniz:\n");
                for (int i = 0; i < c; i++)
                {
                    for (int j = 0; j < d; j++)
                    {
                        Console.Write("[" + (i + 1) + "]:[" + (j + 1) + "] =");
                        B[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }

                for (int i = 0; i < a; i++)
                {
                    for (int j = 0; j < d; j++)
                    {
                        for (int z = 0; z < d; z++)
                        {
                            if (b >= z)
                            {
                                C[i, j] = C[i, j] + A[i, z] * B[z, j];
                            }
                        }
                    }
                }
                Console.Write("\n Sonuç : \n");

                for (int i = 0; i < a; i++)
                {
                    for (int j = 0; j < d; j++)
                    {
                        Console.Write(C[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
            }

            else
            {
                int m;
                Console.Write("\nBirinci Matrisin Sütün sayısı ikinci Matrisin Satır Sayısına Eşit Olmalıdır:\n");
                Console.Write("Menuye gitmek için : 1 \n");
                Console.Write("Tekrar Girmek için: 2 \n");
                Console.Write("işlem giriniz Giriniz : ");
                m = Convert.ToInt16(Console.ReadLine());

                if (m == 1)
                {
                    Menu();
                }
                else
                {
                    Carpma();
                }
            }
            Console.WriteLine();
            Console.Write("Menuye gitmek için : 1 \n");
            Console.Write("Bitirmek için: 2 \n");
            Console.Write("işlem giriniz Giriniz : ");
            mn = Convert.ToInt16(Console.ReadLine());

            if (mn == 1)
            {
                Menu();
            }
            else
            {
                Environment.Exit(0);
            }

        }

        static void Inv()
        {

            int a, b, mn;
            Console.Write(" Matrisin Sutun  Sayısını Giriniz : ");
            a = Convert.ToInt16(Console.ReadLine());
            Console.Write(" Matrisin Satır  Sayısını Giriniz : ");
            b = Convert.ToInt16(Console.ReadLine());
            if (a == b)
            {
                int k = 0, t = a + b;
                int[,] I = new int[10, 10];
                int[,] K = new int[10, 10];
                for (int i = 0; i < a; i++)
                {
                    for (int j = 0; j < b; j++)
                    {
                        I[i, j] = 0;

                    }
                    I[i, k] = 1;
                    k++;
                }
                int[,] A = new int[10, 10];

                Console.Write("\n Matrisi giriniz :\n ");
                for (int i = 0; i < a; i++)
                {
                    for (int j = 0; j < b; j++)
                    {
                        Console.Write("[" + (i + 1) + "]:[" + (j + 1) + "] =");
                        A[i, j] = Convert.ToInt16(Console.ReadLine());
                    }
                }
                for (int i = 0; i < a; i++)
                {
                    for (int j = 0; j < b; j++)
                    {
                        for (int z = 0; z < b; z++)
                        {

                            K[i, j] = K[i, j] + A[i, z] * A[z, j];
                        }

                    }
                }
                int f = 0;
                for (int i = 0; i < a; i++)
                {
                    for (int j = 0; j < b; j++)
                    {
                        if (K[i, j] == I[i, j])
                        {
                            f++;
                        }
                    }
                    Console.WriteLine();
                }
                if (f == t)
                {
                    Console.Write(" Matris involutiftir.\n");
                }
                Console.WriteLine();
                Console.Write("Menuye gitmek için : 1 \n");
                Console.Write("Bitirmek için: 2 \n");
                Console.Write("işlem giriniz Giriniz : ");
                mn = Convert.ToInt16(Console.ReadLine());

                if (mn == 1)
                {
                    Menu();
                }
                else
                {
                    Environment.Exit(0);
                }
            }
            else
            {
                int m;
                Console.Write("\n Matrisin Sütün sayısı  Satır Sayısına Eşit Olmalıdır:\n");
                Console.Write("Menuye gitmek için : 1 \n");
                Console.Write("Tekrar Girmek için: 2 \n");
                Console.Write("işlem giriniz Giriniz : ");
                m = Convert.ToInt16(Console.ReadLine());

                if (m == 1)
                {
                    Menu();
                }
                else
                {
                    Inv();
                }
            }


        }

        static void Tersi()

        {

            int a, b, mn;
            
            Console.Write(" Matrisin Sutun  Sayısını Giriniz : ");
            a = Convert.ToInt16(Console.ReadLine());
            Console.Write(" Matrisin Satır  Sayısını Giriniz : ");
            b = Convert.ToInt16(Console.ReadLine());
            if (a == b)
            {
                double[,] A = new double[a, b];
                double[,] AL = new double[a - 1, b - 1];
                double[,] AF = new double[a, b];
                double[,] AT = new double[a, b];
                double[,] AK = new double[a, b];
                Console.WriteLine("MATRİSİ GİRİNİZ ");
                for (int i = 0; i < a; i++)
                {
                    for (int j = 0; j < b; j++)
                    {
                        Console.Write("[" + (i + 1) + "]:[" + (j + 1) + "] =");
                        A[i, j] = Convert.ToInt16(Console.ReadLine());
                    }
                }
             
                if (DETHes(a,A)!=0)
                {
                    int k = 0, f = 0, l;
                    int z, x;
                    for (int r = 0; r < 2 * a; r++){
                        z = 0; x = 0;
                        for (int i = 0; i < a; i++) {
                            for (int j = 0; j < b; j++)   {
                                if (j != f && i != k)  {
                                    AL[z, x] = A[i, j];
                                    x++;
                                }
                            }
                            if (i != k) {
                                z++;
                                x = 0;
                            }
                        }
                        l = k + f;
                        AF[k, f] = Math.Pow(-1, l) * DETHes(a - 1, AL);
                        k++;
                        if (k == a) {
                            f++;
                            k = 0;
                        }
                    }
                    for (int i = 0; i < a; i++)
                    {
                        for (int j = 0; j < a; j++)
                        {
                            AK[i, j] = AF[j, i];
                        }
                    }
                            double g;
                    g = -1 / DETHes(a, A);
                    for (int i = 0; i < a; i++)
                    {
                        for (int j = 0; j < b; j++)
                        {
                            AT[i, j] = g * AK[i, j];
                        }
                    }
                 
                    Console.WriteLine("Matrisin Tersi");
                    for (int i = 0; i < a; i++)
                    {
                        for (int j = 0; j < a; j++)
                        {
                            if (double.IsNaN(AT[i, j]))
                            {
                                AT[i, j] = 0;
                            }

                          
                            Console.Write(AT[i, j] + "\t\t");
                        }
                        Console.WriteLine();
                    }

                }
                else
                {
                    Console.Write("DETERMİNANT 0 İSE TERSİ ALINAMAZ \n");
                }
            Console.WriteLine();
                Console.Write("Menuye gitmek için : 1 \n");
                Console.Write("Bitirmek için: 2 \n");
                Console.Write("işlem giriniz Giriniz : ");
                mn = Convert.ToInt16(Console.ReadLine());

                if (mn == 1)
                {
                    Menu();
                }
                else
                {
                    Environment.Exit(0);
                }
            }

            else
            {
                int m;
                Console.Write("\n Matrisin Sütün  Satır Sayısına Eşit Olmalıdır:\n");
                Console.Write("Menuye gitmek için : 1 \n");
                Console.Write("Tekrar Girmek için: 2 \n");
                Console.Write("işlem giriniz Giriniz : ");
                m = Convert.ToInt16(Console.ReadLine());

                if (m == 1)
                {
                    Menu();
                }
                else
                {
                    Tersi();
                }
            }
        }
        static double DETHes(int a, double[,] A)
        {
            double d = 0;
            int k, i, j, bi, bj;
            double[,] AltM = new double[a, a];
            if (a == 1)
            {
                return A[0, 0];
            }
            else if (a == 2)
            {
                return A[0, 0] * A[1, 1] - A[1, 0] * A[0, 1];
            }
            else
            {
                for (k = 0; k < a; k++)
                {
                    bi = 0;
                    for (i = 1; i < a; i++)
                    {
                        bj = 0;
                        for (j = 0; j < a; j++)
                        {
                            if (j == k)
                            {
                                continue;
                            }
                            AltM[bi, bj] = A[i, j];
                            bj++;
                        }
                        bi++;
                    }
                    d += Math.Pow(-1, k) * A[0, k] * DETHes(a - 1, AltM);
                }
            }
            return d;
        }
        static void Detal()
        {

            int a, mn;
            Console.Write("MATRİSİN SÜTÜN VE SATIR SAYISINI GİRİNİZ:");
            a = Convert.ToInt16(Console.ReadLine());
            double[,] A = new double[a, a];
            Console.WriteLine("MATRİSİ GİRİNİZ ");
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    Console.Write("[" + (i + 1) + "]:[" + (j + 1) + "] =");
                    A[i, j] = Convert.ToInt16(Console.ReadLine());
                }
            }
            Console.WriteLine("MATRİS\n");

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    Console.Write(" " + A[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("Determinant: " + DETHes(a, A));
            Console.WriteLine();
            Console.WriteLine("Menuye gitmek için : 1 ");
            Console.WriteLine("Bitirmek için: 2 ");
            Console.Write("işlem giriniz Giriniz : ");
            mn = Convert.ToInt16(Console.ReadLine());

            if (mn == 1)
            {
                Menu();
            }
            else
            {
                Environment.Exit(0);
            }
        }
        static void Menu()
        {
            Console.Clear();
            int m;
            Console.Write("1:iki Matrisi Topla \n");
            Console.Write("2:İki Matrısın Farkı \n");
            Console.Write("3:Sabit Sayı ile Çarp \n");
            Console.Write("4:İki Matrısı  Çarp \n");
            Console.Write("5:Determinant Al \n");
            Console.Write("6:İnvolütif bakma  \n");
            Console.Write("7:Tersini Al  \n");
            Console.Write("8:Programı Sonlandır...\n");
            Console.Write("Lütfen işlem giriniz Giriniz: ");
            m = Convert.ToInt16(Console.ReadLine());
            if (m == 1)
            {
                Console.Clear();
                Topla();
            }
            else if (m == 2)
            {
                Console.Clear();
                Cıkar();
            }
            else if (m == 3)
            {
                Console.Clear();
                Sayı();
            }
            else if (m == 4)
            {
                Console.Clear();
                Carpma();
            }
            else if (m == 5)
            {
                Console.Clear();
                Detal();

            }
            else if (m == 6)
            {
                Console.Clear();
                Inv();
            }
            else if (m == 7)
            {
                Console.Clear();
                Tersi();
            }
            else if (m == 8)
            {
                Environment.Exit(0);
            }
            else
            {
                Console.Clear();
                Console.Write("\nGeçersiz giriş..\n");
                Console.Write("\nLütfen tekrar giriniz..\n");
                Menu();

            }
        }
        static void Main(string[] args)
        {
            Menu();
            Console.Write("\nProgram sonlandırıldı!!\n ");
            Console.Write("\nÇıkmak için herangi bir  tuşa basınız..\n");
            Console.Read();
        }
    }
}

