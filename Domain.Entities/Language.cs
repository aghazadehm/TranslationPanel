using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Language
    {
        public Language(/*int id,*/ string name, string abbrevation)
        {
            //Id = id;
            Name = name;
            Abbrevation = abbrevation;
        }

        //public int Id { get; set; }
        public string Name { get; set; }
        public string Abbrevation { get; set; }
    }
}
