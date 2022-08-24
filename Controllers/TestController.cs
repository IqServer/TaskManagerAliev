using Microsoft.AspNetCore.Mvc;
using models;
using services;
using testnet;

namespace controllers;

[ApiController]
[Route("api/[controller]/[action]")]
public  class Testcontroller: ControllerBase

{
    UserService _userservice;
    DataContext _context;
    public Testcontroller(UserService userService,  DataContext context)
    {
        _context = context;
         _userservice = userService;
    }

    [HttpGet]
    public void GenerateUser()
    {
        _userservice.GenerateUser();
    }
    [HttpGet]
    public void GeneratDB()
    {
        _context.CreateBDNew();
  }

}