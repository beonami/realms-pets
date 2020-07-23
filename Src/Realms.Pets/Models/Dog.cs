using System;
using System.Collections.Generic;
using System.Text;

namespace Realms.Pets.Models
{
    public class Dog : RealmObject
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Person Owner { get; set; }
    }
}
