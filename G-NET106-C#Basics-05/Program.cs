namespace G_NET106_C_Basics_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1
            //Add a private string password = "secret"; field to a Book class. Try to print it from Main
            //(outside the class). What happens, and why?
            /*Book book = new Book();
            book.password; 
*/
            //it gives a compile time error cause the access modifier is private for the object 
            //so i can reach the object only inside the class i have to make it internal 
            #endregion
    }
    }
}
