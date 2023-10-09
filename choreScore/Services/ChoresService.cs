



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








}