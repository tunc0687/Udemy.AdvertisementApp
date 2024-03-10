using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.AdvertisementApp.Entities;

namespace Udemy.AdvertisementApp.DataAccess.Contexts
{
    public class AdvertisementContext : DbContext
    {
        public AdvertisementContext(DbContextOptions<AdvertisementContext> options) : base(options)
        {
        }

        public DbSet<Advertisement> Advertisements { get; set; }
        public DbSet<AdvertisementAppUser> AdvertisementUsers { get; set; }
        public DbSet<AdvertisementAppUserStatus> AdvertisementUserStatuses { get; set; }
        public DbSet<AppRole> AppRoles { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<AppUserRole> AppUserRoles { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<MilitaryStatus> MilitaryStatuses { get; set; }
        public DbSet<ProvidedService> ProvidedServices { get; set; }
    }
}
