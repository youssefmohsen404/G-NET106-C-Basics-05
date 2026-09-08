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

            #region Question 2
            //Add an internal int copiesInStock = 5; field to Book. Print it from Main. Does it compile?
            //Why ?


            /*Book book = new Book();
            Console.WriteLine(book.copiesInStock);
*/

            // it prints the value without errors cause the access modifier is internal so the 
            //property can be reached in the whole project
            #endregion
        }
    }
}
