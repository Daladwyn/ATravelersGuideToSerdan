using ATravelersGuideToSerdan.ViewModels;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;

namespace ATravelersGuideToSerdan.Services
{
    public interface IFileSerdan
    {
        //HttpResponseMessage CreateCharacterSheet(CreatePlayer1ViewModel CharacterToPrint);
        string CreateCharacterSheet(CreatePlayer1ViewModel CharacterToPrint);
    }
}
