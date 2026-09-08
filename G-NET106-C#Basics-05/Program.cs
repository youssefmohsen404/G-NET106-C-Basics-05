using System.Drawing;

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

            #region Question 3
            //Add a public string Title; field to Book. Set it and print it from Main.

            /*Book book = new Book();
            Console.WriteLine(book.Title);
*/
            //it prints the title string without errors cause the access modifier is 
            //public so the string is reachable inside the whole project and in another project too
            #endregion

            #region Question 4
            //Declare an enum Genre { Fiction, NonFiction, Science }. Add a Genre property to Book,
            // assign it Genre.Science, and print it.

            /*Book book = new Book();
            Console.WriteLine(book.genre);*/
            #endregion

            #region Question 5
            //Using the Genre enum above, print the underlying int value of
            //Genre.Fiction, Genre.NonFiction, and Genre.Science by casting each to int.

            /*Console.WriteLine((int)Genre.Fiction);
            Console.WriteLine((int)Genre.NonFiction);
            Console.WriteLine((int)Genre.Science);*/
            
            
            #endregion
        }
    }
}
