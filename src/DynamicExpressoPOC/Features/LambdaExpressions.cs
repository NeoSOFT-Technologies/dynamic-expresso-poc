using System.Linq.Expressions;
using DynamicExpresso;
using DynamicExpressoPOC.Model;

namespace DynamicExpressoPOC.Features
{
    public class LambdaExpressions
    {
        public static void LambdaExpression()
        {
            var persons = new List<Person>
            {
                new Person() { Name = "Laxman", Age = 37, Gender = 'M', Country = "Australia" },
                new Person() { Name = "Anjali", Age = 25, Gender = 'F', Country = "UK" },
                new Person() { Name = "Sameer", Age = 92, Gender = 'M', Country = "Germany" },
                new Person() { Name = "Baburao", Age = 10, Gender = 'M', Country = "China" },
                new Person() { Name = "Chatur", Age = 53, Gender = 'M', Country = "Australia" },
                new Person() { Name = "Rajjo", Age = 13, Gender = 'F', Country = "Australia" }
            };


            Console.Write("Enter Expression: ");
            string whereExpression = Console.ReadLine();    //person.Age > 18 && person.Country == "UK" && person.Gender == 'F'

            var interpreter = new Interpreter();

            Expression<Func<Person, bool>> expression = interpreter.ParseAsExpression<Func<Person, bool>>(whereExpression, "person");
            var result = persons.AsQueryable().Where(expression);


            foreach (var person in result)
                Console.WriteLine($"Name: {person.Name}\nGender: {person.Gender}\nAge: {person.Age}\nCountry: {person.Country}");
        }
    }
}
