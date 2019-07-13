using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ATravelersGuideToSerdan.Data;
using ATravelersGuideToSerdan.Models;

namespace ATravelersGuideToSerdan.Services
{
    public class SqlSerdan : _DB
    {
        private ApplicationDbContext _context;

        public SqlSerdan()
        {
        }

        public SqlSerdan(ApplicationDbContext context)
        {
            _context = context;
        }

        public NPC AddNPC(NPC nonPlayerCharacter)
        {
            _context.NPCs.Add(nonPlayerCharacter);
            _context.SaveChanges();
            return nonPlayerCharacter;
        }

        public NpcMagic AddNPCMagic(NpcMagic npcMagic)
        {
            _context.NpcMagics.Add(npcMagic);
            _context.SaveChanges();
            return npcMagic;
        }

        public NpcPower AddNPCPower(NpcPower npcPower)
        {
            _context.NpcPowers.Add(npcPower);
            _context.SaveChanges();
            return npcPower;
        }

        public NpcStat AddNPCStat(int id, NpcStat npcStat)
        {
            _context.NpcStats.Add(npcStat);
            _context.SaveChanges();
            return npcStat;
        }

        public NpcStat AddNPCStat(NpcStat npcStat)
        {
            throw new NotImplementedException();
        }

        public PlayingCharacter AddPlayingCharacter(PlayingCharacter NewCharacter)
        {
           
            throw new NotImplementedException();
        }

        public List<Planet> GetAllPlanets()
        {
            List<Planet> AllPlanets = _context.Planets.ToList();
            return AllPlanets;
        }

        public Country GetCountry(int id)
        {
            return _context.Countries.SingleOrDefault(p => p.PlanetId == id);

        }

        public List<Country> GetMultipleCountries(int PlanetId)
        {
            List<Country> allCountriesOnAPlanet = _context.Countries.Where(p => p.PlanetId == PlanetId).ToList();
            return allCountriesOnAPlanet;
        }

        public List<NPC> GetMultipleNPCs(int id)
        {
            throw new NotImplementedException();
        }

        public List<NPC> GetMultipleNPCs(string race)
        {
            List<NPC> AllCharactersOfARace = _context.NPCs.Where(r => r.NpcRace == race).ToList();
            return AllCharactersOfARace;
        }

        public List<Place> GetMultiplePlaces(int id)
        {
            throw new NotImplementedException();
        }

        public List<Planet> GetMultiplePlanets(int id)
        {
            throw new NotImplementedException();
        }

        public NPC GetNPC(int id)
        {
            return _context.NPCs.SingleOrDefault(i => i.NpcId == id);
        }

        public NpcMagic GetNPCMagic(int id)
        {
            return _context.NpcMagics.SingleOrDefault(m => m.NpcId == id);
        }

        public NpcPower GetNpcPower(int id)
        {
            return _context.NpcPowers.SingleOrDefault(p => p.NpcId == id);
        }

        public NpcStat GetNpcStat(int id)
        {
            return _context.NpcStats.SingleOrDefault(s => s.NpcId == id);
        }

        public Place GetPlace(int id)
        {
            return _context.Places.SingleOrDefault(p => p.PlaceId == id);
        }

        public Planet GetPlanet(int id)
        {
            return _context.Planets.SingleOrDefault(p => p.PlanetId == id);
        }

        public NpcMagic UpdateNPCMagic(int id, NpcMagic npcMagic)
        {
            _context.NpcMagics.Attach(npcMagic);
            _context.SaveChanges();
            return npcMagic;
        }

        public NpcPower UpdateNPCPower(int id, NpcPower npcPower)
        {
            _context.NpcPowers.Attach(npcPower);
            _context.SaveChanges();
            return npcPower;
        }

        public NpcStat UpdateNPCStat(int id, NpcStat npcStat)
        {
            _context.NpcStats.Attach(npcStat);
            _context.SaveChanges();
            return npcStat;
        }
    }
}
