using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subd_1laba.Models1
{
    public class Purchase
    {
        [Key]
        public int ID { get; set; }
        public int material { get; set; }
        public int employye { get; set; }
        public double amount { get; set; }
        public double cost { get; set; }
        public DateTime date { get; set; }
    }
}
