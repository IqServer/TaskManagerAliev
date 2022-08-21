using models;
using testnet;

namespace services;

public class ChatUserService{

    readonly DataContext _context;
    public ChatUserService(DataContext context)
    {
        _context = context;

    }

    public List<ChatUser> GetChatUsers(){
     var chatuser =  _context.ChatUsers.ToList();

        return chatuser;
    }
    public void GenerateChatUser(){
        ChatUser chatuser = new ChatUser();
        
    }
}