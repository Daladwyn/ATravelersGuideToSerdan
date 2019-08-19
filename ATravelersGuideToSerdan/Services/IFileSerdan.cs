using ATravelersGuideToSerdan.ViewModels;
using System.Collections.Generic;
using System.IO;

namespace ATravelersGuideToSerdan.Services
{
    public interface IFileSerdan
    {
        string CreateCharacterSheet(CreatePlayer1ViewModel CharacterToPrint);
    }
}
