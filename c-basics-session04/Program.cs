namespace c_basics_session04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            Console.WriteLine("Create a one-dimensional array double[] " +
                "prices with the values 25.5, 40.0, 33.75. Print\r\nthe second price (index 1).\r\n");
            double[] odarr = [25.5,40.0,33.75];
            Console.WriteLine(odarr[1]); //result will be 40.0


            #endregion

            #region Q2

            Console.WriteLine("Create a 2x2 multidimensional array int[,] shelfCopies " +
                "where shelf 0 has 3, 5 copies " +
                "and\r\nshelf 1 has 1, 4 copies. " +
                "Print the number of copies on shelf 1, slot 0.\r\n");
            int[,] shelfCopies =
                    {
                        { 3, 5 },
                        { 1, 4 }
                    };
            Console.WriteLine(shelfCopies[1, 0]);
            #endregion

            #region Q3

            Console.WriteLine("Write a method called PrintWelcomeMessage" +
                " that takes no parameters and" +
                " prints\r\n\"Welcome to the Library!\". Call it from Main.");
            static void PrintWelcomeMessage()
            {
                Console.WriteLine($"Welcome to the Library!");
            }

            //in Main
            PrintWelcomeMessage();
            #endregion
            #region Q4

            Console.WriteLine("Write a method PrintBookTitle(string title) " +
                "that prints \"Book title: \" + title. Call it with\r\n\"Clean Code\".");
            static void PrintBookTitle(string title)
            {
                Console.WriteLine("Book title: " + title);
            }
            PrintBookTitle("Clean Code");

            #endregion
            #region Q5
            Console.WriteLine("Write a method AddBonusPages(int pages) " +
                "that adds 50 to pages. Call it with a variable\r\n" +
                "int pages = 400; and print pages afterward. What do you expect to see, and why?");
            static int AddBonusPages(int pages)
            {
                return pages + 50;
            }
            int pages = 400;
            Console.WriteLine( AddBonusPages(pages));

            #endregion
            #region Q6

            Console.WriteLine("Write a method ApplyDiscount(double[] prices) that subtracts 5 from prices[0]." +
                " Call it\r\nwith double[] prices = { 25.5, 40.0 }; and print prices[0] afterward. " +
                "What do you expect to\r\nsee, and why?\r\n");

            static void ApplyDiscount(double[] prices)
            {
                prices[0] -= 5;
            }
            double[] prices = { 25.5, 40.0 };
            ApplyDiscount(prices);
            Console.WriteLine(prices[0]);
            //Run to see the result 20.5
            //Arrays are Reference Type 
            // we pass a reference to the same array in Heap.
            #endregion
            #region Q7
            Console.WriteLine("Rewrite the method from question 5" +
                " as AddBonusPagesByRef(ref int pages) using ref" +
                ".\r\nCall it and print pages afterward. " +
                "How is the result different from question 5?");
            static int AddBonusPagesByRef(ref int pages)
            {
                return pages += 10;
            }
           Console.WriteLine( AddBonusPagesByRef(ref pages));
            //ref allows the method to modify the variable
            #endregion
            #region Q8
            Console.WriteLine("Write a method ReplaceArray(ref double[] prices) " +
                "that replaces prices entirely with a\r\nnew array { 10.0, 12.5, 15.0 }. " +
                "Call it with your prices array and print prices.Length\r\nafterward");

            static void ReplaceArray(ref double[] prices)
            {
                prices = new double[] { 10.0, 12.5, 15.0 };
            }
            double[] Nprices = { 25.5, 40.0 };

    ReplaceArray(ref Nprices);

    Console.WriteLine(Nprices.Length);
            #endregion 


            #region Q9

            Console.WriteLine("Write a method bool TryGetPrice(string title, out double price)" +
                " that returns true and sets" +
                "\r\nprice to 25.5 if title is \"Clean Code\", " +
                "otherwise returns false and sets price to 0. Call it ");

            double price; 
            static bool TryGetPrice(string title, out double price)
            {
                if (title == "Clean Code")
                {
                    price = 25.5;
                    return true;
                }
                else
                {
                    price = 0;
                    return false;
                }
            }

            bool found = TryGetPrice("Clean Code", out price);

            Console.WriteLine("Found: " + found);
            Console.WriteLine("Price: " + price);
            #endregion

            #region Q10

            Console.WriteLine("Write a method PrintBookInfo(string title, int pages = 300) " +
                "where pages is optional. Call\r\n" +
                "it once with only a title, and once passing both a title and pages.");
            static void PrintBookInfo(string title, int pages = 300)
            {
                Console.WriteLine("Book: " + title);
                Console.WriteLine("Pages: " + pages);
            }
            PrintBookInfo("Clean Code");

            PrintBookInfo("Refactoring", 450);
            #endregion

            #region Q11
            Console.WriteLine("Using the PrintBookInfo method from the question above, " +
                "call it by naming the\r\nparameters, passing pages before title");
            PrintBookInfo(pages: 450, title: "Refactoring");

            #endregion
            #region Q12
            Console.WriteLine("Write a method PrintAllTitles(params string[] titles) " +
                "that prints each title on its own line.\r\nCall it with three book titles.");

            static void PrintAllTitles(params string[] titles)
            {
                foreach (string title in titles)
                {
                    Console.WriteLine(title);
                }
            }

            PrintAllTitles("Clean Code", "Refactoring", "The Pragmatic Programmer");
            #endregion
           
        }
    }
}
