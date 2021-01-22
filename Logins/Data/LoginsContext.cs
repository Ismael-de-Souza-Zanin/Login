using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Logins.Models;

namespace Logins.Data
{
    public class LoginsContext : DbContext
    {
        public LoginsContext (DbContextOptions<LoginsContext> options)
            : base(options)
        {
        }

        public DbSet<Logins.Models.Book> Book { get; set; }
    }
}
