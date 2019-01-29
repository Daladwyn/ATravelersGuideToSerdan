using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ATravelersGuideToSerdan.Data;
using ATravelersGuideToSerdan.Models;

namespace ATravelersGuideToSerdan.Services
{
    public class SqlSerdan : ISerdan
    {
        private ApplicationDbContext _context;

        public SqlSerdan()
        {
        }

        public SqlSerdan(ApplicationDbContext context)
        {
            _context = context;
        }

        public Country GetCountry(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Country> GetMultipleCountries(int PlanetId)
        {
            throw new NotImplementedException();
        }

        public List<NPC> GetMultipleNPCs(int Id)
        {
            throw new NotImplementedException();
        }

        public List<NPC> GetMultipleNPCs(string race)
        {
            throw new NotImplementedException();
        }

        public List<Place> GetMultiplePlaces(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Planet> GetMultiplePlanets(int Id)
        {
            throw new NotImplementedException();
        }

        public NPC GetNPC(int Id)
        {
            // return _context.NPC.SingleOrDefault(i => i.NPCid == Id);
            throw new NotImplementedException();
        }

        public NpcMagic GetNPCMagic(int Id)
        {
            throw new NotImplementedException();
        }

        public NpcPower GetNpcPower(int Id)
        {
            throw new NotImplementedException();
        }

        public NpcStat GetNpcStat(int Id)
        {
            throw new NotImplementedException();
        }

        public Place GetPlace(int Id)
        {
            throw new NotImplementedException();
        }

        public Planet GetPlanet(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
