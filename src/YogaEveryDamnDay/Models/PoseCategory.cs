using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace YogaEveryDamnDay.Models
{
    public class PoseCategory
    {
        [Key]
        public int PoseCategoryId { get; set; }
        public int PoseId { get; set; }
        public int CategoryId { get; set; }

        [ForeignKey("PoseId")]
        public Pose Pose { get; set; }
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }
    }
}
