using Microsoft.AspNetCore.Mvc;
using models;
using services;

namespace controllers;

class ChatUsercontroller: ControllerBase
{
    ChatUserService _chatuserservice;
    public ChatUsercontroller(ChatUserService chatuserService)
    {
         _chatuserservice = chatuserService;
    }

    [HttpGet]
    public void GenerateChatUser()
    {
        _chatuserservice.GenerateChatUser();
    }
}