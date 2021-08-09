using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models;
using WebApi.Services.CharacterService;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharacterController : ControllerBase
    {
        private readonly ICharacterService _characterService;

        public CharacterController(ICharacterService characterService)
        {
            _characterService = characterService;
        }

        [HttpGet("GetAll")]
        public ActionResult<List<Character>> Get(){
            return Ok(_characterService.GetAllCharacters());
        }

        [HttpGet("{id}")]
        public ActionResult<Character> GetSingle(int id){
            return Ok(_characterService.GetCharacterByID(id));
        }

        [HttpPost]
        public ActionResult<List<Character>> AddCharacter(Character newCharacter){
            return Ok(_characterService.AddCharacter(newCharacter));
        }
    }
}