using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mccormick_Rob_CE03
{





    public class Character

    {

     

        public string Name { get; set; }
        public string Gender { get; set; }
        public decimal Age { get; set; }


        public override string ToString()  
        {

            string newAge= Convert.ToString(Age);

            return String.Format("Name: {0}, Gender: {1}, Age: {2}", Name, Gender, newAge);

            

             
        }

    }
}


//public void Add(string firstName, string lastName, decimal age)
//{
//    var data = new CharacterList
//    {
//        Name = firstName,
//        Gender = Gender,
//        Age = age
//    };
//    //this.Add(data);
//}

//public Character(string Name, string Gender, decimal Age)
//{
//    this.Name = Name;
//    this.Gender = Gender;
//    this.Age = Age;
//}
