using System;

namespace mario
{
    class Program
    {
        static void Main(string[] args)
        {
          String cad="";
          String cad2="";
          int a,w,y;
          Console.WriteLine(" ****--  Escriba el numero de longitud de tu piramide :v --**** ");
          a = Convert.ToInt32(Console.ReadLine());
          for(y=1;y<a+1;y++)
          {
              cad = "";
              for(w=1;w<y+1;w++)
              {
                  cad=cad+"#";
              }
              System.Console.WriteLine(cad.PadLeft(a));
             // cad=cad+"\n";
          }
          
          System.Console.WriteLine(cad);

          //aquiva el otro for para la inversa
          Console.WriteLine(" ****--  Escriba el numero de longitud de tu piramide :v --**** ");
          a = Convert.ToInt32(Console.ReadLine());
          for(y=1;y>a+1;y++)
          {
              cad = " ";
              for(w=1;w>y+1;w++)
              {
                  cad2=cad2+"#";
              }
              System.Console.WriteLine(cad2.PadLeft(a));
              //cad=cad+"\n";
          }

          Console.WriteLine(cad+cad2);
          
          Console.WriteLine("** GRACIAS POR USAR EL PROGRAMA **");

        }
    }
}
