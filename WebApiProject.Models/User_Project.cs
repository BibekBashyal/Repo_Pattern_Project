using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiProject.Models
{
  public class User_Project
  {
    [Key]
    public int UserProjectId { get; set; }
    public int UserId { get; set; } ///tala user bhayesi ef le aafai foreign
    //key bhanera bujxa or we can use data notation  
    //[ForeignKey("UserId")]
    public User User { get; set; }
    public int ProjectId { get; set; } 
    public Project Project { get; set; }
  }
}
