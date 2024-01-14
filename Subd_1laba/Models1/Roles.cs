using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subd_1laba.Models1
{
    public class Roles
    {
        [Key]
        public int ID { get; set; }
        public string name { get; set; }
    }
}
