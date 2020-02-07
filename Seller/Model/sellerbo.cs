using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Seller.Model;
using System.Web;


namespace Seller.Model
{
    public class sellerbo : Interface
    {
        private List<seller> sel;
        public sellerbo()
        {
            sel = new List<seller>()
            {
                new seller(234, "susmitha", "ertt", "cts", 7687, "good", "tyfgg", "fghh", "madalasusmitha", 9978654),
                new seller(235, "susmitha", "ertt", "cts", 7687, "good", "tyfgg", "fghh", "madalasusmitha", 9978654),
                new seller(237, "susmitha", "ertt", "cts", 7687, "good", "tyfgg", "fghh", "madalasusmitha", 9978654),
            };
        }
        public seller Getseller(int id)
        {
            seller e = sel.FirstOrDefault(e => e.Id == id);
            //foreach(Employ X in emp)
            //{
            //    if (X.Id == id) return X;

            return e;
        }
    }
}
