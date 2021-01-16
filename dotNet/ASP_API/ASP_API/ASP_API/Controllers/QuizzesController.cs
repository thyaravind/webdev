using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ASP_API.Controllers
{
    [Route("api/quizzes")]
    public class QuizzesController : Controller
    {

        readonly QuizContext _context;

        public QuizzesController(QuizContext context)
        {
            this._context = context;

        }

        

        [Authorize]
        [HttpGet]
        public IEnumerable<Models.Quiz> Get()
        {
            var userID = HttpContext.User.Claims.First().Value;
            return _context.quizzes.Where(q => q.OwnerID == userID);
        }

        
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Models.Quiz quiz)
        {
            if (ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var userID = HttpContext.User.Claims.First().Value;
            quiz.OwnerID = userID;

            _context.quizzes.Add(quiz);
            await _context.SaveChangesAsync();
            return Ok(quiz);
        }

       
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Models.Quiz quiz)
        {

            if (id != quiz.ID)
                return BadRequest();

            _context.Entry(quiz).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return Ok(quiz);

        }


        
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
