using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.AdvertisementApp.Entities
{
    public class AppRole : BaseEntity, IEntity
    {
        public string Definition { get; set; }

        public List<AppUserRole> AppUserRoles { get; set; }
    }
}
