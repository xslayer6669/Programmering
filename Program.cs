using System;
using System.Collections.Generic;

namespace frågesport
{
    class QuestionCard
    {
        public String question;
        public String answer;
    }
    class Program
    {
        static void Main(string[] args)
        {            
            
        }
    
    
        static void uppgift1()
        {
            Console.WriteLine("Vad heter jag?"); 
            string svar; 
            svar = Console.ReadLine(); 
            while(svar != "Erik") 
            { 
            Console.WriteLine("Fel"); 
            svar = Console.ReadLine(); 
            }
            
            Console.WriteLine("vad är sveriges huvudstad");
            string svar1;
            svar1 = Console.ReadLine();
            while(svar1 != "stockholm")
            {
                Console.WriteLine("Fel");
                svar1 = Console.ReadLine();
            }

            Console.WriteLine("hur gammal är jag");
            string svar2;
            svar2 = Console.ReadLine();
            while(svar2 != "20")
            {
                Console.WriteLine("fel");
                svar2 = Console.ReadLine();
            }


        }
    
    
        static void uppgift2()
        {
            string [] frågor = new string [3];
            frågor[0] = "vad heter jag";
            frågor[1] = "vad är sveriges huvudstad";
            frågor[2] = "hur gammal är jag";

            string [] svar3 = new string [3];
            svar3[0] = "Erik";
            svar3[1] = "stockholm";
            svar3[2] = "20";

            for (int i = 0; i < 3; i = i + 1)
            {
                Console.WriteLine(frågor[i]);
                while (svar3[i] != Console.ReadLine()) 
                {
                  Console.WriteLine ("fel");
                   
                }
                Console.WriteLine("rätt");
            }
        
        
        
        
        }
    

        static void uppgift3()
        {
            List<string> minLista;
        minLista = new List<string>();
        minLista.Add("vad heter jag?");
        minLista.Add("hur gammal är jag?");
        minLista.Add("vad är sveriges huvudstad?");

        List<string> minlista2;
        minlista2 = new List<string>();
        minlista2.Add("Erik");
        minlista2.Add("20");
        minlista2.Add("Stockholm");
         
        for (int i = 0; i < 3; i = i + 1)
        {
            Console.WriteLine(minLista[i]);
            while (minlista2[i] != Console.ReadLine()) 
            {
                Console.WriteLine ("fel");
                
            }
            Console.WriteLine("rätt");
        }
        }


        static void uppgift4()
        {
            List<QuestionCard>min;
            min = new List<QuestionCard>();
            QuestionCard card;
            card = new QuestionCard();
            card.question = "Vad heter jag?";
            card.answer = "Erik";
            min.Add(card);

            QuestionCard card1;
            card1 = new QuestionCard();
            card1.question = "Vad är sveriges huvudstad?";
            card1.answer = "Stockholm";
            min.Add(card1);

            QuestionCard card2;
            card2 = new QuestionCard();
            card2.question = "hur gammal är jag?";
            card2.answer = "20";
            min.Add(card2);
        }
    }
}
