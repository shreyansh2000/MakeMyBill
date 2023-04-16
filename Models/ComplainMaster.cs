using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MakeMyBill.Models
{
    public class ComplainMaster
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Complainid { get; set; }

        public int Companyid { get; set; }

        
        [Column(TypeName = "varchar(200)")]
        public string Cdetails { get; set; }
    }
}
