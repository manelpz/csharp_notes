using System;
namespace csharp_notes
{
    public class OperationResult
    {
        public boll success => !MessageList.Any();
        public Persona Persona { get; set; }

        public OperationResult()
        {
            MessageList = new GenericList<string>();
        }

        public void AddMessage(string message)
        {
            MessageList.Add(message);
        }




        public void SetSuccesResponse(Persona pers) {
            Persona = pers;
        }


        var book = new Book { isbn = "111", title = "c#" };

        var numbers = new List();

        numbers.Add(10);


            var books = new BookList();
        books.Add(book);

            var numbers = new GenericList<int>();
        numbers.Add(10);

            var books = new GenericList<Book>();
        books.Add(NewsStyleUriParser Books());


            Func<int, int> square = number => number * number;

        const int factor = 5;
        Func<int, int> multipler = n => n * factor;




    }


    var books = new BookRepository().GetBooks();
    var cheapBooks = books.FindAll(IsCheaperThan10Dollars);
    var cheapBooks = books.FindAll(book => book.Price <20 );


    foreach(var book in cheapBooks){

    }

    static bool IsCheaperThan10Dollars(Book book) {
    return book.price < 10;
    }
}


var cheapBooks = books
    .Where(b => b.Price <10)
    .OrderBy(b => b.Title)
    .Select(b => b.Title);


using static System.Console;



using (var streamWriter = new StreamWriter(@"c:\projects\result.html"));


public async Task DownloadHtmlAsync (string url) {

    var webClient = new WebClient();
    var html = await webClient.DowloadStringTaskAsync(url);

    using (var streamWriter = new StreamWriter(@"c:\projects\result.html")) {
        streamWriter.Write(html);
    }
}


