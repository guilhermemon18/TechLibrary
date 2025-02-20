using System.Net;

namespace TechLibrary.Exception
{
    public class NotFoundException : TechLibraryException
    {

        public NotFoundException(string message) : base(message) { }
        public override List<string> GetErrorMessages()
        {
            throw new NotImplementedException();
        }

        public override HttpStatusCode GetStatusCode() => HttpStatusCode.NotFound;
    }
}
