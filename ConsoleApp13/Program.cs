using System.Linq.Expressions;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            //int b = a;
            //// deep copy

            //string text = "salam";
            //string text2 = text;

            //text2 = "sagol";
            //Console.WriteLine(text);
            ////shallow copy
            //Person person = new Person();
            ////Person b = person;
            ///
            bool b = 55<34;
            bool c = 55>34;
            // || &&
            if (b&&c||c)
            {
                a = 6;
            }
            else if(true)
            {
                a = 7;
            }
            else 
            {
                a = 4444; //heç vaxt daxil olmayacaq!!
            }

            // switch - case

            int swtichCaseNum = 6;
            //switch (swtichCaseNum) {
            //    case 5:
            //        Console.WriteLine("a 5-dir");
            //        break;

            //    default:
            //        Console.WriteLine("veziyyet pisdir");
            //        break;
            //}

            /*
             * cameCase
             * PacalCase
             * Snake_Case*/

            //Loops

            //++
            //--
            int loopNum = 55;
            while (loopNum>0) {
                loopNum--;
                //if(loopNum!=1)   // yalniz loomNum==1 oldugda girmeyecek
                //{
                //    Console.WriteLine("qutardi");
                //}
            }
            /*
             +=    a = a+5 =>  a+=5
            -=     a = a-5 =>  a-=5
            !=     if(a==5)-in eksi => if(a!=5)
            /=     a = a/5 =>  a/=5
             */
            loopNum += 66;
             loopNum -= 5;

            //do
            //{
            //    Console.WriteLine("ela");

            //}while(loopNum>0);
            int side = int.Parse(Console.ReadLine());
            for (int i = 1; i <= side; i++)
            {
                for (int j = 0; j < i; j++) {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            //Parse
            int parseTry ;
            if(int.TryParse(Console.ReadLine(), out parseTry)) // Console.ReadLine() vasitesi ile daxil edilen melumatin int-e cevrile bilib-bilmediyini yoxlayir
            {
                Console.WriteLine("alindi");
            }
            else
            {
                Console.WriteLine("alinmadi");
            }
            string hello = "Hello world";
            Console.WriteLine( hello.Substring(1, 4)); // hello-nun 1-ci index-inden bashlayaraq 4 simvolu goturur
            /*
             
              
             *
             **
             ***
             ****
             ***** 
             
             */
            //Console.Clear();
            //substring()



            //

            //

            //string text = " Hello World!";
            //string firstIndex;
            //string LastPart;
            //while (true) {
            //    Console.Write(text);
            //    firstIndex = text.Substring(0,1);
            //    LastPart = text.Substring(1);
            //    text = $"{LastPart}{firstIndex}";
            //    Thread.Sleep(100);
            //    Console.Clear();
            //} --- terpenen yazi

            




            int num1 = 1;
            int num2 = 1;
            int index = int.Parse(Console.ReadLine());
            int highestNum = index;
            int fNum = 0;
            while (index > 0) {
                if(index == highestNum)
                {
                    fNum = num1 + num2;
                }
                else
                {
                fNum += num1;
                num1 = fNum-num1;
                
                }
                Console.WriteLine(fNum);
                index--;

            }

        }
        class Person
        {
            public int MyProperty { get; set; }
        }
    }
}
