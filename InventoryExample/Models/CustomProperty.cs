using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryExample.Models
{
    public class CustomProperty
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int InstanceId { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
    }
}
