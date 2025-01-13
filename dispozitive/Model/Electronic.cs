using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;


namespace Electronice.dispozitive.Model
{
    [Table("electronics")]
    public class Electronic
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public int Id { get; set; }

        [Required]
        [Column("Dispozitiv")]
        public string Dispozitiv { get; set; }


        [Required]
        [Column("Model")]
        public string Model { get; set; }

        [Required]
        [Column("Memory")]
        public int Memory { get; set; }

        [Required]
        [Column("Price")]
        public double Price { get; set; }








    }
}
