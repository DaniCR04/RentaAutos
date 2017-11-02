﻿using Business;
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
    public partial class InsertEmployee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            string conn = WebConfigurationManager.ConnectionStrings["ConnectionString"].ToString();

           EmployeeBusiness employeeB = new EmployeeBusiness(conn);

            employeeB.insertEmployee(new Employee(txtDni.Text, txtSalary.Text , txtName.Text, txtLastName.Text, txtPhone.Text, 
                txtAccount.Text, txtSocial_sec.Text, txtCity.Text, txtDistrict.Text));
        }
    }
}