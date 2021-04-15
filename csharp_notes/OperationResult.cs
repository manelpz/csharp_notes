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



    }
}
