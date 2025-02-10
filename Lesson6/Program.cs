using System.Reflection.Metadata.Ecma335;
using System.Threading.Channels;

namespace Lesson6
{
    internal class Program
    { 
        
        static void Main(string[] args)
        {
            #region nullable

            //string? a = Console.ReadLine();
            //Console.WriteLine(a);
            //string a = Console.ReadLine();
            //Console.WriteLine(a);

            #endregion

            ClassicShousClothes c = new();
            c.Geyinmek();
            Clothes clothes = new ClassicClothes();
            Clothes.WriteText("Atilla");

          
           
        }

    }
    #region Inheritace


    //class Clothes //base
    //{
    //    protected string Name { get; set; }


    //    #region static constructor

    //    //static Clothes()
    //    //{
    //    //    Console.WriteLine("Ilk obyekt yarandi");
    //    //}

    //    #endregion

    //    #region methods

    //    //public void X(int x) { 

    //    //  }   

    //    #endregion

    //    #region getter and setter


    //    //public int MyProperty {
    //    //    get
    //    //    {
    //    //        Console.WriteLine("getter ishledi");

    //    //        return 10;
    //    //    }
    //    //    set {

    //    //        Console.WriteLine("setter ishledi");


    //    //    }
    //    //}
    //    #endregion

    //}

    ////class SportClothes : Clothes //derived
    ////{
    ////    public int Name { get; set; }// name hiding
    ////}
    ////class ClassicClothes : Clothes
    ////{

    ////}
    ////class SportTrausersClothes : SportClothes
    ////{

    ////}


    #endregion

    #region Polymorphisim

    #region Virtual

    class Clothes
    {
        virtual public int Age { get; set; }
        virtual public void Geyinmek()
        {
            Console.WriteLine("Her hasisa geyim geyinildi");
        }

        static public void WriteText(string text)
        {
            Console.WriteLine(text);
        }

    }
    class ClassicClothes:Clothes
    {
        public override void Geyinmek()
        {
            Console.WriteLine("Classic geyim geyinildi");
        }
    }

    class ClassicShousClothes: ClassicClothes
    {
        
    }
      

      
        #endregion

        #region Overload

    //    class Animal
    //     {
    //    public void Voice(int a)
    //    {

    //    }
    //    public void Voice(int b, string c)
    //    {

    //    }
    //    public void Voice()
    //    {

    //    }
    //}

        #endregion

        #region Override

        #endregion


        #endregion

        #region Interfaces

        #endregion

        #region Abstraction

        //class UserService
        //{
        //    public void UserCreat()
        //    {

        //    }
        //    public void UserUpdate()
        //    {

        //    }
        //    public bool UserValidate()
        //    {
        //...
        //        return true;
        //    }
        //}

        #endregion
    class Email:IEmailService {
    
    }

    interface IEmailService
    {
        public void Email(string email)
        {
            Console.WriteLine(email);
        }
    }
}
