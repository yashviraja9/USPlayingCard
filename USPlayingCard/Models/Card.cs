using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace USPlayingCard.Models
{
    public class Card
    {
        public int Id { get; set; }

        [StringLength(100, MinimumLength = 3), Required]
        public string Title { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$"), Required, StringLength(50)]
        public string Brand { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$"), Required, StringLength(30)]
        public string Material { get; set; }

        [Range(1, 100), DataType(DataType.Currency), Required]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        [RegularExpression(@"^\b[0-9]*$"), StringLength(5), Required]
        public string Rating { get; set; }

        [Display(Name = "Image")]
        public string ImageUrl { get; set; }
    }
}