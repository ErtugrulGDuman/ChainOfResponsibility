﻿using ChainOfResponsibility.DAL;
using ChainOfResponsibility.Models;

namespace ChainOfResponsibility.ChainOfResponsibilityPattern
{
    public class ManagerAssistant : Employee
    {
        private readonly  Context _context;

        public ManagerAssistant(Context context)
        {
            _context = context;
        }

        public override void ProcessRequest(CustomerViewModel customerViewModel)
        {
            if (customerViewModel.Amount <= 150000)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Name = customerViewModel.Name;
                customerProcess.Amount = customerViewModel.Amount;
                customerProcess.EmployeeName = "Ertuğrul Gökay Duman";
                customerProcess.Description = "Talep edilen tutar şube müdür yardımcısı tarafından ödendi";
                _context.CustomerProcess.Add(customerProcess);
                _context.SaveChanges();
            }
            else if (NextApprover != null)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Name = customerViewModel.Name;
                customerProcess.Amount = customerViewModel.Amount;
                customerProcess.EmployeeName = "Ertuğrul Gökay Duman";
                customerProcess.Description = "Talep edilen tutar şube müdür yardımcısı tarafından ödenmedi, İşlem şube müdürüne aktarıldı";
                _context.CustomerProcess.Add(customerProcess);
                _context.SaveChanges();
                NextApprover.ProcessRequest(customerViewModel);
            }
        }
    }
}
