using models;
using Serilog.Core;
using testnet;

namespace services;

public class UserService{

    readonly DataContext _context;
    public UserService(DataContext context)
    {
        _context = context;

    }
        public List<User> GetAllUsers()
    {
        return _context.Users.ToList();

    }

        public void WipeAllUsers()
    {
        foreach (var item in GetAllUsers())
        {
            _context.Users.Remove(item);
        }
        _context.SaveChanges();
    }

        public void RemoveUser(int id, string oldPass)
    {
        User? user = _context.Users.FirstOrDefault(x => x.Id == id);
        if (user.Password == oldPass)
        {
            _context.Users.Remove(user);
            _context.SaveChanges();
        }
        else
        {
        }
        
    }

        public void AddUser(User user)
    {
        _context.Users.Add(user);
        _context.SaveChanges();
    }

        public User? GetUser(int id)
    {
        return _context.Users.FirstOrDefault(x => x.Id == id);
    }

        public void UpdatePass(int id,string oldPass, string newPass)
    {
        User? user = _context.Users.FirstOrDefault(x => x.Id == id);
        if (user.Password == oldPass)
        {   
            user.Password = newPass;
        }
        else
        {
        }

        _context.Users.Update(user);
        _context.SaveChanges();
    }

    public void GenerateUser(){
        User user = new User();
        
    }
}
