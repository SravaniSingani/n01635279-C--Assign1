using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01635279_Assign1.Controllers
{
    /// <summary>
    /// Calculating the total hosting cost for a client 
    /// The client is charged $5.50 per fortnight(14 days) and additional 13% HST
    /// </summary>
    /// <param name="id"> Nmber of days elapsed since the beginning of hosting </param>
    /// <result> 
    /// 0 --> “1 fortnights at $5.50/FN = $5.50 CAD"
    ///       “HST 13% = $0.72 CAD”
    ///       “Total = $6.22 CAD”
    /// 
    /// 14 --> “2 fortnights at $5.50/FN = $11.00 CAD”
    ///        “HST 13% = $1.43 CAD”
    ///        “Total = $12.43 CAD”
    /// </result>

    public class HostingCostController : ApiController
    {
        public string Get(int id)
        {
            decimal amountCharged = 5.50m;
            int hst = 13;
            int fortnights;

           fortnights = (id / 14) + 1;

            decimal totAmount = Decimal.Round( fortnights * amountCharged, 2 );
            decimal hstCharged = Decimal.Round((totAmount * hst)/100, 2);
            decimal totCost = Decimal.Round(totAmount + hstCharged, 2);


                return fortnights + "'fortnight at $5.50/FN = $"+totAmount+"CAD' " +
                "'HST 13% = $"+hstCharged+ "CAD' 'Total = $"+totCost+"CAD'";

        }
    }
}
