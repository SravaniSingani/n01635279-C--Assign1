using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01635279_Assign1.Controllers
{
    public class GreetingController : ApiController
    {
        /// <summary>
        /// This Post request returns a msg
        /// </summary>
        /// <greeting> curl -d "" "api/Greeting" </greeting>
        /// <returns>
        /// -> Hello World!
        /// </returns>
        public string Post()
        {
            return "Hello World!";
        }

        /// <summary>
        /// The Get request returns a msg to the number of people the user inputs
        /// </summary>
        /// <param name="id"> Holds the user input value. </param>
        /// <returns>
        /// 3 --> "Greetings to 3 people!"
        /// 7 --> "Greetings to 7 people!"
        /// </returns>
        public string Get(int id)
        {
            return "Greetings to " + id + " people!";
        }
    }
}
