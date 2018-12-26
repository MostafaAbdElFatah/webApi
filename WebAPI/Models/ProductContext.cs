using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;


namespace WebAPI.Models
{
    public class ProductContext : DbContext
    {

        public DbSet<Product> Products { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            SqlConnectionStringBuilder connectionStringBuilder = new SqlConnectionStringBuilder()
            {
                DataSource = @"DESKTOP-L18DQ5J\SQLEXPRESS",
                InitialCatalog = "Productsdb",
                IntegratedSecurity = true
            };
            optionsBuilder.UseSqlServer(connectionStringBuilder.ToString());

            /*optionsBuilder
                .UseSqlServer(connectionStringBuilder.ToString(), providerOptions => providerOptions.CommandTimeout(60))
                .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);*/
        }
        
    }
}