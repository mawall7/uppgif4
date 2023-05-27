using System;
using System.Collections;
using System.Collections.Generic;

//Svar, resten av svaren se längre ner
//1.Heapen är en lagringsstruktur i minnet där allt är åtkomligt samtidigt, medan stackens objekt är staplade och bara det översta är åtkomligt. Stacken
//stacken håller ordningen själv dv.s. den är inbyggd, medan du behöver hålla koll på heapen så minnet ej blir fullt.

//2.Valuetypes är av typen bool, int char, sbyte osv. Lagrar då t.ex. true, false, heltal, enstakabokstäver, osv. och
//en värdetyp lagras alltid på samma ställe där den definieras, på antingen stacken eller heapen. 
//Referencetype lagras alltid på heapen och är t.ex. alla klassobjekt och strängobjekt, interface och delegater alltså 
//större objekt som nås via en pointer.  

//3.Eftersom i första är x och y valuetypes och y pekar alltså inte mot x, och säger man att x = y lagras bara värdet av x i y men x och y är inte 
//samma sak. alltså y är = x , men då är inte x = y. Har bara samma värde, men y kan då ändras utan att x gör det.
//I den andra är objekten referenstypes och nås via en pointer. Blir då samma dom pekar mot varandra. 

namespace SkalProj_Datastrukturer_Minne
{
    class Program
    {
        /// <summary>
        /// The main method, vill handle the menues for the program
        /// </summary>
        /// <param name="args"></param>
        static void Main()
        {

            while (true)
            {
                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice"
                    + "\n1. Examine a List"
                    + "\n2. Examine a Queue / icakö"
                    + "\n3. Examine Stack / ReverseText"
                    + "\n4. CheckParanthesis"

                    + "\n5. Reverse Text"
                    + "\n0. Exit the application");
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()[0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }
                switch (input)
                {
                    case '1':
                        ExamineList();
                        break;
                    case '2':

                        //Console.WriteLine("input:  + och skriv en sträng för att lägga till ny kund, - för att expediera, 3 = quit");
                        //var input5 = Console.ReadLine();

                        while (true)
                        {
                            ExamineQueue();
                            // Queue qu = new Queue();   //hur gör man för att använda samma queobjekt om man vill göra nedanstående ist.?
                            /*ExamineQueue("+Kalle", qu);
                            ExamineQueue("+Greta", qu);
                            ExamineQueue("-", qu);
                            ExamineQueue("+Stina", qu);
                            ExamineQueue("-", qu);
                            ExamineQueue("+Olle", qu); */

                            break;
                        }
                        break;

                    case '3':
                        ReverseText();
                        break;
                    case '4':
                        CheckParanthesis();
                        break;


                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                        break;
                }
            }
        }

        /// <summary>
        /// Examines the datastructure List
        /// </summary>
        static void ExamineList()
        /* 2) När listans kapacitet är för liten för att lägga till ett nytt element.
           3) Ökar med dubbelt
           4) För att en lista fungerar på det sättet helt enkelt
           5) Nej
           6) När man vill spara minne en större lista ta mer minne*/
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch statement with cases '+' and '-'
             * '+': Add the rest of the input to the list (The user could write +Adam and "Adam" would be added to the list)
             * '-': Remove the rest of the input from the list (The user could write -Adam and "Adam" would be removed from the list)
             * In both cases, look at the count and capacity of the list
             * As a default case, tell them to use only + or -
             * Below you can see some inspirational code to begin working.
            */
            List<string> theList = new List<string>();
            while (true)
            {
                Console.WriteLine("input:     to make a choice: (q = quit) ");
                Console.WriteLine("   +text   Add input text to list ");
                Console.WriteLine("   -text   Remove    text from list");
                char input = ' ';
                string input2 = "";

                //string input2;

                try
                {
                    input2 = Console.ReadLine();
                }
                catch (IndexOutOfRangeException)
                {

                    Console.Clear();
                    Console.WriteLine("Enter something please");
                }

                switch ((input2[0]))
                {
                    case 'q':
                        Environment.Exit(0);
                        break;
                    case '+':
                        theList.Add(input2.Substring(1)); //adds string but not "+"
                        Console.WriteLine("ListCount :" + theList.Count + " ListCapacity:" + theList.Capacity);
                        foreach (var item in theList)
                        {
                            Console.WriteLine(item);
                        }
                        //theList.ForEach(item => Console.Write(item));
                        //Console.WriteLine(theList);

                        break;

                    case '-':
                        theList.Remove(input2.Substring(1)); //removes string but not "-"
                        Console.WriteLine("ListCount :" + theList.Count + " ListCapacity:" + theList.Capacity);
                        foreach (var item in theList)
                        {
                            Console.WriteLine(item);
                        }

                        break;

                    default:
                        Console.WriteLine("please input + or - before string");


                        break;
                }

                Console.WriteLine("ListCount :" + theList.Count + " ListCapacity:" + theList.Capacity);
                Console.WriteLine(theList);
                if (input == 'q')
                {
                    Environment.Exit(0);
                }
            }

            //string input = Console.ReadLine();
            //char nav = input[0];
            //string value = input.substring(1);

