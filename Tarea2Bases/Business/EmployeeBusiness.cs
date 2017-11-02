using Data;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class EmployeeBusiness
    {
        //atributos
        private string connectionString;
        private EmployeeData employeeData;

        public EmployeeBusiness(string conn)
        {
            this.connectionString = conn;
            employeeData = new EmployeeData(this.connectionString);
        }

        public void insertEmployee(Employee employee)
        {
            employeeData.insertEmployeeData(employee);
        }

        public void deleteEmployee(string dni)
        {
            employeeData.deleteEmployeeData(dni);
        }

        public void updateEmployee(Employee employee)
        {
            employeeData.updateEmployeeData(employee);
        }

        public Employee getEmployeeInformation(string dni)
        {
            return employeeData.getEmployeeInformation(dni);
        }
    }
}
