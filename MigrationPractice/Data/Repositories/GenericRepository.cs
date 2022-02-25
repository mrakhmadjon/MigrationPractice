using MigrationPractice.Data.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigrationPractice.Data.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T :class
    {

    }
}
