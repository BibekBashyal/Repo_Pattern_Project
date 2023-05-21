using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiProject.Models;

namespace WebApiProject.DAL
{
    public class AppDbContext:DbContext
    {
    public AppDbContext(DbContextOptions<AppDbContext> options) :base(options) 
    {
          
    }
    public DbSet<User> Users { get; set; }
    public DbSet<User_Project> User_Projects { get; set; }
    public DbSet<Project> Projects { get; set; }
    public DbSet<Laptop> Laptops { get; set; }
  }
}
