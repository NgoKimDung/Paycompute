using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Paycompute.Services;
using Paycompute.Models;
using Paycompute.Entity;

namespace Paycompute.Controllers
{
    public class PayController : Controller
    {
        private readonly IComputationService _computationservice;
        private readonly IEmployeeService _employeeService;
        private readonly ITaxService _taxService;
        private readonly INationalInsuranceContributionService _nationalInsuranceContributionService;
        public PayController(IComputationService computationService, IEmployeeService employeeService, ITaxService taxService, INationalInsuranceContributionService nationalInsuranceContributionService)
        {
            this._computationservice = computationService;
            this._employeeService = employeeService;
            this._taxService = taxService;
            this._nationalInsuranceContributionService = nationalInsuranceContributionService;
        }

        public ActionResult Index()
        {
            var payRecords = _computationservice.GetAll().Select(pay => new PaymentRecordIndexViewModel
            {
                Id = pay.Id,
                EmployeeId = pay.EmployeeId,
                FullName = pay.FullName,
                PayDate = pay.PayDate,
                PayMonth = pay.PayMonth,
                TaxYearId = pay.TaxYearID,
                Year = _computationservice.GetTaxYearByID(pay.TaxYearID).YearOfTax,
                TotalEarnings = pay.TotalEarnings,
                TotalDeduction = pay.TotalDeduction,
                NetPayment = pay.NetPayment,
                Employee = pay.Employee
            });
            return View(payRecords);
        }
        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.employees = _employeeService.GetAllEmployeesForPayroll();
            ViewBag.taxYears = _computationservice.GetAllTaxYear();
            var model = new PaymentRecordCreateViewModel();
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(PaymentRecordCreateViewModel model)
        {
            decimal overtimeHrs;
            decimal overtimrears;
            decimal contractualears;
            decimal totalears;
            decimal tax;
            decimal nic;
            decimal studentLoanPayment;
            decimal unionFee;
            decimal totalDeduction;
            if (ModelState.IsValid)
            {
                var employee = _employeeService.GetById(model.EmployeeId);
                var paymentRecord = new PaymentRecord()
                {
                    Id = model.Id,
                    EmployeeId = model.EmployeeId,
                    FullName = employee.FullName,
                    NiNo = employee.NationalInsuranceNo,
                    PayDate = model.PayDate,
                    PayMonth = model.PayMonth,
                    TaxYearID = model.TaxYearID,
                    TaxCode = model.TaxCode,
                    HourlyRate = model.HourlyRate,
                    HoursWorked = model.HoursWorked,
                    ContractualHours = model.ContractualHours,
                    OvertimeHours = overtimeHrs = _computationservice.OverTimeEarnings(model.HoursWorked, model.ContractualHours),
                    ContractualEarnings = contractualears = _computationservice.ContractualEarnings(model.ContractualHours, model.HoursWorked, model.HourlyRate),
                    OvertimeEarnings = overtimrears = _computationservice.OverTimeEarnings(_computationservice.OverTimeRate(model.HourlyRate), overtimeHrs),
                    TotalEarnings = totalears = _computationservice.TotalEarnings(overtimrears, contractualears),
                    Tax = tax =_taxService.TaxAmount(totalears),
                    UnionFee = unionFee = _employeeService.UnionFees(model.EmployeeId),
                    SLC = studentLoanPayment = _employeeService.StudentLoanRepaymentAmount(model.EmployeeId, totalears),
                    NIC = nic = _nationalInsuranceContributionService.NIContribution(totalears),
                    TotalDeduction = totalDeduction = _computationservice.TotalDeduction(tax, nic, studentLoanPayment, unionFee),
                    NetPayment = _computationservice.NetPay(totalears, totalDeduction)
                };
                await _computationservice.CreateAsync(paymentRecord);
                return RedirectToAction(nameof(Index));
            }
            ViewBag.employees = _employeeService.GetAllEmployeesForPayroll();
            ViewBag.taxYears = _computationservice.GetAllTaxYear();
            return View();
        }
        [HttpGet]
        public ActionResult Detail(int id)
        {
            var paymentRecord = _computationservice.GetByID(id);
            if (paymentRecord == null) return NotFound();
            var model = new PaymentRecordDetailViewModel()
            {
                Id = paymentRecord.Id,
                EmployeeId = paymentRecord.EmployeeId,
                FullName = paymentRecord.FullName,
                NiNo = paymentRecord.NiNo,
                PayDate = paymentRecord.PayDate,
                PayMonth = paymentRecord.PayMonth,
                TaxYearID = paymentRecord.TaxYearID,
                Year = _computationservice.GetTaxYearByID(paymentRecord.TaxYearID).YearOfTax,
                TaxCode = paymentRecord.TaxCode,
                HourlyRate = paymentRecord.HourlyRate,
                HoursWorked = paymentRecord.HoursWorked,
                ContractualEarnings = paymentRecord.ContractualEarnings,
                OvertimeEarnings = paymentRecord.OvertimeEarnings,
                OvertimeRate = _computationservice.OverTimeRate(paymentRecord.HourlyRate),
                ContractualHours = paymentRecord.ContractualHours,
                OvertimeHours = paymentRecord.OvertimeHours,
                Tax = paymentRecord.Tax,
                NIC = paymentRecord.NIC,
                UnionFee = paymentRecord.UnionFee,
                SLC = paymentRecord.SLC,
                TotalEarnings = paymentRecord.TotalEarnings,
                TotalDeduction = paymentRecord.TotalDeduction,
                Employee = paymentRecord.Employee,
                TaxYear = paymentRecord.TaxYear,
                NetPayment = paymentRecord.NetPayment
            };
            return View(model);
        }
        [HttpGet]
        public ActionResult Payslip(int id)
        {
            var paymentRecord = _computationservice.GetByID(id);
            if (paymentRecord == null) return NotFound();
            var model = new PaymentRecordDetailViewModel()
            {
                Id = paymentRecord.Id,
                EmployeeId = paymentRecord.EmployeeId,
                FullName = paymentRecord.FullName,
                NiNo = paymentRecord.NiNo,
                PayDate = paymentRecord.PayDate,
                PayMonth = paymentRecord.PayMonth,
                TaxYearID = paymentRecord.TaxYearID,
                Year = _computationservice.GetTaxYearByID(paymentRecord.TaxYearID).YearOfTax,
                TaxCode = paymentRecord.TaxCode,
                HourlyRate = paymentRecord.HourlyRate,
                HoursWorked = paymentRecord.HoursWorked,
                ContractualEarnings = paymentRecord.ContractualEarnings,
                OvertimeEarnings = paymentRecord.OvertimeEarnings,
                OvertimeRate = _computationservice.OverTimeRate(paymentRecord.HourlyRate),
                ContractualHours = paymentRecord.ContractualHours,
                OvertimeHours = paymentRecord.OvertimeHours,
                Tax = paymentRecord.Tax,
                NIC = paymentRecord.NIC,
                UnionFee = paymentRecord.UnionFee,
                SLC = paymentRecord.SLC,
                TotalEarnings = paymentRecord.TotalEarnings,
                TotalDeduction = paymentRecord.TotalDeduction,
                Employee = paymentRecord.Employee,
                TaxYear = paymentRecord.TaxYear,
                NetPayment = paymentRecord.NetPayment
            };
            return View(model);
        }
    }
}
