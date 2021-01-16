using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ASP_API.Controllers
{
    [Route("api/questions")]

    public class QuestionsController : Controller
    {
        readonly QuizContext context;

        public QuestionsController(QuizContext context) {
            this.context = context;

        }


        
        [HttpGet]
        public IEnumerable<Models.Question> Get()
        {
            return context.questions;
        }


        [HttpOptions]
        public string Opt()
        {
            return "options";

        }

        [HttpHead]
        public string Head()
        {
            return "the head details if you want";

        }

        
        [HttpGet("{quizID}")]
        public IEnumerable<Models.Question> Get([FromRoute] int quizID)
        {
            return context.questions.Where(q => q.quizID == quizID);
        }


        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Models.Question question)
        {
            var quiz = context.quizzes.SingleOrDefault(q => q.ID == question.quizID);

            if (quiz == null)
                return NotFound();

            context.questions.Add(question);
            await context.SaveChangesAsync();
            return Ok(question);

        }


        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Models.Question question)
        {

            if (id != question.id)
                return BadRequest();

            context.Entry(question).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return Ok(question);

        }

        
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
