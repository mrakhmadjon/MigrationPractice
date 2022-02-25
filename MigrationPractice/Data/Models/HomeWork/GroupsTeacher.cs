using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigrationPractice.Data.Models.HomeWork
{
    public class GroupsTeacher : BaseModel
    {

        [ForeignKey(nameof(Teacher))]
        public int TeacherId { get; set; }

        [ForeignKey(nameof(Group))]
        public int GroupId { get; set; }


        public Teacher Teacher { get; set; }

        public Group Group { get; set; } 
    }
}
