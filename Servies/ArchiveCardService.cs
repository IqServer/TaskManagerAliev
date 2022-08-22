using models;
using testnet;

namespace services;

public class ArchiveCardService{

    readonly DataContext _context;
    public ArchiveCardService(DataContext context)
    {
        _context = context;

    }

    public List<ArchiveCard> GetArchiveCard(){
     var archivecard =  _context.ArchiveCards.ToList();

        return archivecard;
    }
    public void GenerateArchiveCard(){
        ArchiveCard archivecard = new ArchiveCard();
        
    }
}