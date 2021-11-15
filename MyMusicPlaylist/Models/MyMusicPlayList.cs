using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyMusicPlaylist.Models
{
    public class MyMusicPlayList:DbContext
    {
        public MyMusicPlayList(DbContextOptions<MyMusicPlayList> options):base(options)
        {

        }

        public DbSet<Song> Songs { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
