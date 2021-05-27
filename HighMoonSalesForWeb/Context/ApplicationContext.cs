using Covid19_Services_Backend.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Covid19_Services_Backend.Context
{
    public class ApplicationContext:DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            :base(options)
        {

        }

        public ApplicationContext()
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);


            //read country details from external API and fill initial data
            var countries = GetCountry();
            int i = 1;
             foreach(var country in countries)
            {
                modelBuilder.Entity<Country>().HasData(new Country
                {
                    CountryId = i,
                    Name = country.Country,
                    Slug = country.Slug,
                    CountryCode = country.ISO2
                }); ;
                i++;

            }

            // confirmed, recovered, deaths  , initial database with master data
            modelBuilder.Entity<StatusOfCase>().HasData(new StatusOfCase { StatusOfCaseId = 1, Name = "confirmed" });
            modelBuilder.Entity<StatusOfCase>().HasData(new StatusOfCase { StatusOfCaseId = 2, Name = "recovered" });
            modelBuilder.Entity<StatusOfCase>().HasData(new StatusOfCase { StatusOfCaseId = 3, Name = "deaths" });


            //testing data
            modelBuilder.Entity<Case>().HasData(new Case { CaseId = 1, CountryId = 1, Date = DateTime.Now, Lat = 1.2, Lon = 1.3, NumberOfCases = 5, StatusId = 1 });
            modelBuilder.Entity<Case>().HasData(new Case { CaseId = 2, CountryId = 1, Date = DateTime.Now, Lat = 1.2, Lon = 1.3, NumberOfCases = 15, StatusId = 2 });
            modelBuilder.Entity<Case>().HasData(new Case { CaseId = 3, CountryId = 2, Date = DateTime.Now, Lat = 1.2, Lon = 1.3, NumberOfCases = 5, StatusId = 1 });
            modelBuilder.Entity<Case>().HasData(new Case { CaseId = 4, CountryId = 5, Date = DateTime.Now, Lat = 1.2, Lon = 1.3, NumberOfCases = 35, StatusId = 1 });

            modelBuilder.Entity<Case>().HasData(new Case { CaseId = 5, CountryId = 1, Date = DateTime.Now, Lat = 1.2, Lon = 1.3, NumberOfCases = 5, StatusId = 1 });
            modelBuilder.Entity<Case>().HasData(new Case { CaseId = 6, CountryId = 1, Date = DateTime.Now, Lat = 1.2, Lon = 1.3, NumberOfCases = 15, StatusId = 2 });
            modelBuilder.Entity<Case>().HasData(new Case { CaseId = 7, CountryId = 2, Date = DateTime.Now, Lat = 1.2, Lon = 1.3, NumberOfCases = 5, StatusId = 1 });
            modelBuilder.Entity<Case>().HasData(new Case { CaseId = 8, CountryId = 5, Date = DateTime.Now, Lat = 1.2, Lon = 1.3, NumberOfCases = 35, StatusId = 1 });

            modelBuilder.Entity<Case>().HasData(new Case { CaseId = 9, CountryId = 1, Date = DateTime.Now, Lat = 1.2, Lon = 1.3, NumberOfCases = 5, StatusId = 1 });
            modelBuilder.Entity<Case>().HasData(new Case { CaseId = 10, CountryId = 1, Date = DateTime.Now, Lat = 1.2, Lon = 1.3, NumberOfCases = 15, StatusId = 2 });
            modelBuilder.Entity<Case>().HasData(new Case { CaseId = 11, CountryId = 2, Date = DateTime.Now, Lat = 1.2, Lon = 1.3, NumberOfCases = 5, StatusId = 1 });
            modelBuilder.Entity<Case>().HasData(new Case { CaseId = 12, CountryId = 5, Date = DateTime.Now, Lat = 1.2, Lon = 1.3, NumberOfCases = 35, StatusId = 1 });

            // context.Database.EnsureCreated();
        }
        public class countryResource
        {
            public string Country { get; set; }
            public string Slug { get; set; }
            public string ISO2 { get; set; }

        }

        public List<countryResource> GetCountry()    
        {
            var client = new RestClient($"https://api.covid19api.com/countries");
            var request = new RestRequest(Method.GET);
            IRestResponse response =  client.Execute(request);
            var odosRecord = JsonConvert.DeserializeObject<List<countryResource>>(response.Content);



            //TODO: transform the response here to suit your needs
            return odosRecord;
           
        }



        public DbSet<StatusOfCase> Statuses { get; set; }

        public DbSet<Country> Countries { get; set; }

        public DbSet<Case> Cases { get; set; }
    }
}
