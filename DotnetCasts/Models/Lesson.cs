using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace DotnetCasts.Models
{
    public class Lesson
    {
        public int Id { get; set; }
        public string Slug { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Link { get; set; }
        public int Runtime { get; set; }
        public bool IsSingle { get; set; }
        public bool IsSeries { get; set; }
        public bool IsPro { get; set; }
        public string Type { get; set; }
        public string Color { get; set; }

        [DataType(DataType.Date)]
        public DateTime PublishDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public string RuntimeDisplayValue()
        {
            TimeSpan t = TimeSpan.FromSeconds(Runtime);
            return t.ToString(@"hh\:mm\:ss");
        }
    }
}
