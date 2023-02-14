using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchMaker
{
    class MatchMaker
    {
        private string sex;
        private string age;
        private string occupation;

        private string hobbies;
        private string peeves;

        public MatchMaker()
        {
        }
        public MatchMaker(string s, string a, string occ, string hob, string p)
        {
            sex = s;
            age = a;
            occupation = occ;
           
            hobbies = hob;
            peeves = p;
        }
        
        public string Sex
        {
            get
            {
                return sex;
            }
            set
            {
                sex = value;
            }
        }
        public string Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
        public string Occupation
        {
            get
            {
                return occupation;
            }
            set
            {
                occupation = value;
            }
        }
        
        
        public string Hobbies
        {
            get
            {
                return hobbies;
            }
            set
            {
                hobbies = value;
            }
        }
        public string Peeves
        {
            get
            {
                return peeves;
            }
            set
            {
                peeves = value;
            }
        }
        public override string ToString()
        {
            return 
                "Your sex" + sex +
                "Your Age " + age +
                "Your occupation"+ occupation +
             
                "Your Hobbies"+hobbies +
                "Your Peeves"+ peeves.ToString();
        }
    }
}

