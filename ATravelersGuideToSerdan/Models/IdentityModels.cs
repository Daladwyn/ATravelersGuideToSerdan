//using System.Security.Claims;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Identity;
//using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore;

//namespace ATravelersGuideToSerdan.Models
//{
//    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
//    public class ApplicationUser : IdentityUser
//    {
//        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
//        {
//            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
//            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
//            // Add custom user claims here
//            return userIdentity;
//        }
//    }

//    public class SerdanDb : IdentityDbContext<ApplicationUser>
//    {
//        public SerdanDb()
//            : base("DefaultConnection", throwIfV1Schema: false)
//        {
//        }

//        public static SerdanDb Create()
//        {
//            return new SerdanDb();
//        }

//        public DbSet<NPC> NPCs { get; set; }
//        public DbSet<NpcStat> NpcStats { get; set; }
//        public DbSet<NpcPower> NpcPowers { get; set; }
//        public DbSet<NpcMagic> NpcMagics { get; set; }
//        public DbSet<Planet> Planets { get; set; }
//        public DbSet<Country> Countries { get; set; }
//        public DbSet<City> Cities { get; set; }
//        public DbSet<Place> Places { get; set; }

//    }
//}