            //switch(nav){...}
        }

        /// <summary>
        /// Examines the datastructure Queue
        /// </summary>
        /// 



        public static void ExamineQueue()
        {
            Queue q = new Queue();
            List<string> customers = new List<string> { "+Kalle", "+Greta", "-", "+Stina", "-", "+Olle" };
            foreach (string stritem in customers)
            {

                switch (stritem[0])
                {
                    //case '3':
                    //Environment.Exit(0);
                    //   break;
                    case '+':
                        q.Enqueue(stritem.Substring(1));
                        Console.WriteLine($"{stritem.Substring(1)} ställer sig i kön");
                        //Console.WriteLine($"kön består av {q.Count} antal personer");

                        break;

                    case '-':
                        // Console.WriteLine(q.Peek());
                        var oldestitem = q.Peek();
                        q.Dequeue();
                        Console.WriteLine($"{oldestitem.ToString()} blir expedierad och lämnar kön");

                        break;

                    default:
                        // Console.WriteLine("please input + or - before string");

                        break;
                }


            }

        }
        /*
         * Loop this method until the user inputs something to exit to main menue.
         * Create a switch with cases to push or pop items
         * Make sure to look at the stack after pushing and and poping to see how it behaves
        */

        /*
         * Loop this method untill the user inputs something to exit to main menue.
         * Create a switch with cases to enqueue items or dequeue items
         * Make sure to look at the queue after Enqueueing and Dequeueing to see how it behaves
        */


        /// <summary>
        /// Examines the datastructure Stack
        /// </summary>
        static void ReverseText()
        {

            Stack<string> mystack = new Stack<string>();
            var str = "";
            while (true)
            {

                //3.1) Inte så smart för att då skulle den som ställer sig i kön bli bortplockad först och inte kunna handla
                //3.2)
                Console.WriteLine("skriv in något (return) q=quit");


                try
                {
                    str = Console.ReadLine();

                }
                catch (IndexOutOfRangeException)
                {

                    Console.WriteLine("input is needed");
                }


                foreach (var item in str)
                {
                    mystack.Push(item.ToString());


                }

                str = "";
                while (mystack.Count > 0)
                {
                    str += mystack.Pop();
                }
                Console.WriteLine(str);
                if (str == "q")
                {
                    break;

                }





            }

        }
  //  
        static void CheckParanthesis() //kollar varje värde i en sträng och när en vänsterparantes påträffas sparas den i stacken och när en högerparantes påträffas görs en check om den motsvarar senaste vänstraparantesen i stacken (samtidigt tas det värdet bort från stacken) och strängen är då sålänge en välformad parantes som returnerar true. annars false. 
        {
            do
            {
                Console.WriteLine("Please enter a string to check!");
                var input = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(input)) // string!.IsNullOrWhiteSpace(input))
                    Console.WriteLine($"Wellformated: {IsWellFormatedp(input)}");

            } while (true);
        }

        private static bool IsWellFormatedp(string input)
        {
            Dictionary<char, char> dict = GetDict();

            var stack = new Stack<char>();
            Console.WriteLine(dict['(']);
            //int count = 0;
            var deleted = ' ';


            foreach (var item in input)
            {
                if (stack.Count == 0 && dict.ContainsValue(item)) // kolla om första är en högerparantes => felformaterad
                    return false;

                if (dict.ContainsKey(item))// dvs. den är vänsterparantes lägger alltså inte till högerparantes 

                    try
                    {
                        stack.Push(item); //lagrar vänsterparantesen i stacken och stack.Count är ej 0 => koden ovan returnerar ej false 
                    }
                    catch (KeyNotFoundException)
                    {

                        break;//continue;
                    }

                if (dict.ContainsValue(item)) // dvs item är någon högerparantes
                { 
                    deleted = stack.Pop();  // tar bort senaste vänsterparantes från stacken. dict[deleted] == item .kollar om högerparantes motstavarar samma typ av parantes som senaste påträffade vänsterparantesen dvs. t.ex. om ]  ska stacken ytterst ha (stack.push) vara [ då är det rätt och hoppar över nästa kodblock continue
                    if (dict[deleted] == item) // dvs den träffar på motsatsen (motsatsen = dict[deleted] dvs stoppar in värdet från stacken och returnerar motsatsen)till första vänster som först lades dit kollar nu te.x. (([{.. kollar om nästa är: }..] 
                        continue;
                    // koden nedan != betyder t.ex här att senaste påträffade vänsterparantes (lagrad i stacken sedan senaste träff) t.ex. { och högerparantes dvs. item nu t.ex. är ] .       
                    if (dict[deleted] != item && stack.Count != 0) //|| (stack.Count == 0)) // dvs den träffar på en höger parantes som inte motsvarar en lagrad
                        return false;
                }
            }

            if (stack.Count > 0)
                return false;
            return true;
        }

        private static Dictionary<char, char> GetDict()
        {
            return new Dictionary<char, char>
            {
                { '{', '}' },
                { '(', ')' },
                { '[', ']' },
                { '<', '>' }
            };
        }
    }
}



