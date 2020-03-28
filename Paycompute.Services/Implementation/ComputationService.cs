using Microsoft.AspNetCore.Mvc.Rendering;
using Paycompute.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Paycompute.Persistence;
using System.Linq;

namespace Paycompute.Services.Implementation
{
    public class ComputationService : IComputationService
    {
        private readonly ApplicationDbContext _context;
        private decimal contractualEarnings;
        private decimal overtimeHours;
        public ComputationService(ApplicationDbContext context)
        {
            this._context = context;
        }
        public decimal ContractualEarnings(decimal contractualHours, decimal hoursWorked, decimal hourlyRate)
        {
            if (hoursWorked < contractualHours)
            {
                contractualEarnings = hoursWorked * hourlyRate;
            }
            else
            {
                contractualEarnings = contractualHours * hourlyRate;
            }
            return contractualEarnings;
        }

        public async Task CreateAsync(PaymentRecord paymentRecord)
        {
            await _context.PaymentRecords.AddAsync(paymentRecord);
            await _context.SaveChangesAsync();
        }

        public IEnumerable<PaymentRecord> GetAll() => _context.PaymentRecords.OrderBy(p => p.EmployeeId);

        public IEnumerable<SelectListItem> GetAllTaxYear()
        {
            var allTaxYear = _context.TaxYears.Select(taxYear => new SelectListItem
            {
                Text = taxYear.YearOfTax,
                Value = taxYear.Id.ToString()
            });
            return allTaxYear;
        }

        public PaymentRecord GetByID(int Id) => _context.PaymentRecords.Where(p => p.Id == Id).FirstOrDefault();

        public TaxYear GetTaxYearByID(int Id)
        {
            return _context.TaxYears.Where(tax => tax.Id == Id).FirstOrDefault();
        }

        public decimal NetPay(decimal totalEarnings, decimal totalDeduction) => totalEarnings - totalDeduction;
        public decimal OverTimeEarnings(decimal overtimeRate, decimal overtimeHours) => overtimeHours * overtimeRate;

        public decimal OverTimeHours(decimal hoursWorked, decimal contractualHours)
        {
            if (hoursWorked <= contractualHours)
            {
                overtimeHours = 0.00m;
            }
            else if (hoursWorked > contractualHours)
            {
                overtimeHours = hoursWorked - contractualHours;
            }
            return overtimeHours;
        }

        public decimal OverTimeRate(decimal hourlyRate) => hourlyRate * 1.5m;

        public decimal TotalDeduction(decimal tax, decimal nic, decimal studentLoanPayment, decimal unionFees)
            => tax + nic + studentLoanPayment + unionFees;

        public decimal TotalEarnings(decimal overtimeEarnings, decimal contractualEarnings)
            => overtimeEarnings + contractualEarnings;
    }
}
