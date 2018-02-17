using System;

namespace zetsuboyANN
{
    class MatrixError : System.Exception
    {
        /// <summary>
        /// Constructor for a simple message exception.
        /// </summary>
        /// <param name="str">The message for the exception.</param>
        public MatrixError(String str) : base(str)
        {
        }
    }
}
