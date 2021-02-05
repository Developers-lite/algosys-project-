﻿using OnlineQuizWebApp.Utilities;
using OnlineQuizWebApp.DataLayer.QuizDL;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Collections.Generic;
using OnlineQuizWebApp.Modules.QuizOptionBL;

namespace OnlineQuizWebApp.Controllers
{
    public class QuizOptionApiController : ApiControllerBase

    {
        private readonly IQuizOptionsService _service;
        public QuizOptionApiController(IQuizOptionsService service)
        {
            _service = service;
        }
        [HttpGet]
        public async Task<List<QuizOptions>> GetAll()
        {
            return await _service.GetAll();
        }

        [HttpGet("{quizoptionId}")]
        public async Task<QuizOptions> GetById(int quizoptionId)
        {
            return await _service.GetById(quizoptionId);
        }
    }
}
