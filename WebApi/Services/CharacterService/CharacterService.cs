using System.Collections.Generic;
using System.Linq;
using WebApi.Models;

namespace WebApi.Services.CharacterService
{
    public class CharacterService : ICharacterService
    {
        public static List<Character> characters = new List<Character> {
            new Character(),
            new Character{Id = 1, Name = "Sam"}
        };
        
        public List<Character> AddCharacter(Character newCharacter)
        {
            characters.Add(newCharacter);
            return characters;
        }

        public List<Character> GetAllCharacters()
        {
            return characters;
        }

        public Character GetCharacterByID(int id)
        {
            return characters.FirstOrDefault(c => c.Id == id);
        }
    }
}