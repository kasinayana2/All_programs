using System;

namespace All_programs
{
    class program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Please enter a number to test it is prime or not");
            int n = int.Parse(Console.ReadLine());
            int a = 0;
            for (int i = 2; i < n; i++)
            {

                if (n % i == 0)
                {
                    a++;
                    break;
                }
            }
            if (a == 0)
            {
                Console.WriteLine("{0} is a Prime Number", n);
            }
            else
            {
                Console.WriteLine("Not a Prime Number");
            }
            Console.ReadLine();


            //string enter = Console.ReadLine();
            //string remaing = "";

            //for (int i = enter.Length - 1; i >= 0; i--)
            //{
            //    remaing = remaing + enter[i];
            //}
            //Console.WriteLine(remaing);
            //Console.ReadLine();




            //----------This is revers string ------------//

            //string entername = Console.ReadLine();
            //char[] givename = entername.ToCharArray();
            //char[] ReadName = new char[givename.Length];
            //for(int i=0, k=givename.Length-1; i < givename.Length; i++,k--)
            //{
            //    ReadName[k] = givename[i];
            //}
            //string result = new string(ReadName);
            //Console.WriteLine(result);
            //if(entername == result)
            //{
            //    Console.WriteLine("Enter The Name is Pallindrom");
            //}
            //else
            //{
            //    Console.WriteLine("Enter The Name is Not Pallindrom");
            //}
            //Console.ReadLine();


            //----------When you enter some amount count the notes examlpe how many thousend notes like that one-------------//


            //int enteramount = Convert.ToInt32(Console.ReadLine());

            //int thousand = 0, fivehundred = 0, hundred = 0, fifty = 0, Ten = 0;

            //int Remaining = 0;

            //if (enteramount >= 1000)
            //{
            //    thousand = enteramount / 1000;
            //    Remaining = enteramount % 1000;
            //}
            //if (Remaining >= 500)
            //{
            //    fivehundred = Remaining / 500;
            //    Remaining = Remaining % 500;
            //}
            //if (Remaining >= 100)
            //{
            //    hundred = Remaining / 100;
            //    Remaining = Remaining % 100;
            //}
            //if (Remaining >= 50)
            //{
            //    fifty = Remaining / 50;
            //    Remaining = Remaining % 50;
            //}
            //if(Remaining >= 10)
            //{
            //    Ten = Remaining / 10;
            //    Remaining = Remaining % 10;
            //}
            //Console.WriteLine(thousand);
            //Console.WriteLine(fivehundred);
            //Console.WriteLine(hundred);
            //Console.WriteLine(fifty);
            //Console.WriteLine(Ten);
            //Console.ReadLine();



            //--------------------- When we enter some number How to get this is Enven number snd odd number -------------------//

            //int number = Convert.ToInt32(Console.ReadLine());

            //if(number % 2 == 0)
            //{
            //    Console.WriteLine("Enter number is Enven");
            //}
            //else
            //{
            //    Console.WriteLine("Enter number is odd");
            //}


            //----------------------given numbers 1,2,3,4,5,6,...... from this i want to show sum of even numbers---------------//

            //int[] numers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int reselt = 0;
            //foreach(var number in numers)
            //{
            //    if(number % 2 == 0)
            //    {
            //        reselt = reselt + number;
            //    }
            //}
            //Console.WriteLine(reselt);
            //Console.ReadLine();
        }
    }
}
