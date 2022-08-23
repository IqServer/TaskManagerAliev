using Microsoft.AspNetCore.Mvc;
using models;
using services;

namespace controllers;

[ApiController]
[Route("api/[controller]/[action]")]
class TaskCardcontroller: ControllerBase
{
    TaskCardService _taskcardservice;
    public TaskCardcontroller(TaskCardService taskcardService)
    {
         _taskcardservice = taskcardService;
    }

    [HttpGet]
    public void GenerateBoard()
    {
        _taskcardservice.GenerateTaskCard();
    }
}