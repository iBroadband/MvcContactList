using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MvcContactList.Models
{
    public class MvcContactListContext : DbContext
    {
        public MvcContactListContext (DbContextOptions<MvcContactListContext> options)
            : base(options)
        {
        }

        public DbSet<MvcContactList.Models.Contact> Contact { get; set; }
    }
}
