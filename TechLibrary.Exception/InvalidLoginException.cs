using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TechLibrary.Exception
{
    public class InvalidLoginException : TechLibraryException
    {
        public override List<string> GetErrorMessages() => ["Email e/ou senha inválidos."];


        public override HttpStatusCode GetStatusCode() => HttpStatusCode.Unauthorized;
    }
}
