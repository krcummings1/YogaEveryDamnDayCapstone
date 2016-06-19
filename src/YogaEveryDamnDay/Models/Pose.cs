using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace YogaEveryDamnDay.Models
{
    public class Pose
    {
        [Key]
        public int PoseId { get; set; }
        public string Sanskrit { get; set; }
        public string CommonName { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }

        [NotMapped]
        public virtual IQueryable<Pose> PrepPoses { get; set; }


        [InverseProperty("BasePose")]
        public virtual ICollection<PoseRelationship> PoseAsBasePose { get; set; }
        [InverseProperty("PrepPose")]
        public virtual ICollection<PoseRelationship> PoseAsPrepPose { get; set; }

        public ICollection<PoseCategory> PoseCategories { get; set; }

    }
}
