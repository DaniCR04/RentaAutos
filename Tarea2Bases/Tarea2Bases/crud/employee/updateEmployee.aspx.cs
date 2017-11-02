using Business;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tarea2Bases.crud.employee
{
    public partial class UpdateEmployee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLoadEmp_Click(object sender, EventArgs e)
        {
            string conn = WebConfigurationManager.ConnectionStrings["ConnectionString"].ToString();

            EmployeeBusiness cliB = new EmployeeBusiness(conn);

            Employee employee = cliB.getEmployeeInformation(txtLoadEmp.Text);

            txtDni.Text = employee.dni;
            txtName.Text = employee.name;
            txtLastName.Text = employee.last_name;
            txtSalary.Text = employee.salary;
            txtPhone.Text = employee.phone_number;
            txtAccount.Text = employee.account_number;
            txtSocial_sec.Text = employee.social_security;
            txtCity.Text = employee.city;
            txtDistrict.Text = employee.district;
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            string conn = WebConfigurationManager.ConnectionStrings["ConnectionString"].ToString();

            EmployeeBusiness employeeB = new EmployeeBusiness(conn);

            employeeB.updateEmployee(new Employee(txtDni.Text, txtSalary.Text, txtName.Text, txtLastName.Text, txtPhone.Text,
                txtAccount.Text, txtSocial_sec.Text, txtCity.Text, txtDistrict.Text));
        }
    }
}