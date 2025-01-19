using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica_OOP_Herencia_P2.Parte_1.Domain
{
    public class School
    {   
        public string SchoolName { get; set; }
        public List<Group> Groups { get; set; }

        public School(string name)
        {   
            SchoolName = name;
            Groups = new List<Group>();

        }

        public void AddGroup(Group g)
        {
            Groups.Add(g);
        }

        
        public bool RemoveGroup(string id)
        {
            var g = Groups.FirstOrDefault(g => g.Id == id);
            if (g != null)
            {
                Groups.Remove(g);
                return true;
            }
            return false;
        }
    }
}
