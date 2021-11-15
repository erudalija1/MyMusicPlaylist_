using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyMusicPlaylist.Models
{
    public class MyMusicPlayLisContext:DbContext
    {
        public MyMusicPlayLisContext(DbContextOptions<MyMusicPlayLisContext> options):base(options)
        {

        }

        public DbSet<Song> Songs { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
