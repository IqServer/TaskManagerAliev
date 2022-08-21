using models;
using testnet;

namespace services;

public class UserService{

    readonly DataContext _context;
    public UserService(DataContext context)
    {
        _context = context;

    }

    public List<User> GetUsers(){
     var users =  _context.User.ToList();

        return users;
    }
    public void GenerateUser(){
        User user = new User();
        
    }
}
