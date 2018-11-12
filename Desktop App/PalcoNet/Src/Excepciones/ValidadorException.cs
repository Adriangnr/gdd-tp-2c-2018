using System;

namespace PalcoNet.Src.Excepciones
{
    class ValidadorException : Exception
    {
        public ValidadorException(string message) : base(message)
        {
        }
    }
}
