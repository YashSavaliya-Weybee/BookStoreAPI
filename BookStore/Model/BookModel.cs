using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BookStore.Model
{
    public class BookModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Enter Title")]
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
