using System;
using System.Collections.Generic;
using System.Text;

namespace Realms.Pets.Models
{
    public class Person : RealmObject
    {
        [PrimaryKey]
        public int Id { get; set; }

        public string Name { get; set; }
        public IList<Dog> Dogs { get; }
    }
}
