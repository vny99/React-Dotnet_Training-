using System;
namespace GradeBook
{
    public class MainClass
    {
        static void Main(string[] args)
        {
            var book = new Book();
            book.AddGradeEvent += AddGradeDelegateMethod;
            book.AddGradeEvent += AddGradeDelegateMethod;
            book.AddGradeEvent -= AddGradeDelegateMethod;
            book.AddGradeEvent += AddGradeDelegateMethod;
            EnterGrades(book);
            book.CalStats();
            book.ShowStats();
            book.Name = "hindhi";
            Console.WriteLine(book.Name);
            Console.WriteLine(Book.YEAR);
        }

        private static void EnterGrades(Book book)
        {
            for (; ; )
            {
                Console.WriteLine("Enter a grade or 'q' to quit ..! ");
                var input = Console.ReadLine();
                if (!input.Equals("q"))
                {
                    try
                    {
                        book.AddGrade(double.Parse(input));
                    }
                    catch (ArgumentException e)
                    {
                        Console.WriteLine(e.ToString());
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                else
                {
                    break;
                }
            }
        }

        public static void AddGradeDelegateMethod(object sender , EventArgs e)
        {
            Console.WriteLine("Grade Added");
        }
    }
}
