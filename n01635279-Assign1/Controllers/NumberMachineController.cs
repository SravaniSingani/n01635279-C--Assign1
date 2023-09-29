using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01635279_Assign1.Controllers
{
    public class NumberMachineController : ApiController
    {
        /// <summary>
        /// The method applyies different mathematical operations on user input.
        /// </summary>
        /// <param name="id"> Holds the user input value. </param>
        /// <param name="add"> Performs addition operation. </param>
        /// <param name="subtract"> Performs subtraction operation. </param>
        /// <param name="multiply"> Performs multipication. </param>
        /// <param name="divide"> Performs division. </param>
        /// <returns>
        /// Returns 4 values applying addition, subtraction, multipication and division.
        /// </returns>
        public string Get(int id)
        {
            int add = id + id;
            int subtract = id - id;
            int multiply = id * id;
            int divide = id / id;

            return "Add = "+ add + 
                " Subtract = " +subtract +
                " Multiply = " +multiply +
                " Divide = " +divide;
        }
    }
}
