using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_First_Demo.Model
{
   public class MyTable
    {
        [Key]
        public int EMP_NO { get; set; }
        public string EMP_FNAME { get; set; }

        public string EMP_LNAME { get; set; }
        public int EMP_DEPT { get; set; }
    }
}
