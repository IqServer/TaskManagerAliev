using Microsoft.AspNetCore.Mvc;
using models;
using services;

namespace controllers;

[ApiController]
[Route("api/[controller]/[action]")]
class ArchiveCardcontroller: ControllerBase
{
    ArchiveCardService _archivecardservice;
    public ArchiveCardcontroller(ArchiveCardService archivecardService)
    {
         _archivecardservice = archivecardService;
    }

    [HttpGet]
    public void GenerateWorkSpace()
    {
        _archivecardservice.GenerateArchiveCard();
    }
}