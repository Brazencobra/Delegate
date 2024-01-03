using Delegate.Models;

namespace Delegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            People class-ınız olur. Name, Surname, Age propertyləri olur.
            People List-i yaradırsınız. FindAll methodu ilə aşağıdakı sorğuları yazın :
            1. Adı **** olan person-u çıxarsın.
            2. Soyadı ov, ova ilə bitən tələbələri çıxarsın.
            3. Yaşı 18+ olanları çıxarsın 
            */


            People people = new People("Elxan","Mammadli",21);
            People people1 = new People("Elxan","Mammadov",15);
            People people2 = new People("Murad","Babayev",18);
            People people3 = new People("Zerife","Memmedova",22);
            List<People> peoples = new List<People>();
            peoples.AddRange(new People[] { people, people1, people2, people3 });
            peoples.FindAll(x => x.Name.Contains("Elxan")).ForEach(x => 
            {
                Console.WriteLine(x.Name + " " + x.Surname + " " + x.Age);
            });
            Console.WriteLine( " - - - - - - - - - - - -  " );
            peoples.FindAll(x => x.Surname.Substring(x.Surname.Length - 2).Contains("ov") || x.Surname.Substring(x.Surname.Length - 3).Contains("ova")).ForEach(x => 
            {
                Console.WriteLine(x.Name + " " + x.Surname + " " + x.Age);
            });
            Console.WriteLine(" - - - - - - - - - - - -  ");
            peoples.FindAll(x=>x.Age >= 18).ForEach(x => 
            {
                Console.WriteLine(x.Name + " " + x.Surname + " " + x.Age);
            });
        }
    }
}