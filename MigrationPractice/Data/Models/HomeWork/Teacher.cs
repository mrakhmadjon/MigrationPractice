using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigrationPractice.Data.Models
{
    public class Teacher : BaseModel
    {
        public string FullName { get; set; }

        public int Experience { get; set; }

        public string CardNumber { get; set; }
    }
}
