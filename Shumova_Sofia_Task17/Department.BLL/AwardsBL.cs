using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Department.DAL;
using Entities;

namespace Department.BLL
{
    public class AwardsBL
    {
        private IDataAward awards;
        
        public AwardsBL(IDataAward data)
        {
            awards =data;
           // InitList();
        }

        private void InitList()
        {
            awards.Add(new Award("Нобелевская премия"));
            awards.Add(new Award("Премия Тьюринга"));
            awards.Add(new Award("Оскар"));
            awards.Add(new Award("Международная премия по биологии"));
        }

        public ICollection<Award> Awards
        {
            get
            {
                return awards.GetAwards();
            }
        }

        public void AddAward(Award award)
        {
            awards.Add(award);
        }
        public void DeleteAward(Award award)
        {
            awards.Delete(award);
        }

        public void ReplaceData(Award award)
        {
            awards.ReplaceData(award);
        }

        public Award GetAward(int ID)
        {
            //int index = awards.GetAwards().ToList().FindIndex();
            return awards.GetAwards().ToList().Find(item => item.ID == ID);
        }

    }
}
