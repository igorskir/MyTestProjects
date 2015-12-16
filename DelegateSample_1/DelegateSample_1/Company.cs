using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateSample_1
{
    
    class Company
    {
        public int Budget
        {
            get; set;
        }

        public Company(int newBudget)
        {
            Budget = newBudget;
        }
        public Company() { }

        public void SetNewBudget(int newBudget)
        {
            for (int i = 0; i < 10; i ++)
            {
                Budget = Budget + newBudget;
                ChangingSalary(this, new SelaryEventArgs(Budget / 10));
            }
        }

        public event EventHandler<SelaryEventArgs> ChangingSalary;
    }

    class Employee
    {
        public int Salary { get; set; }

        public Employee(int startSalary)
        {
            Salary = startSalary;
        }

        public void ChangeSelary(int delta)
        {
            Salary += delta;
        }
    }
}
