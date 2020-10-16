using System;

namespace Hello_world_2
{
    class Program
    {
        

        static void Main(string[] args)
        {
            
            
         
        }
    
         static void uppgift_1B()

        { 
            double bredd = 9.6;
            double höjd = 5.4;
            double area;
            area = bredd * höjd / 2;
            Console.WriteLine("triangel");
            Console.WriteLine("bredd: " + bredd);
            Console.WriteLine("höjd: " + höjd);
            Console.WriteLine("area: " + area);
            Console.WriteLine();
            
            
        }

        static void uppgift_1C()

        {

            double b;

            double h;


            Console.WriteLine("Vilken bredd?");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("vilken höjd?");
            h = Convert.ToDouble(Console.ReadLine());



            

            double area = (b * h) / 2;
            Console.WriteLine(area);
            Console.ReadLine();
        }
    
    
        static void uppgift_1D()

        {
           
            Console.WriteLine("Skriv ett tal");
            string tal1 = Console.ReadLine();
            int tal11=int.Parse(tal1);
            Console.WriteLine("Skriv ett tal till");
            string tal2 = Console.ReadLine();
            int tal22=int.Parse(tal2);
            Console.WriteLine("Summan blir: " + (tal11 + tal22));
            Console.ReadKey();
        } 
    
    
        static void uppgift_2A()

        {
        
           Random randomObjekt = new Random();
            int slumpatTal = randomObjekt.Next(1, 11);
            Console.Write("Gissa mitt favorit tal ");
            string indata = Console.ReadLine();
            int gissatTal = Convert.ToInt32(indata);
            if (gissatTal == slumpatTal)
            {
            Console.WriteLine("Rätt gissat!");
            }
            else
            {
            Console.WriteLine("Du gissade fel! Rätt tal är: " + slumpatTal);
            }
            Console.ReadLine();
    
        }
    
    
    


        static void uppgift_2B()

        {
            Random rg1 = new Random();
            Random rg2 = new Random();
            int aö1 = rg1.Next(1, 7);
            Console.WriteLine(aö1);
            int aö2 = rg2.Next(1, 7);
            Console.WriteLine(aö2);
            if(aö1 == aö2)
            {
                Console.WriteLine("samma");
            }
                else
            {
                Console.WriteLine("fel");
            }

        }



        static void uppgift_3A()
        {
            int räknare = 1;
         while (räknare <6)
            {
             Console.WriteLine("" + räknare);
             räknare = räknare + 1;
        
            } 
            Console.WriteLine();
        }
        
        
        static void uppgift_3B()
        {
            int räknare = 5;
         while (räknare <21)
            {
             Console.WriteLine("" + räknare);
             räknare = räknare + 3;
        
            } 
            Console.WriteLine();
        }
    



        static void uppgift_3C()

        {
            int räknare = 10;
         while (räknare >-1)
            {
             Console.WriteLine("" + räknare);
             räknare = räknare - 1;
        
            } 
            Console.WriteLine();
        }




        static void uppgift_4A()

        {
            for (int i = 1; i < 6; i = i + 1)
            {
                Console.WriteLine("" + i);
            }
        }





        static void uppgift_4B()

        {
            for (int i = 5; i < 21; i = i + 3)
            {
                Console.WriteLine("" + i);
            }
        }






        static void uppgift_4C()

        {
            for (int i = 10; i > -1; i = i - 1)
            {
                Console.WriteLine("" + i);
            }
        }






        static void uppgift_5()

        {
            Console.WriteLine("Gissa ett tal!");
            string svar;
            svar = Console.ReadLine();
            while(svar != "15")
            {
                Console.WriteLine("Gissa igen!");
                svar = Console.ReadLine();
            }

            {
                Console.WriteLine("Du gissade rätt!");
            }
    
        }



        static void uppgift_6()

        {
            Random rg1 = new Random();
            Random rg2 = new Random();
            int aö1 = rg1.Next(1, 7);
            Console.WriteLine(aö1);
            int aö2 = rg2.Next(1, 7);
            Console.WriteLine(aö2);
            if(aö1 == 6 && aö2 == 6)
            {
                Console.WriteLine("Storvinst!!!!");
            }
                else if(aö1 == aö2)
            {
                Console.WriteLine("Liten vinst");
            }
            else 
            {
                Console.WriteLine("Förlust");
            }
        }




        static void uppgift_7()

        {
            int [] tal = new int [6];
            tal[0] = 3;
            tal[1] = 5;
            tal[2] = 7;
            tal[3] = 9;
            tal[4] = 11;
            tal[5] = 13;
        }








    }
}