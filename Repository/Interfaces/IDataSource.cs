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
        public DbSet <Descendant> Descendant { get; set; }
        public DbSet <DescendantImage> DescendantImage { get; set; }
        public DbSet <Image> Image { get; set; }
        public DbSet <SpecialDate> SpecialDate { get; set; }
        public DbSet <SpecialEvent> SpecialEvent { get; set; }
        public DbSet <User> User { get; set; }
         

    }
}
