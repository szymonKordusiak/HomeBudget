using HomeBudget.Models.Contracts;
using HomeBudget.Repositories.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeBudget.Services.Services
{
    public class IncomeService : IIncomeService
    {
        private readonly IIncomeRepository _incomeRepository;

        public IncomeService(IIncomeRepository incomeRepository)
        {
            _incomeRepository = incomeRepository;
        }

        public IList<IncomeDto> GetIncomes()
        {
            var incomes = _incomeRepository.GetIncomes();

            List<IncomeDto> incomeDtos = new List<IncomeDto>();

            foreach (var income in incomes)
            {
                incomeDtos.Add(new IncomeDto()
                {
                    Id = income.Id,
                    Name = income.Name,
                    Value = income.Value,
                });
            }

            return incomeDtos;
        }
    }
}
