using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace netcore.Models
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> Categories { get; }
    }
}
