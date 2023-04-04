using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook
{
    public delegate void AddGradeDelegate(object sender, EventArgs args);
    
  

    public class NameClass
    {
        public NameClass(string name)
        {
            this.Name = name;
        }
        public string Name
        {
            set;get;
        }
    }
    public abstract class BookBase :NameClass
    {
        public BookBase( string s): base(s){

            }
        public abstract void AddGrade(double d);
    }
    public class Book : BookBase
    {
       private double high;
       private  double low;
       private double average;
        private char letter;
        private List<double> grades;
        readonly string school = "";
       public  const int YEAR = 2023;
        public event AddGradeDelegate AddGradeEvent;
        public Book() : base("")
        {
            grades = new List<double>();
            high = double.MinValue;
            low = double.MaxValue;
            average = 0.0;
            letter = 'A';
            school = "s";
            Name = "science";

        }

        
        public void AddGrade(char a)
        {
            grades.Add(80);
           
        }

        public override void AddGrade(double grade)
        {
            if(grade <=100 && grade >= 0)
            {
                grades.Add(grade);
                if (AddGradeEvent != null)
                {
                    AddGradeEvent(this, new EventArgs());
                }
            }
            else
            {
                throw new ArgumentException($"Invalid {nameof(grade)} ");
            }
        }
        public void CalStats()
        {
            double sum = 0.0;
            foreach(double n in grades)
            {
                sum += n;
                high = Math.Max(high, n);
                low = Math.Min(low, n);

            }
            average = sum / grades.Count;
            switch (average)
            {
                case var doub when doub >= 90.0:
                    letter = 'A';
                    break;
                case var doub when doub >= 80.0:
                    letter = 'B';
                    break;
                case var doub when doub >= 70.0:
                    letter = 'C';
                    break;
                default: break;

            }

        }
        //public string Name
        //{
        //    get
        //    {
        //        return name;
        //    }
        //    set
        //    {
        //        if (!string.IsNullOrEmpty(value))
        //        {
        //            name = value;
        //        }
        //    }
        //}
 
         public void ShowStats()
        {
            Console.WriteLine("The stats are");
            Console.WriteLine($"The highest grade is {high:N2}");
            Console.WriteLine($"The Lowest grade is {low:N2}");
            Console.WriteLine($"The average grade is {average:N2}");
            Console.WriteLine($"The letter grade is {letter}");
        }
        public Result SetStats()
        {
            var result = new Result();
            result.high = high;
            result.low = low;
            result.average = average;
            result.letter = letter;
            return result;
        }
        public void LetterGrade(char letter)
        {
            switch (letter)
            {
                case 'A':
                    AddGrade(90);
                    break;
                case 'B':
                    AddGrade(80);
                    break;
                case 'C':
                    AddGrade(70);
                    break;

                default:
                    break;

            }
        }




    }
}
