using System;

namespace laba1_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int q = 0;
            int m = 1000;
            for(int n=0;n<m;n++)
            {
                if(n%3==0 || n%5==0 )
                {
                    Console.WriteLine(n);
                    
                    q += n;
                    
                }
                
            }
            Console.WriteLine(q);
        }
        
    }
}
