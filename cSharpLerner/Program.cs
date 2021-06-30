using System;
using System.Collections.Generic;
namespace cSharpLerner
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStack<int> ms = new MyStack<int>();
            ms.push(1);
            ms.push(2);
            ms.push(3);

            Console.WriteLine(ms.Peek());

            ms.Pop();
            Console.WriteLine(ms.Peek());

            ms.push(3);
            ms.push(4);
            ms.push(5);
            Console.WriteLine(ms.Peek());
        }
        

        

        static void HomeWorkRomenNumbers()
        {

            String eingabe;
            eingabe = Console.ReadLine();
            eingabe = eingabe.ToLower();
            int summe = 0;
            for (int i = 0; i < eingabe.Length; i++)
            {
                if (eingabe[i] == 'i'  )
                {   for (int j = 4; j > 0; j--) 
                    {
                         {
                            if (i + j < eingabe.Length)
                            {
                                if (eingabe[i + j] == 'i')
                                {
                                    summe = summe + j+1;
                                    Console.WriteLine($"i={i}  j={j} ");
                                    i = j + i;
                                    break;
                                }
                                else if (eingabe[i + j] == 'v')
                                {
                                    summe = summe - 1 ;
                                    Console.WriteLine($"i={i}  j={j} ");
                                    break;
                                }
                                else summe = summe + 1;
                            }
                            else continue;
                            

                       
                        }
                        
                    }
summe = summe + 1;
                }
                if (eingabe[i] == 'v')
                {
                    if (i + 1 < eingabe.Length)
                    {
                        if (eingabe[i + 1] == 'x')
                        {
                            summe = summe - 5;
                        }
                        else summe = summe + 5;
                    }
                    else summe = summe + 5;
                }
                if (eingabe[i] == 'x')
                {
                    if (i + 1 < eingabe.Length)
                    {
                        if (eingabe[i + 1] == 'l')
                        {
                            summe = summe - 10;
                        }
                        else summe = summe + 10;
                    }
                    else summe = summe + 10;
                }
                if (eingabe[i] == 'l')
                {
                    if (i + 1 < eingabe.Length)
                    {
                        if (eingabe[i + 1] == 'c')
                        {
                            summe = summe - 50;
                        }
                        else summe = summe + 50;
                    }
                    else summe = summe + 50;
                }
                if (eingabe[i] == 'c')
                {
                    if (i + 1 < eingabe.Length)
                    {
                        if (eingabe[i + 1] == 'd')
                        {
                            summe = summe - 100;
                        }
                        else summe = summe + 100;
                    }
                    else summe = summe + 100;
                }
                if (eingabe[i] == 'd')
                {
                    if (i + 1 < eingabe.Length)
                    {
                        if (eingabe[i + 1] == 'm')
                        {
                            summe = summe - 500;
                        }
                        else summe = summe + 500;
                    }
                    else summe = summe + 500;
                }
                if (eingabe[i] == 'm')
                {
                     summe = summe + 1000;
                }
            }
        
        
            Console.WriteLine("Summe = "+summe+ "  " + eingabe.Length);



        }
        static void HomeWorkLoginPass()
        {
            string name = "johnsilver";
            string password = "qwerty";
            string UserLogin;
            string UserPass;
            int tryes=0;
            Console.WriteLine("You have a 3 tryes");
            do
            {
                Console.WriteLine("Try nr: "+ (tryes+1));
                Console.WriteLine("Please give me a login");
                UserLogin = Console.ReadLine();
                UserLogin = UserLogin.ToLower();
                Console.WriteLine("Please give me a password");
                UserPass = Console.ReadLine();
                tryes++;
            }
            while (LoginAndPassTrue(UserLogin, UserPass) == false && tryes != 3) ;
            if (LoginAndPassTrue(UserLogin, UserPass) == true)
            {
                Console.WriteLine("Login succes");
            }
            else Console.WriteLine("The number of available tries have been exceeded");
            bool LoginAndPassTrue(string login, string pass)
            {
                if (login == name && pass == password) return true;
                else return false;
            }

        }
        static void HomeWorkFactorials()
        {
            Console.WriteLine("Give me an factorial number : ");
            int number = int.Parse(Console.ReadLine());
            long summe=1;
            if (number == 0) Console.WriteLine("Summe =1");
            for (int i = number; i >0; i--)
            {
                summe *= i;
                Console.WriteLine($"i= {i} * summe ="+summe);
            }

        }
        static void HomeWork10Numbers()
        { int i = -1;
            int[] numbers = new int[10]; 
            Console.WriteLine("Please Give me a 10 numbers");
            do
            {
            i++;
             numbers[i] = int.Parse(Console.ReadLine());

            } while (i != 9 &&numbers[i]!=0);
            double summe=0;
            if (i == 9) i = 10;
            foreach (var k in numbers)
            {
                summe = summe + (double)k;
            }
            Console.WriteLine("Arethmetic avarage ="+summe/(double)i);
        }
            static void HomeWorkFibonacci()
        {
            Console.WriteLine("How much numbers?");
            int numbers = int.Parse(Console.ReadLine());
            int[] zahlen = new int[numbers];
            zahlen[0] = 1;
            zahlen[1] = 1;
       

            for (int i = 0; i < numbers; i++)
            {
                if (i < 2)
                {
                    Console.WriteLine($"{i+1}= {zahlen[i]}");
                }
                if (i >= 2)
                {
                zahlen[i] = zahlen[i - 1] + zahlen[i - 2];
                Console.WriteLine($"{i+1}= {zahlen[i]}");
                }

            }
        
        }
            static void HomeWorks123(string[] args)
        {
            Console.WriteLine("Give me a 3 numbers ");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine($"Firs number {a}, {b}, {c}");
            double p = 0.5 * (a + b + c);
            Console.WriteLine(p);
            double per = Math.Sqrt((p * ((p - a) * (p - b) * (p - c))));
            Console.WriteLine($"Gerona = {per}");


            string name;
            Console.WriteLine("Please say your Name");
            name = Console.ReadLine();
            Console.WriteLine($"Hi, {name}");
            Console.WriteLine("Give Me pls a first number!");
            string num1;
            num1 = Console.ReadLine();
            Console.WriteLine("Give Me pls a twend number!");
            string num2;
            num2 = Console.ReadLine();
            string temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine("Your 2nd number : " + num1);
            Console.WriteLine($"Your 1st number: {num2}");
            Console.WriteLine("Please give me a number");
            string number = Console.ReadLine();
            int final = int.Parse(number.Trim());
            Console.WriteLine($"Thats is from {number.Trim().Length} number");
            Console.WriteLine($"Thats is from {final.ToString().Trim().Length} number");
        }
        static void Variables()
        {

            int x = 1;

            int y;
            y = 2;

            Int32 x1;
            x1 = -1;

            float f = 1.1f;

            double d = 1.2;

            int x2 = 0;
            int x3 = new int();

            var a = 1;
            var b = 1.1;
            var c = "c";

            Console.WriteLine(a);
            Console.WriteLine(c);
        }
    }
}
