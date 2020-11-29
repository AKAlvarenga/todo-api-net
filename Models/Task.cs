using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace todo_api_net.Models
{
  public class Task
  {
    [Key]
    public int Id { get; set; }
    [DataType(DataType.Text), MaxLength(50)]
    public string Description { get; set; }
    [DefaultValue(false)]
    public bool Completed { get; set; }
  }
}