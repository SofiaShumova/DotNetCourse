using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Department.DAL
{
    public class AwardsDAO : IDataAward
    {
        private List<Award> collectionAwards = new List<Award>();


        public void Add(Award award)
        {
          collectionAwards.Add(award);
           
        }

        public void Delete(Award award)
        {
            collectionAwards.Remove(award);
        }

        public ICollection<Award> GetAwards()
        {
          return collectionAwards;
           
        }
        public void ReplaceData(Award award)
        {
            int index = collectionAwards.FindIndex(item => item.ID == award.ID);
            collectionAwards[index].Name = award.Name;
            collectionAwards[index].Description = award.Description;
        }
        public Award this[int index]
        {
            get { return collectionAwards[index]; }
        }
    }
}
