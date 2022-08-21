using models;
using testnet;

namespace services;

public class TaskCardService{

    readonly DataContext _context;
    public TaskCardService(DataContext context)
    {
        _context = context;

    }

    public List<TaskCard> GetTaskCards(){
     var taskcards =  _context.TaskCards.ToList();

        return taskcards;
    }
    public void GenerateTaskCard(){
        TaskCard taskcard = new TaskCard();
        
    }
}