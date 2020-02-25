using System;

namespace spiral
{
    class MainClass
    {
        public static string space(int n,int max=3)
        {
            int r = 0;
            if (n == 0)
                r = 1;
            else
                while (n > 0)
                {
                    n /= 10;
                    r++;
                 }
            string res = "";
            for (int i = 0; i < max - r; i++)
                res += " ";
            return res;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("n= ");
            int p = 1;
            int ax = 1;
            int bx = -1;
            int dx = 0;
            int si = 1;
            int dl;

            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n*n];

            int cx = n;
        
            dl = -cx;
            while (cx > 0)
            {
                for(int i = 0; i < cx; i++)
                {
                    bx += ax;
                    a[bx] = p;
                    p++;
                }
                if ( dx == 0)
                {
                    cx--;
                    dx++;
                    dl = -dl;
                    ax = dl;
                }
                else
                {
                    si = -si;
                    ax = si;
                    dx--;
                }
            }

            for (int i = 0; i < n; i++){
                Console.WriteLine();
                for (int j = 0; j < n; j++)
                    Console.Write(a[i * n + j] + space(a[i*n +j]));
            }
         
        }
    }
}
