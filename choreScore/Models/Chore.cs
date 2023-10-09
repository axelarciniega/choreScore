


public class Chore
{
    public int Id { get; set; }
    public string Name { get; set; }

    public bool Done { get; set; }

    public Chore(int id, string name, bool done)
    {
        Id = id;
        Name = name;
        Done = done;
    }


}