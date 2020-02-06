using System;
using System.Collections.Generic;
using System.Text;

namespace MVDApp.Models.MultiSelectListView
{
    public class ExampleData
    {
        public string Name { get; set; }

        public string Description { get; set; }


        public ExampleData Clone()
        {
            return new ExampleData()
            {
                Name = Name,
                Description = Description
            };

        }

    }
}
