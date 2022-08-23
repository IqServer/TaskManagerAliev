using Microsoft.AspNetCore.Mvc;
using models;
using services;

namespace controllers;

class Boardcontroller: ControllerBase
{
    BoardService _boardservice;
    public Boardcontroller(BoardService boardService)
    {
         _boardservice = boardService;
    }

    [HttpGet]
    public void GenerateBoard()
    {
        _boardservice.GenerateBoard();
    }
}