using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01635279_Assign1.Controllers
{
    public class SquareController : ApiController
    {
        /// <summary>
        /// Result the square of a user provided digit
        /// </summary>
        /// <param name="id">Holds the user provided input (integer)</param>
        /// <param name="square">Squares the user input digit</param>
        /// <returns>
        /// Get api/Square/2 -> 4
        /// Get api/Square/-2 -> 4
        /// Get api/Square/10 -> 100
        /// </returns>
        public int Get(int id)
        {
            int square = id * id;
            return square;
        }
    }
}
