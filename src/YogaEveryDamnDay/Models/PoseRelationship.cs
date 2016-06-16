using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace YogaEveryDamnDay.Models
{
    public class PoseRelationship
    {
        [Key]
        public int PoseRelationshipId { get; set; }
      //  public int Id { get; set; }
      //  public int PrepPoseId { get; set; }

        [InverseProperty("PoseAsBasePose")]
        public Pose BasePose { get; set; }
        [InverseProperty("PoseAsPrepPose")]
        public Pose PrepPose { get; set; }
    }
}
