using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyMusicPlaylist.Models
{
    public class Song
    {
        [Key]
        public int SongId { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string Title { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string Performer { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string Url { get; set; }
        public int Review { get; set; }

        [Column(TypeName = "bit")]
        public bool Favourite { get; set; }
        public DateTime DateOfInput { get; set; }
        public DateTime DateOfLastEdit { get; set; }
        public Category SongCategory { get; set; }
    }
}
