using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryExample.Models
{
    public class Product

    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int InstanceId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedTimestamp { get; set; }
        public virtual ICollection<ImageURI> ImageURIs { get; set; }
        public virtual ICollection<SKU> ValidSKUs { get; set; }
        public virtual ICollection<Category> Categories { get; set; }
        public virtual ICollection<CustomProperty> Attributes { get; set; }


    }
}
