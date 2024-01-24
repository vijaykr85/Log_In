using System.ComponentModel.DataAnnotations;

namespace Log_In.Models
{
    public class Product

    {
        
            [Key]
            public int id { get; set; }

            public string name { get; set; }

            public string brand { get; set; }

            public int quantity { get; set; }

            public byte[] image { get; set; }
    }
    
}
