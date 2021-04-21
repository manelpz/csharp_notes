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


        var book = new Book { isbn = "111", title="c#"};

            var numbers = new List();

            numbers.Add(10);


            var books = new BookList();
            books.Add(book);

            var numbers = new GenericList<int>();
            numbers.Add(10);

            var books = new GenericList<Book>();
            books.Add(NewsStyleUriParser Books());


    }
}
