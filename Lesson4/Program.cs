

namespace Lesson4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Convert & ToString()
            //int value = 123;
            //string text ="Atilla";

            //Convert.ToInt32(text);
            //Convert.ToInt32(text);
            //Convert.ToInt64(text);
            //Convert.ToInt16(text);



            #endregion

            #region continue 

            //int value = 123;
            //while (value > 0) {
            //    if (value % 5 == 0)  
            //    {
            //        value--;
            //        Console.WriteLine("if-in icindedir");
            //        continue;

            //    }
            //    Console.WriteLine(value);
            //    value--;

            //}

            #endregion

            #region String Methods

            #region Length

            //string text = "Atilla";
            //int simvolCount = text.Length;
            //Console.WriteLine(simvolCount);
            #endregion

            #region PadLeft & PadRight

            //***1
            //**10
            //string text = "1";

            //Console.WriteLine(text.PadLeft(4, '*'));

            //int rowCount = int.Parse(Console.ReadLine());
            //int index = 0;
            //while (index<=rowCount)
            //{
            //    Console.WriteLine(index.ToString().PadRight(4, '0'));
            //    index++;
            //    Thread.Sleep(100);
            //    Console.Clear();
            //}
            #endregion

            #region Concat

            //string text1 = "Rustemli";
            //string text2 = "Atilla";
            //Console.WriteLine(text1.Concat(text2)));

            #endregion

            #region ToCharArray

            //string text = "Atilla";
            //char[] charArr = text.ToCharArray();
            //for (int i = 0; i < charArr.Length; i++) {

            //    Console.WriteLine(charArr[i]);

            //}

            #endregion

            #region Join
            //string[] stringArr = { "Atilla" ,"Devamiyyeti", "Yoxlamalidi"};
            //string result = stringArr.Join(" ","");
            #endregion

            #region Split        

            //string value = "Salam-olsun-dunya";
            //var result = value.Split("-");

            //Console.WriteLine(result);

            #endregion

            #region Equals

            //string a = "Atilla";
            //string b = "Atilla";

            //if (a.Equals(b)) {

            //    Console.WriteLine("Beli") ;
            //}
            //else
            //{
            //    Console.WriteLine("Xeyr");
            //}

            #endregion

            #region Contains

            //string text = "Atilla";
            //string text2 = "Atl";
            //if (text.Contains(text2)) {
            //    Console.WriteLine("Var");
            //}

            #endregion

            #region StartWith

            //string text = "Atilla";

            //if (text.StartsWith('A'))
            //{
            //    Console.WriteLine("salam");
            //}

            #endregion

            #region Insert

            //string text1 = "Rza";
            //string text2 = "Mehemmed";

            //Console.WriteLine(text1.Insert(0,text2));

            #endregion

            #endregion

            #region goto
            //l1:
            //    Console.WriteLine("Ededi yaz: ");
            //    bool checkNumber = int.TryParse(Console.ReadLine(), out int value);

            //    if (!checkNumber ){
            //        goto l1;
            //    }

            #endregion

            #region Byte Methods

            #region Encoding.UTF8.GetBytes
            //char[] simvols = { 'A', 'b', 'c' };



            //foreach (var simvol in Encoding.UTF8.GetBytes(simvols)) {

            //    Console.WriteLine(simvol);

            //}

            #endregion

            #region GetString

            //byte[] data = { 40, 65, 97 };

            //Console.WriteLine(Encoding.UTF8.GetString(data));

            #endregion

            #region BitConverter.ToInt32

            //byte[] data = BitConverter.GetBytes(123);
            //foreach (byte b in data) {

            //    Console.WriteLine(b);
            //}
            //  Console.WriteLine(BitConverter.ToInt32(data));


            #endregion


            #endregion

            #region foreach
            #endregion

            #region ArrayMethods

            #region Array.Copy

            //string[] arr1 = { "Ulvi", "Oruc", "Mehemmed" };


            //string[] arr2 = { "Vusale", "Fidan" };

            //Array.Copy(arr1,0, arr2,0,1);

            //foreach(var a in arr2)
            //{
            //    Console.WriteLine(a);
            //}



            #endregion

            #region IndexOf

            //string text = "@Atilla.";
            //int indexOf = text.IndexOf("at");
            //int indexOf1 = text.IndexOf('a');
            //#endregion

            #endregion

            #region Array.Clear

            //int[] numArr = { 1, 2, 3, 4, 5, 6, 7, };

            //foreach (int num in numArr) {

            //    Console.WriteLine(num);

            //}

            //Array.Clear(numArr);//numArr massivinin butun elementlerini sildi ver int-in silindikden sonra default deyeri nedirese onu saxlayir--yeni 0

            //foreach (int num in numArr)
            //{

            //    Console.WriteLine(num);

            //}
            #endregion





            #region is/not/is not

            //var a = "text";
            //if (a is  string) {
            //    Console.WriteLine("string-dir");
            //}

            //int value = 12;
            //if( value is int value2)
            //{
            //    Console.WriteLine(value2);
            //}

            #endregion

            #region switch-case special

            #region < > _

            //int num = 132;
            //string text = num switch
            //{
            //    > 50 => "Atilla",
            //    < 50 => "Eli",
            //    _ => "Hec kes"

            //};
            //Console.WriteLine(text); ;

            #endregion

            #region or and not



            //  int num = 132;
            //  string text = num switch 
            //  {
            //      > 50 and <100  => "Atilla",
            //      <1200 and >800 => "Eli",
            //     not 50 => "Hec kes"

            // };
            //Console.WriteLine(text); ;


            #endregion

            #endregion

            #region object

            //object obj = 12; //boxing

            ////casting
            //Console.WriteLine((string)obj);
            //object[] obj1 = { 12, "salam" };


            #endregion


            #region Access modifier

            //public
            //internal
            //protected
            //private

            #endregion


            #endregion
            #region Task

            //Sert

            /*
             ad ve soyad ==>  !, *, @ -->olmamalidir

            e-mail ==>  @ ,  .  --> olmalidir , @ ve . yanashi olmamalidir

             */



        //    l1:
        //    Console.Write("Ad: ");
        //    string name = Console.ReadLine();
        //    Console.Write("Soyad: ");
        //    string surname = Console.ReadLine();
        //    Console.Write("Email: ");
        //    string email = Console.ReadLine();
        //    int emailIndexAt = email.IndexOf('@');
        //    int emailIndexDote = email.IndexOf('.');

        //    bool checkName = surname.Contains('!') || surname.Contains('@') || surname.Contains('.') ||
        //        name.Contains('!') || name.Contains('@') || name.Contains('.');
        //    bool checkMail = email.Contains('@') && email.Contains(".") && emailIndexAt < emailIndexDote;
        //    bool chackMailSurrounding = Math.Abs(emailIndexAt - emailIndexDote) == 1;
        //    if (checkName)
        //    {
        //        Console.WriteLine("Daxil edilen melumatlardan 1 ve ya daha coxu yanlishdir!");
        //        Console.WriteLine();
        //        Console.WriteLine();
        //        Console.WriteLine("Melumatlari yeniden daxil edin: ");
        //    goto l1;

        //}
        //    if(!checkMail||
        //        chackMailSurrounding)
        //    {
        //    Console.WriteLine("Daxil edilen melumatlardan 1 ve ya daha coxu yanlishdir!");
        //        Console.WriteLine();
        //        Console.WriteLine();
        //        Console.WriteLine("Melumatlari yeniden daxil edin: ");
        //        goto l1;
        //}


        #endregion

    }

        #region Class

        #endregion

    }

    class MyClass
    {
        int a;
        public int MyProperty { get; set; }



    }
}
