

public class ChoresRepository
{

    private List<Chore> _FakeDb;


    public ChoresRepository()
    {
        _FakeDb = new List<Chore>();
        _FakeDb.Add(new Chore(1, "clean the dishes", true));
        _FakeDb.Add(new Chore(2, "clean car", false));
        _FakeDb.Add(new Chore(3, "do homework", false));
    }




    internal List<Chore> GetAllChores()
    {
        return _FakeDb;
    }







}