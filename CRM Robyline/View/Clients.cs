using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_Robyline.View
{
    [Table("Clients")]
    class Clients
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [Column("Name")]
        public string Name { get; set; }
        [Column("Contact")]
        public int Contact { get; set; }
        [Column("Contact")]
        public string Site { get; set; }
    }
}
