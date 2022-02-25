using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigrationPractice.Data.Models
{
    public class Group : BaseModel
    {
        public string Name { get; set; }

       
    }
}
