using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using USPlayingCard.Models;

namespace USPlayingCard.Data
{
    public class USPlayingCardContext : DbContext
    {
        public USPlayingCardContext (DbContextOptions<USPlayingCardContext> options)
            : base(options)
        {
        }

        public DbSet<Card> Card { get; set; }
    }
}
