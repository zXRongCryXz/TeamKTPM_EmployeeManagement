﻿using EmployeeManagement_Service.ModelDBContext;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagerment_UI.User
{
    public partial class SuppliesForm : Form
    {
        public SuppliesForm()
        {
            InitializeComponent();
        }

        private void GetAllData()
        {
            try
            {
                grid_listsupplies.DataSource = new EmployeeManagement_Service.Service.Module.Supplies(new EmployeeManagementDBContext()) { }.SupplyAll();
            }
            catch
            {
                new EmployeeManagement_Service.Service.Basic.Notification.ErrorNotification() { }.ErrorWhileRefreshData();
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SuppliesForm_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
