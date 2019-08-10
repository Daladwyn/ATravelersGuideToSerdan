using ATravelersGuideToSerdan.ViewModels;
using System.Collections.Generic;

namespace ATravelersGuideToSerdan.Services
{
    public interface IFileSerdan
    {
        string CreateCharacterSheet(CreatePlayer1ViewModel CharacterToPrint, string filepath);
    }
}
