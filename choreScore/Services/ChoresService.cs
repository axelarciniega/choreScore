



using choreScore.Models;

namespace choreScore.Services;


public class ChoresService
{

    private readonly ChoresRepository _repo;

    public ChoresService(ChoresRepository repo)
    {
        _repo = repo;
    }



    internal List<Chore> GetChores()
    {
        List<Chore> Chores = _repo.GetAllChores();
        return Chores;
    }

    internal Chore GetOneChoreById(int choreId)
    {
        Chore chore = _repo.GetOneChoreById(choreId);
        if (chore = null) throw new Exception($"no chore with that id {choreId}");
        return chore
    }








}