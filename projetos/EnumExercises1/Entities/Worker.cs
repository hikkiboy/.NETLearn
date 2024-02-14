using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnumExercises1.Entities.Enums;


namespace EnumExercises1.Entities
{
    internal class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }

        public Department Departament { get; set; }

        public List<HourContract> Contracts { get;  private set; } = new List<HourContract>();



        public Worker() { }

        public Worker(string name, WorkerLevel level, double baseSalary, Department departament, List<HourContract> contracts)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Departament = departament;
            Contracts = contracts;
        }

        public Worker(string name, WorkerLevel level, double baseSalary, Department departament)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Departament = departament;
        }

        public void addContract(HourContract contract)
        {
            Contracts.Add(contract);
        }
        public void removeContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income(int year, int month)
        {
            double sum = BaseSalary;
            foreach (HourContract contract in Contracts)
            {
                if(contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.totalValue();
                }

            }

            return sum;
        }


    }



}
