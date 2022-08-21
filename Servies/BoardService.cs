using models;
using testnet;

namespace services;

public class BoardService{

    readonly DataContext _context;
    public BoardService(DataContext context)
    {
        _context = context;

    }

    public List<Board> GetBoards(){
     var board =  _context.Boards.ToList();

        return board;
    }
    public void GenerateBoard(){
        Board board = new Board();
        
    }
}