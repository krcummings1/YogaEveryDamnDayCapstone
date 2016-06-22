using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
using YogaEveryDamnDay.Models;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace YogaEveryDamnDay.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [EnableCors("AllowDevelopmentEnvironment")]
    public class PoseCategoryController : Controller
    {

        private YogaEveryDamnDayContext _context;

        public PoseCategoryController(YogaEveryDamnDayContext context)
        {
            _context = context;
        }

        // GET: api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        //[HttpGet("{id}", Name = "GetPoseCategory")]
        //public IActionResult Get(int id)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }


            //IQueryable<int> categoryIds = from pc in _context.PoseCategory
            //                                join c in _context.Category
            //                                on pc.CategoryId equals c.CategoryId
            //                                where c.CategoryId == id
            //                                select new Category
            //                                {
            //                                    CategoryId = c.CategoryId,
            //                                    PoseType = c.PoseType,
            //                                };



            //var data = from pc in _context.PoseCategory
            //           join c in _context.Category
            //           on pc.CategoryId equals c.CategoryId
            //           where
            //           select new PoseCategory
            //           {
            //               CategoryId = pc.CategoryId,
            //               PoseType = c.PoseType,

            //               Poses = from pose in poses select pose
            //           }


            //IQueryable<int> categoryIds = from p in _context.Pose
            //                          join pr in _context.PoseRelationship
            //                          on p.PoseId equals pr.BasePosePoseId
            //                          where p.PoseId == id
            //                          select pr.PrepPosePoseId;

            //var prepNames = from p in _context.Pose
            //                where categoryIds.Contains(p.PoseId)
            //                select new Pose
            //                {
            //                    PoseId = p.PoseId,
            //                    CommonName = p.CommonName,
            //                    Sanskrit = p.Sanskrit,
            //                    Description = p.Description,
            //                    Image = p.Image

            //                };

            //var pose = from p in _context.Pose
            //           where p.PoseId == id
            //           select new Pose
            //           {
            //               PoseId = p.PoseId,
            //               CommonName = p.CommonName,
            //               Sanskrit = p.Sanskrit,
            //               Description = p.Description,
            //               Image = p.Image,
            //               PrepPoses = from prep in prepNames select prep
            //           };

        //    if (pose == null)
        //    {
        //        return NotFound();
        //    }

        //    return Ok(pose);
        //}

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
