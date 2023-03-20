using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Task_4_SQLite.Model
{
    public class User
    {
        [Key]

        public int UserID { get; set; }
        public string Login { get; set; }
        public string UID { get; set; }
    }
}
