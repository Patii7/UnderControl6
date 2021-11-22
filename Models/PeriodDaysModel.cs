using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace UnderControl.Models
{
    public class PeriodDaysModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateTime AddDate { get; set; } = DateTime.Now.Date;
        public ApplicationUser User { get; set; }
    }
}
