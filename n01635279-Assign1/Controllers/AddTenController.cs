using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01635279_Assign1.Controllers
{
    public class AddTenController : ApiController
    {
        /// <summary>
        /// Add 10 to the user input number
        /// </summary>
        /// <param name="id">id is an input from the user (integers)</param>
        /// <param name="add">adds 10 to the user input</param>
        /// <returns>
        /// Get api/AddTen/21 -> 31
        /// Get api/AddTen/0 -> 10
        /// Get api/AddTen/-9 -> 1
        /// </returns>
        public int Get(int id)
        {
            int add = id + 10;
            return add;

        }
    }
}
