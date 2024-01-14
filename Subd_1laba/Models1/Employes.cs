using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subd_1laba.Models1
{
    public class Employes
    {
        [Key]
        public int ID { get; set; }
        public string name { get; set; }
        public int role { get; set; }
        public double salary { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
    }
}
