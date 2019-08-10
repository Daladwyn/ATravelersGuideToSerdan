using System;
using System.Collections.Generic;
using System.Text;
using ATravelersGuideToSerdan.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ATravelersGuideToSerdan.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        public DbSet<NPC> NPCs { get; set; }
        public DbSet<NpcStat> NpcStats { get; set; }
        public DbSet<NpcPower> NpcPowers { get; set; }
        public DbSet<NpcMagic> NpcMagics { get; set; }
        public DbSet<Planet> Planets { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Place> Places { get; set; }
        public DbSet<NpcAlly> NpcAllies { get; set; }
        public DbSet<NpcEnemy> NpcEnemies { get; set; }
        public DbSet<NpcFriend> NpcFriends { get; set; }
        public DbSet<NpcRival> NpcRivals { get; set; }
        public DbSet<NpcsSerdanEdlosiChild> NpcsSerdanEdlosiChldren { get; set; }
        public DbSet<NpcsRegularChild> NpcsRegularChildren { get; set; }
        public DbSet<PlayingCharacter> PlayingCharacter { get; set; }


    }
}