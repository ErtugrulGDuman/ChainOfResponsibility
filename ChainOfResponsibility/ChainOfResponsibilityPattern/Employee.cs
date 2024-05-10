using ChainOfResponsibility.Models;

namespace ChainOfResponsibility.ChainOfResponsibilityPattern
{
    public abstract class Employee
    {
        protected Employee NextApprover;
        public void SetNextApprover(Employee employee)
        {
            this.NextApprover = employee;
        }
        public abstract void ProcessRequest(CustomerViewModel customerViewModel);
    }
}
