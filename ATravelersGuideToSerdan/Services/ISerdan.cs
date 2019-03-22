using ATravelersGuideToSerdan.Models;
using System.Collections.Generic;

namespace ATravelersGuideToSerdan.Services
{
    public interface ISerdan
    {
        NPC GetNPC(int id);
        NPC AddNPC(NPC NonPlayerCharacter);
        List<NPC> GetMultipleNPCs(string race);
        NpcMagic GetNPCMagic(int id);
        NpcMagic AddNPCMagic(NpcMagic npcMagic);
        NpcMagic UpdateNPCMagic(int id, NpcMagic npcMagic);
        NpcPower GetNpcPower(int id);
        NpcPower AddNPCPower(NpcPower npcPower);
        NpcPower UpdateNPCPower(int id, NpcPower npcPower);
        NpcStat GetNpcStat(int id);
        NpcStat AddNPCStat(NpcStat npcStat);
        NpcStat UpdateNPCStat(int id, NpcStat npcStat);
        Planet GetPlanet(int id);
        List<Planet> GetAllPlanets();
        Country GetCountry(int id);
        List<Country> GetMultipleCountries(int PlanetId);
        Place GetPlace(int id);
        List<Place> GetMultiplePlaces(int CountryId);
    }
}
