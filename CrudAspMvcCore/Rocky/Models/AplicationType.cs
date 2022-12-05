using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Rocky.Models
{
    public class ApplicationType

    {
        [Key]//  FK
        public int Id { get; set; }

          [Required]
          public String Name { get; set; }


    }
}
