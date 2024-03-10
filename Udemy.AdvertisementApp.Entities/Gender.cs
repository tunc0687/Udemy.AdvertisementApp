using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.AdvertisementApp.Entities
{
    public class Gender: BaseEntity, IEntity
    {
        public string Definition { get; set; }

        public List<AppUser> AppUsers { get; set; }
    }
}
