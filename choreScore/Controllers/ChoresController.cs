


[ApiController]
[Route("api/chores")]

public class ChoresController : ControllerBase
{

    private readonly ChoresService _choresService;
    public ChoresController(ChoresService cs)
    {
        _choresService = cs;
    }


    [HttpGet]
    public ActionResult<List<Chore>> GetChores()
    {
        try
        {
            List<Chore> chores = _choresService.GetChores();
            return Ok(chores);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }



    [HttpGet]
    public ActionResult<Chore> GetOneChoreById(int choreId)
    {
        try
        {
            Chore chore = _choresService.GetOneChoreById(choreId);
            return chore
        }
        catch (Exception e)
        {
            return BadRequest(e.Message)
        }
    }














}