using HomeBudget.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeBudget.Repositories.Repositories
{
    public class IncomeRepository : IIncomeRepository
    {
        public IList<Income> GetIncomes()
        {
            List<Income> incomes = new List<Income>()
            {
                new Income()
                {
                    Id = 1,
                    Name = "Wypłata",
                    Value = 5000
                },
                new Income()
                {
                    Id = 2,
                    Name = "oprocentowanie",
                    Value = 1000
                },
                new Income()
                {
                    Id = 3,
                    Name = "sprzedaż",
                    Value = 2000
                },
            };
            return incomes;
        }
    }
}
