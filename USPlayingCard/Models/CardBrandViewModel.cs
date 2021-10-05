using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace USPlayingCard.Models
{
    public class CardBrandViewModel
    {
        public List<Card> Cards { get; set; }
        public SelectList Brand { get; set; }
        public string CardBrand { get; set; }
        public string SearchString { get; set; }
    }
}
