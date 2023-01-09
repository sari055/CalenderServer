using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Microsoft.Extensions.DependencyInjection;
using Repository;
using Repository.Entities;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbContext = Microsoft.EntityFrameworkCore.DbContext;

namespace Repository
{
    public class SqlDataSource : DbContext, IDataSource
    {
        public SqlDataSource(DbContextOptions<SqlDataSource> options) : base(options)
        {
        }
        //public SqlDatasource(DbContextOptions options) : base(options)
        //{
        //}
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("");
        //}

        //public void ConfigureServices(IServiceCollection services)
        //{
        //    services.AddDbContext<SqlDatasource>(options => options.UseSqlServer( ));
        //}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Data Source=sqlsrv;Initial Catalog=#calender_project;Integrated Security=True;TrustServerCertificate=True");

            base.OnConfiguring(optionsBuilder);
        }
        protected override void ConfigureConventions(ModelConfigurationBuilder builder)
        {
            builder.Properties<DateOnly>()
                .HaveConversion<DateOnlyConverter>()
                .HaveColumnType("date");
        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<User>()
        //        .Property(i => i.UserId)
        //        .HasColumnName("IDD");
        //}
        public override int SaveChanges()
        {
            return base.SaveChanges();
        }
        public Microsoft.EntityFrameworkCore.DbSet<Descendant> Descendant { get; set; }
        public  Microsoft.EntityFrameworkCore.DbSet<DescendantImage> DescendantImage { get; set; }
        public  Microsoft.EntityFrameworkCore.DbSet<Image> Image { get; set; }
        public  Microsoft.EntityFrameworkCore.DbSet<SpecialDate> SpecialDate { get; set; }
        public  Microsoft.EntityFrameworkCore.DbSet<SpecialEvent> SpecialEvent { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<User> User { get; set; }

    }
    public class DateOnlyConverter : ValueConverter<DateOnly, DateTime>
    {
        /// <summary>
        /// Creates a new instance of this converter.
        /// </summary>
        public DateOnlyConverter() : base(
                d => d.ToDateTime(TimeOnly.MinValue),
                d => DateOnly.FromDateTime(d))
        { }
    }
}
