using System.Collections.Generic;
using WebApi.Models;

namespace WebApi.Services.CharacterService
{
    public interface ICharacterService
    {
        List<Character> GetAllCharacters();
        Character GetCharacterByID(int id);
        List<Character> AddCharacter(Character newCharacter);
    }
}