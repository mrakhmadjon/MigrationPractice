using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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


        [ForeignKey(nameof(Subject))]
        public int SubjectId { get; set; }

        public Subject Subject { get; set; }
    }
}
