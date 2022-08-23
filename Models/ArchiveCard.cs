namespace models
{
    public class ArchiveCard
    {
        public int Id {get;set;}
        public string? Cards {get;set;}
        public int TaskCardId {get;set;}
        public TaskCard? TaskCard {get;set;}
    }
}