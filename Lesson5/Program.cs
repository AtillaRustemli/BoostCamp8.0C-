#region topLevel
//qeyd1:Class daxilindeki butun fieldler ve methodlar default olaraq private access modifer dir.
//qeyd2:Constuctor nedir?Class yaranan anda ise dusen funkisya:
//qeyd3:contructor 2 cur olur parametrsiz(default) ve parametrli
#endregion

//Animal octopus = new(); 
//Car masin = new("BMW","M5","Pink");

//var masin1 = new Car("Mercedes", "S600", "Black",100);
using System.Globalization;

//var leo = new Card("111111111");
//var birbank = new Card("2222222222222");
//leo.Show();
//Console.WriteLine();
//birbank.Show();

//masin.Show();
//masin1.Show();

Console.Write("Daxil edin sehfe sayi: ");
int pageCount = int.Parse(Console.ReadLine());

var Seffiler = new Book(pageCount);
Seffiler.Show();

#region fields


public class Animal
{
     int age;  //field
    int _age; //
    int @this ;

    public Animal()
    {
        Console.WriteLine("Construcktor yarandi");

    }


}



#endregion 

#region constructor

public class Car
{
    string _model;
    string _color;
    string _vendor;
    int _hp;

    public  Car() //
    {

    }


    public Car(string vendor,string model, string color)
    {
        Console.WriteLine("3 parametrli konstruktor isledi");
        _model =model;
        _color=color;
        _vendor=vendor;
        
    }



    public Car(string vendor, string model, string color,int hp) :this(vendor,model,color)
    {
        Console.WriteLine("Esas konstruktor isledi");
        _hp =hp;
       
    }
       
   

    public void Show ()
    {
        Console.WriteLine($"Our Car paramters:{_model},{_color},{_vendor}");
    }





}






#endregion


#region constructor overloading


#endregion

#region readonly vs const 


class Card
{
    //const string Numbers; //error

    //public const string Numbers;
    public readonly string NumbersReadOnly;
    //define

    //public  string Numbers = "12344567898";



    public Card(string numbersReadOnly)
    {
        
    }


    public void Show()
    {
        //Numbers="123445"; error
        //NumbersReadOnly="1111"

       // Console.WriteLine($"My card number {}");
    }
}



#endregion 

#region methods


#endregion

#region expression-bodied methods


#endregion


#region method overloding


#endregion

#region this

//this 


#endregion


#region 4 esas prinsip




#endregion


#region  Encapsualtion-Properties

class Book
{
    //public int PageCount; //field

    //Property
    //get set

    //full property
    int _pageCount; //private 

    public int PageCount
    { 

        get { return _pageCount; }
        set
        {
            if (value>0)
            {

                _pageCount = value;
            }
        }
    }

    public string Name { get; set; }
    public int Age { get; set; }



    public Book(int pageCount)
    {
        PageCount=pageCount;
    }


     public void Show()
    {
        Console.WriteLine(_pageCount);
    }

}




#endregion


#region readonly properties


#endregion

#region inhertence








#endregion








