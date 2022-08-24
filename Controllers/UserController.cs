using Microsoft.AspNetCore.Mvc;
using models;
using services;

namespace controllers;

[ApiController]
[Route("api/[controller]/[action]")]


public  class Usercontroller: ControllerBase
{


    UserService _userservice;
    public Usercontroller(UserService userService)
    {
         _userservice = userService;
    }

    [HttpGet]
    public void GenerateUser()
    {
        _userservice.GenerateUser();
    }
}