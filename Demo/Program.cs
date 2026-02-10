namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Question 1
            //double d = 9.99;
            //int x = (int)d;
            //Console.WriteLine(x);
            // This will print 9 cause of the explicit casting from double (bigger) to int(smaller)

            #endregion

            #region Question 2
            //int n = 5;
            //double d2 = (n) / 2;
            //Console.WriteLine(d2);

            // This will result 2 , if i want to print 2.5 i will change the first line to .. double n = 5;

            #endregion

            #region Question 3
            //Console.Write("Enter your age:");
            //int age = int.Parse(Console.ReadLine());
            // Constant examples

            #endregion

            #region Question 4

            //string s = "12a";
            //int y = int.Parse(s);
            //Console.WriteLine(x);
            // the string contains non-numeric characters ('a'), which makes it an invalid format for conversion.
            #endregion

            #region Question 5
            //try {
            //    string s = "12a";
            //    int y = int.Parse(s);
            //    Console.WriteLine(x);
            //}

            //catch(Exception e)
            //{
            //    Console.WriteLine("Invalid");
            //}
            #endregion

            #region Question 6
            //object o = 10;
            //int a = (int)o;
            //Console.WriteLine(a + 1);
            //// this will print 11
            //1.  object o = 10; stores the integer 10 as an object(boxing)
            //2.  int a = (int)o; unboxes the object back to an integer.
            //3.Console.WriteLine(a + 1); adds 1 to a(which is 10), resulting in 11.


            #endregion

            #region Question 7
            //object d = 10;
            //long x = (long)d;
            //Console.WriteLine(x);
            /*This error happens because the code is casting object containing int value (10) directly to a long.
             *while int can be implicitly converted to long, casting an object to long requires the object to already be of type long.
             */



            #endregion

            #region Question 8
            //try
            //{
            //    object o = 10;
            //    long x = (int)o;
            //    Console.WriteLine(x);
            //}
            //catch(Exception e)
            //{
            //    Console.WriteLine(-1);
            //}
            //can't implicitluy convert type object to long


            #endregion

            #region Question 9
            //string? name = null;
            //Console.WriteLine(name?.Length);
            // will print empty string (nothing) cause i make the name nullable var and assign it to null
            // then i checked if it is not null print the length of string and if it null it will not print anything

            #endregion

            #region Question 10
            //string? name2 = null;
            //int length = name2?.Length ?? 0;
            //Console.WriteLine(length);
            // It will not print zero 
            //i make the name nullable var and assign it to null
            //The expression name2?.Length checks if name2 is not null before accessing its Length property.
            //If name2 is null, name2?.Length evaluates to null.
            //The ?? 0 part then provides a default value of 0 if the left side is null.

            #endregion

            #region Question 11
            //string? s = null;
            //int x = int.Parse(s ?? "0");
            //Console.WriteLine(x);
            //it only handles the case where s is null. It does not handle cases where s is a non-null but invalid string .
            // how i solve it :
            //string? s = null;
            //int x = 0;
            //int.TryParse(s, out x);
            //Console.WriteLine(x);

            #endregion

            #region Question 12

            //string? s = null;
            //Console.WriteLine(s!.Length);
            //null forgiving operator !. it does not prevent runtime errors. If s is actually null at runtime,
            //using s! will still cause a NullReferenceException.
            // How to fix it:
            //Console.WriteLine(s?.Length);


            #endregion

            #region Question 13
            //string? s = null;
            //int x = Convert.ToInt32(s);
            //Console.WriteLine(x);
            //it print 0 cause the ToInt32 convert the value to 0 if the value is null

            #endregion

            #region Question 14

            //string? s = null;
            // A
            //int a = int.Parse(s);
            // B
            //int b = Convert.ToInt32(s);
            //Console.WriteLine(b);

            //A->value in parse can't be null
            //B->null is handeled in ToInt32()
            #endregion

            #region Question 15
            string? user = "Mariem";
            if(user == null)
            {
                Console.WriteLine("Guest");
            }
            else
            {
                Console.WriteLine(user.ToUpper());
            }

            #endregion

        }
    }
}
