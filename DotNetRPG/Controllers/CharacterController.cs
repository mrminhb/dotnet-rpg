using DotNetRPG.Models;
using Microsoft.AspNetCore.Mvc;

namespace DotNetRPG.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CharacterController : ControllerBase
{
    private static readonly List<Character> Characters = new List<Character>
    {
        new Character{ Id = 0, Name = "Xeno", Job = Job.Warrior},
        new Character{ Id = 1, Name = "Raiza", Job = Job.WhiteMage},
        new Character{ Id = 2, Name = "Bibi", Job = Job.BlackMage},
        new Character{ Id = 3, Name = "Lonnie", Job = Job.Bard},
    };

    [HttpGet]
    public ActionResult<List<Character>> Get()
    {
        return Ok(Characters);
    }

    [HttpGet("{id:int}")]
    public ActionResult<Character> GetById(int id)
    {
        return Ok(Characters.FirstOrDefault(c => c.Id == id));
    }

    [HttpPost]
    public ActionResult<List<Character>> AddCharacter(Character newCharacter)
    {
        Characters.Add(newCharacter);
        return Ok(Characters);
    }
}