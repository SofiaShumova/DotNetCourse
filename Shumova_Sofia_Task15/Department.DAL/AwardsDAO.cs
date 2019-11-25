using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Department.DAL
{
    public class AwardsDAO
    {
        private List<Award> listAward = new List<Award>();

        public void Add(string name)
        {
            if(listAward != null)
            {
                listAward.Add(new Award(name));
            }
            else
            {
                throw new Exception();
            }
           
        }
        public void Add(string name, string desc)
        {
            if (listAward != null)
            {
                listAward.Add(new Award(name, desc));
            }
            else
            {
                throw new Exception();
            }
        }

        public void Add(Award award)
        {
            if (listAward != null)
            {
                listAward.Add(award);
            }
            else
            {
                throw new Exception();
            }
        }


        public void Delete(int IDAward)
        {

            if (listAward != null)
            {
                listAward.RemoveAt(listAward.FindIndex(item => item.ID == IDAward));
            }
            else
            {
                throw new Exception();
            }  
        }

        public List<Award> ListAwards
        {
            get
            {
                return listAward;
            }
        }

        public Award this[int index]
        {
            get { return listAward[index]; }
        }
    }
}
