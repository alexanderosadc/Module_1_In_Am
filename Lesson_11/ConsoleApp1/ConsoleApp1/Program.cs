using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    public class Person
    {
        public int Id { set; get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        private List<string> predefinedFriendsNames = new List<string>
            {"Alex", "Ana",
            "Vova", "Peter",
            "Butter", "Fedot",
            "Marian", "Vicu",
            "Elena",  "Stefania",
            "Eugenia" };


        public List<string> personFriends;

        public Person(int id, string firstName, string lastName)
        {
            Id = id;
            personFriends = new List<string>();
            for (int i = 0; i < 3; i++)
            {
                Random random = new Random();
                int randomIndex = random.Next(maxValue: predefinedFriendsNames.Count());
                string name = predefinedFriendsNames[randomIndex];
                personFriends.Add(name);
            }

            FirstName = firstName;
            LastName = lastName;
        }
    }

    public class Employee
    {
        public string JobPosition { get; set; }
        public int Id { get; set; }

        public Employee(int id, string jobPosition)
        {
            Id = id;
            JobPosition = jobPosition;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>()
            {
                new Person(0, "Alex", "Osadcenco"),
                new Person(1, "Vasile", "Papaluta"),
                new Person(2, "Ana", "Dvorac"),
                new Person(3, "Anisoara-Ionela", "Plesca"),
                new Person(4, "Vladimir", "Leadavschi"),
                new Person(5, "Ana", "Sarapova"),
            };
            // Filtering

            var valueWhere = people.Where(value => value.Id > 3).Select(person => new { person.FirstName, person.LastName });

            var valueTake = people.Take(2);

            var valueSkip = people.Skip(2);

            var valueTakeWhile = people.TakeWhile(value => value.Id < 3);

            var valueSkipWhile = people.SkipWhile(value => value.FirstName[0] == 'A');

            var capturedVariable = 'V';

            Console.WriteLine("Distinct Values");
            var valueDistinct = people.
                Where(person => person.FirstName[0] == capturedVariable || person.FirstName[0] == 'A').
                Select(person => person.FirstName).Distinct();
            capturedVariable = 'B';
            foreach (var item in valueDistinct)
            {
                Console.WriteLine(item);
            }


            // Projecction Select, SelectMany

            List<string> names = new List<string>() { "Alex", "Vitalii", "Iana" };

            IEnumerable<string> namesWithSelectManyPersons = people.SelectMany(personValue => personValue.personFriends).
                Where(value => value.Contains("a", StringComparison.InvariantCultureIgnoreCase));
            // Joining

            List<Employee> employees = new List<Employee>()
            {
                new Employee(1, "Developer"),
                new Employee(0, "Project Manager"),
                new Employee(2, "Game Designer"),
                new Employee(3, "Product Owner")
            };

            var emplyeesWithDataQuery = from person in people
                                        join employee in employees
                                        on person.Id equals employee.Id
                                        select new { person.Id, person.FirstName, person.LastName, employee.JobPosition };
            var employeesWithDataFluent = people.Join(employees,
                person => person.Id,
                employe => employe.Id,
                (person, employe) => new { person.Id, person.FirstName, person.LastName, employe.JobPosition });

            var groupPersons = people.GroupBy(
                person => person.FirstName);
            // Conversion Methods
            var arrOfPeople = people.ToArray();
            //Elements operators
            var firstOrDefault = people.FirstOrDefault();

            //Aggregation Methods
            var sumOfId = people.Sum(people => people.Id);

            //Qunatifiers
            var allNamesIsAlex = people.All(person => person.FirstName == "Alex");
            var anyNamesIsAlex = people.All(person => person.FirstName == "Alex");

            //Generation Methods

            var emptyEnumerator = Enumerable.Empty<int>();
            var repeatEnumerator = Enumerable.Repeat<int>(0, 10);
            var integerSequence = Enumerable.Range(0, 10);
        }
    }
}
