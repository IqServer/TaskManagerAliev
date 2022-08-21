namespace models
{
    public class TaskCard
    {
        public int Id {get;set;}
        public string? Title {get;set;}
        public string? Description {get;set;}
        public string? Attachedparticipants {get;set;}
        public string? Comments {get;set;}
        public string? Attachedfiles {get;set;}
        public string? Tag {get;set;}
        public string? Duedate {get;set;}
        public string? levelofcriticality {get;set;}
        public Board? board {get;set;}
        public Workspace? workspace {get;set;}
        public ArchiveCard? archivecard {get;set;}
        
    }
}