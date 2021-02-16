 using Microsoft.EntityFrameworkCore;
 using lesson6_handson.Models;

 namespace SimpleWebAPI.Models
 {
     public class CarContext : DbContext
     {
         public CarContext(DbContextOptions<CarContext> options)
             : base(options)
         {
         }

         public DbSet<Car> cars { get; set; }
     }
 }