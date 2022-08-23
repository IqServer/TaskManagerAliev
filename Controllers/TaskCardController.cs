using Microsoft.AspNetCore.Mvc;
using models;
using services;

namespace controllers;

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