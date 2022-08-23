namespace models
{
    public class Workspace
    {
        public int Id {get;set;}
        public string? Name {get;set;}
        public string? Listofparticipants {get;set;}
        public string? ScrumBoards {get;set;}
        public string? Chat {get;set;}
        public int BoardId {get;set;}
        public Board? board {get;set;}
        public int ChatUserId {get;set;}
        public ChatUser? chatUser {get;set;}
    }
}