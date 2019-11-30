using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public interface IDataAward
    {
        void Add(Award award);
        void Delete(Award award);
        void ReplaceData(Award award);
        ICollection<Award> GetAwards();
    }
}
