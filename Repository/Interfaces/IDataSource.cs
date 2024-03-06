using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Repository.Entities;
namespace Repository.Interfaces
{
    public interface IDataSource 
    {
        int SaveChanges();
        public DbSet <CalenderYear> CalenderYear { get; set; }
        public DbSet <CalenderUser> CalenderUser { get; set; }
        public DbSet <Level> Level { get; set; }
        public DbSet <Calender> Calender { get; set; }
        public DbSet <User> User { get; set; }
        public DbSet <YearEvent> YearEvent { get; set; }
        public DbSet <UserType> UserType { get; set; }
        public DbSet <Event> Event { get; set; }
      
         

    }
}
