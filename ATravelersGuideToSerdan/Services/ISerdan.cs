using ATravelersGuideToSerdan.Models;
using System.Collections.Generic;

namespace ATravelersGuideToSerdan.Services
{
    public interface ISerdan
    {
        NPC GetNPC(int Id);
        List<NPC> GetMultipleNPCs(string race);
        NpcMagic GetNPCMagic(int Id);
        NpcPower GetNpcPower(int Id);
        NpcStat GetNpcStat(int Id);
        Planet GetPlanet(int Id);
        List<Planet> GetMultiplePlanets(int Id);
        Country GetCountry(int Id);
        List<Country> GetMultipleCountries(int PlanetId);
        Place GetPlace(int Id);
        List<Place> GetMultiplePlaces(int CountryId);
    }
}
