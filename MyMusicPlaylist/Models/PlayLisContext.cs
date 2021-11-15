using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyMusicPlaylist.Models
{
    public class PlayLisContext:DbContext
    {
        public PlayLisContext(DbContextOptions<PlayLisContext> options):base(options)
        {

        }

        public DbSet<Song> Songs { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
