using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subd_1laba.Models1
{
    public class Production
    {
        [Key]
        public int ID { get; set; }
        public int product { get; set; }
        public double amount { get; set; }
        public DateTime? date { get; set; }
    }
}
