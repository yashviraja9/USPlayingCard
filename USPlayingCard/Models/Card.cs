using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace USPlayingCard.Models
{
    public class Card
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Brand { get; set; }
        public string Material { get; set; }
        public decimal Price { get; set; }
    }
}
