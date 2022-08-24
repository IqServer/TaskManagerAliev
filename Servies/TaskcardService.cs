using models;
using testnet;

namespace services;

public class TaskCardService{

    readonly DataContext _context;
    public TaskCardService(DataContext context)
    {
        _context = context;

    }
    
    public void AddTaskCard(TaskCard newTaskCard)
    {
        _context.Add(newTaskCard);
        _context.SaveChanges();
        
    }
    


    public List<TaskCard> GetAllTaskCards()
    {
        return _context.TaskCards.Where(x => x.IsActive == true).ToList();
    }

        public TaskCard? GetTaskCard(int id)
    {
        TaskCard? project = _context.TaskCards.FirstOrDefault(x => x.Id == id && x.IsActive == true);
        return project;
    }

        public void RemoveTaskCard(int id)
    {
        TaskCard? taskcard = _context.TaskCards.FirstOrDefault(x => x.Id == id);
        _context.TaskCards.Remove(taskcard);
        _context.SaveChanges();
    }

        public void SetInactive(int id)
    {
        TaskCard taskcard = _context.TaskCards.FirstOrDefault(x => x.Id == id);
        taskcard.IsActive = false;
        _context.TaskCards.Update(taskcard);
        _context.SaveChanges();
    } 

        public void SetActive(int id)
    {
        TaskCard taskcard = _context.TaskCards.FirstOrDefault(x => x.Id == id);
        taskcard.IsActive = true;
        _context.TaskCards.Update(taskcard);
        _context.SaveChanges();
    }

         public void UpdateTaskCard(TaskCard taskcard)
    {
        _context.TaskCards.Update(taskcard);
        _context.SaveChanges();
    }


        public void WipeAllProjects()
    {
        foreach (var item in GetAllTaskCards())
        {
            _context.TaskCards.Remove(item);
        }
        _context.SaveChanges();
    }

    public void GenerateTaskCard(){
        TaskCard taskcard = new TaskCard();
        
    }

}