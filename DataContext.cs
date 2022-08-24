using Microsoft.EntityFrameworkCore;
using models;

namespace testnet
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
           
        }
        public DbSet<User> Users {get;set;}
        public DbSet<Board> Boards {get;set;}
        public DbSet<Workspace> Workspaces {get;set;}
        public DbSet<TaskCard> TaskCards {get;set;}
        public DbSet<ChatUser> ChatUsers {get;set;}
        public DbSet<ArchiveCard> ArchiveCards {get;set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //модификация таблиц в бд
        }

    }


}