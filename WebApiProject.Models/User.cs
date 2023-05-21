using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiProject.Models
{
    public class User
    {
    [Key]
    public int UserId { get; set; }
    public string UserName { get; set; } 
    public string UserEmail { get; set; } 
    public string Password { get; set; } 
    public DateTime JoinDate { get; set; }

    //relationship
    public List<User_Project> User_Projects { get; set; }
    public virtual ICollection<Laptop> Laptops { get; set; }
  }
}
