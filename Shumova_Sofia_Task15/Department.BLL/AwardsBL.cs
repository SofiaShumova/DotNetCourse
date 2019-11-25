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
        private AwardsDAO awards;
        
        public AwardsBL()
        {
            awards = new AwardsDAO();
            InitList();
        }

        private void InitList()
        {
            awards.Add("Нобелевская премия");
            awards.Add("Премия Тьюринга");
            awards.Add("Оскар");
            awards.Add("Международная премия по биологии");
        }

        public List<Award> Awards
        {
            get
            {
                return awards.ListAwards;
            }
        }

        public void AddAward(string name)
        {
            awards.Add(new Award(name));
        }
        public void AddAward(Award award)
        {
            awards.Add(award);
        }
        public void AddAward(string name, string desc)
        {
            awards.Add(new Award(name, desc));
        }

        public void DeleteAward(int ID)
        {
            awards.Delete(ID);
        }
        public void DeleteAward(Award award)
        {
            awards.Delete(award.ID);
        }

        public void ReplaceData(int oldID, string newName, string newDesc)
        {
            int index = awards.ListAwards.FindIndex(item => item.ID == oldID);
            awards[index].Name = newName;
            awards[index].Description = newDesc;
        }
        public void ReplaceData(Award award)
        {
            int index = awards.ListAwards.FindIndex(item => item.ID == award.ID);
            awards[index].Name = award.Name;
            awards[index].Description = award.Description;
        }

        public Award GetAward(int ID)
        {
            int index = awards.ListAwards.FindIndex(item => item.ID == ID);
            return awards.ListAwards[index];
        }

    }
}
