using models;
using testnet;

namespace services;

public class WorkSpaceService{

    readonly DataContext _context;
    public WorkSpaceService(DataContext context)
    {
        _context = context;

    }

    public List<Workspace> GetWorkSpaces(){
     var workspaces =  _context.Workspaces.ToList();

        return workspaces;
    }
    public void GenerateUser(){
        Workspace workSpace = new Workspace();
        
    }

    internal void GenerateWorkSpace()
    {
        throw new NotImplementedException();
    }
}
