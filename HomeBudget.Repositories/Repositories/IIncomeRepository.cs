using HomeBudget.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeBudget.Repositories.Repositories
{
    public interface IIncomeRepository
    {
        IList<Income> GetIncomes();
    }
}
