using System;
using System.Collections.Generic;

namespace csharp_notes
{

    class Calculator
    {
        private string _name;

        public string Name {
            get { return _name; }
            set { _name = value; }
        }

        public int Add(params enum level)
        {
            return 1;
        }

        
    }

    class Program
    {
        //Logger es una clase
        var dbMigrator = new DbMigrator(new Logger());

        DbMigrator.Migrate();


        var logger = new Logger();
        var installer = new Installer(logger);

        installer.install();
    }


    class MainClass
    {
        public static void Main(string[] args)
        {
            var calculator = new Calculator();
            var result = calculator.Add("2", "3");


            var customer = new Customer();
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);
        }

        /*
        var person = new person {
            FirstName = "mosh",
            LAstname = "e"
        }*/



        private readonly Dictionary<string, string> _dictionary;

        private readonly Dictionary<string, string> _dictionary1;

        public string this[string key] {
            get { return _dictionary1[key]; }
            set { _dictionary1[key] = value; }
        }





        public HttpCookie() {
            _dictionary = new Dictionary<string, string>();
        }

       public string this[string key] {
            get { return _dictionary[key]; }
            set { _dictionary[key] = value; }
       }

    }


    public class Calculator
    {
        public int Add(params int[] numbers) { }
    }

    var result = Calculator.Add(new int[] { 1, 2, 3 });

    var result = Calculator.Add(1, 2, 3);


    var cookie = new HttpCookie();
    cookie.Expire = DateTime.Today.AddDays(5);
    cookie["name"] = "mosh";
    cookie.SetItem("name","mosh");

    var name = cookie["name"];
    var name = cookie.GetItem("name");

   

    int number;
    var result = int.TryParse("abc", out number);
    if(result)
        Console.WriteLine(number);
    else
        Console.Writeline("conversion failed");
}
