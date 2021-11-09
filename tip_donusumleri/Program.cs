using System;

namespace tip_donusumleri
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Implicit Conversion");
            //Implicit Conversion (Bilincsiz Donusum)
            byte a = 5;
            sbyte b =30;
            short c=10;

            int d=a+b+c;
            Console.WriteLine("d:"+d);
            //Explicit Conversion
            Console.WriteLine("Explicit Conversion");
            int x =4;
            byte y = (byte)x;
            Console.WriteLine("y:"+y);

            //*** ToString Methodu ***
            Console.WriteLine("*** ToString Methodu ***");
            int xx=6;
            string yy=xx.ToString();
            Console.WriteLine("yy: "+yy);
            
            //System.Convert
            Console.WriteLine("*** System.Convert sınıfı ***");
            string s1="10",s2="20";
            int sayi1, sayi2;
            int Toplam;

            char v='v';
            Console.WriteLine(v);
            Console.WriteLine(Convert.ToInt32(v));
            


            sayi1=Convert.ToInt32(s1);
            sayi2=Convert.ToInt32(s2);

            Toplam=sayi1+sayi2;
            Console.WriteLine(Toplam);

            //Parse
            Console.WriteLine("***Parse Metodu***");
            ParseMethod();
            }
        public static void ParseMethod(){
            string metin1="10";
            string metin2="10,25";
            int rakam1;
            double double1;

            rakam1=Int32.Parse(metin1);
            double1=Double.Parse(metin2);

            Console.WriteLine("rakam1 :"+rakam1);
            Console.WriteLine("double1 :"+double1);
            Console.WriteLine(double1*3);
        }
    }
    
}
