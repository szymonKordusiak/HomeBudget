using HomeBudget.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeBudget.Services.Services
{
    public interface IIncomeService
    {
        IList<IncomeDto> GetIncomes();
    }
}
