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
    public class CategoryController : Controller
    {

        private YogaEveryDamnDayContext _context;

        public CategoryController(YogaEveryDamnDayContext context)
        {
            _context = context;
        }

        // GET: api/values
        [HttpGet(Name = "GetCategories")]
        public IActionResult Get()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var allCategories = _context.Category.OrderBy(s => s.PoseType);

            if (allCategories == null)
            {
                return NotFound();
            }

            return Ok(allCategories);
        }

        // GET api/values/5
        //[HttpGet("{id}", Name = "GetCategory")]
        //public IActionResult Get(int id)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

            // category.categoryid equals posecategory.categoryid
            // 

            // category should have a list of poses
            //var poses
            // from pc in posecategory
            // join from p in pose
            //  pose.poseid equals posecategory.poseid
            //   select pose {
            // all pose properties

            //IQueryable<int> poseCategories = from
            //                 select pc.PoseCa
            //                   select pc.  


            //                select pc.categoryid (pass in category id)
            //                        c.posetype
            //                        p.poseid
            //    poses               p.commonname
            //                        p.sanskrit
            //                        p.description
            //                        p.image

            //                  from main thing above

            //                  inner join pc pose category
            //                    on pc.categoryid = id
            //                   inner join pose p
            //                        pc.poseid = pc.poseid

           //var category = from c in _context.Category
           //           join pc in _context.PoseCategory
           //           join p in _context.Pose
           //           on p.PoseId equals pc.PoseId
           //           where pc.CategoryId == id
           //           select new Category
           //           {
           //               c.CategoryId,
           //               c.PoseType
           //                 select new Pose
           //                 {
           //                     PoseId = p.PoseId,
           //                     CommonName = p.CommonName,
           //                     Sanskrit = p.Sanskrit,
           //                     Description = p.Description,
           //                     Image = p.Image
           //                 }
           //           }
                      






//SELECT s.studentname
//    , s.studentid
//    , s.studentdesc
//    , h.hallname
//FROM students s
//INNER JOIN hallprefs hp
//    on s.studentid = hp.studentid
//INNER JOIN halls h
//    on hp.hallid = h.hallid



//            var xxx = from c in _context.Category
//                      join pc in _context.PoseCategory
//                      join p in _context.Pose
//                      on c.CategoryId equals pc.CategoryId
//                      where poseCategories or pc.posecategoryid.Contains(p.PoseId)
//                      select new Pose
//                      {
//                          PoseId = p.PoseId
//                          CommonName = p.CommonName
//                          Sanskrit = p.Sanskrit
//                          Description = p.Description,
//                          Image = p.Image
//                      }


//            var category = from c in _context.Category
//                           where c.CategoryId == id
//                           select new Category
//                           {
//                               CategoryId = c.CategoryId,
//                               PoseType = c.PoseType,
//                               PosesByCategory = from pose in xxx select pose
//                           };

//            // new  category {
//            // Categoryid = category.categoryid
//            // PoseType/Category = category.posetype   
//            // poses (list on category) = pose in poseNames select pose


//            var IQueryable<int> poseIds = from c in _context.Category
//                             join pc in _context.PoseCategory
//                             on c.CategoryId equals pc.CategoryId
//                             where c.CategoryId == id
//                             select new Category
//                             {
//                                 CategoryId = c.CategoryId,
//                                 PoseType = c.PoseType,
//                             };

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

        //    if (category == null)
        //    {
        //        return NotFound();
        //    }

        //    return Ok(category);
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
