using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace YogaEveryDamnDay.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public string PoseType { get; set; }

        public ICollection<PoseCategory> PoseCategories { get; set; }
        

    }
}
