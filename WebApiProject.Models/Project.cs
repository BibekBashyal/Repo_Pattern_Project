using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiProject.Models
{
  public class Project
  {
    [Key]
    public int ProjectId { get; set; }
    public string ProjectName { get; set; }
    public string ProjectDescription { get; set; }
    //relationship
    public List<User_Project> User_Projects { get; set; }
  }
}
