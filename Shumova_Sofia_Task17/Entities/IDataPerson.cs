using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public interface IDataPerson
    {
        void AddPerson(Person person);
        void ReplaceData(Person person);
        void DeletePerson(Person person);
        void AddAwardPerson(Person person, Award award);

        ICollection<Person> GetPeople();
        ICollection<Award> GetAwardsForPerson(Person person);
    }
}
