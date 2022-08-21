using Microsoft.AspNetCore.Mvc;
using models;
using services;

namespace controllers;

class Testcontroller: ControllerBase
{
    UserService _userservice;
    public Testcontroller(UserService userService)
    {
         _userservice = userService;
    }

    [HttpGet]
    public void GenerateUser()
    {
        _userservice.GenerateUser();
    }
}