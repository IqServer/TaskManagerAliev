namespace models
{
    public class Board
    {
        public int Id {get;set;}
        public string? Cards {get;set;}
        public int WorkspaceId  {get;set;} 
        public Workspace? workspace {get;set;}
    }
}