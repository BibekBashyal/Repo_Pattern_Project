using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiProject.Models.Enum;

namespace WebApiProject.Models
{
  public class Laptop
  {
    [Key]
    public int LaptopID { get; set; }
    public string LaptopName { get; set; }
    public Rating Condition { get; set; }

    //Relationship
    public int UserId { get; set; } //one to many 'one user can have multiple technology'
    public User User { get; set; }

  }
  
}
