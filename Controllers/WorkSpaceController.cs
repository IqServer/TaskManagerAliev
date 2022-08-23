using Microsoft.AspNetCore.Mvc;
using models;
using services;

namespace controllers;

class WorkSpacecontroller: ControllerBase
{
    WorkSpaceService _workspaceservice;
    public WorkSpacecontroller(WorkSpaceService workspaceService)
    {
         _workspaceservice = workspaceService;
    }

    [HttpGet]
    void GenerateWorkSpace ()
    {
        _workspaceservice.GenerateWorkSpace();
    }
}