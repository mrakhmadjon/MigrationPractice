using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigrationPractice.Data.Models
{
    public class Student : BaseModel
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }


        [ForeignKey(nameof(Group))]
        public int GroupId { get; set; }

        public Group Group { get; set; }
    }
}
