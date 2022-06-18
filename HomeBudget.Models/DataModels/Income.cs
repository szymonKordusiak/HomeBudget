using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeBudget.Models.DataModels
{
    public class Income
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Value { get; set; }
    }
}
