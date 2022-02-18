using System.ComponentModel.DataAnnotations;

namespace ToDoListApi.Models
{
    public class ToDoItem
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }


    }
}
