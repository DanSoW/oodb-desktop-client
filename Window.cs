using oodb_desktop_client.services;
using oodb_desktop_client.utils;
using oodb_project.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oodb_desktop_client
{
    public partial class Window : Form
    {
        private AdminService _adminService = new AdminService();

        public object GridViewUtils { get; private set; }

        public Window()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Загрузка всех данных для таблицы Admins
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _btnLoadData_Click(object sender, EventArgs e)
        {
            _adminService.GetAll();

            foreach (AdminModel item in _adminService.adminList)
            {
                if(GridViewUtil.GetIndexByValue(dataGridAdmin, "AdminId", item.Id) < 0)
                {
                    dataGridAdmin.Rows.Add(item.Id, item.Email);
                }
            }
        }

        /// <summary>
        /// Добавление новой записи для таблицы Admins
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _btnAddRow_Click(object sender, EventArgs e)
        {
            var admin = AdminService.ShowDialogAdd("Добавление");
            if(admin != null)
            {
                dataGridAdmin.Rows.Add(admin.Id, admin.Email);
            }
        }

        private void _btnAdminClear_Click(object sender, EventArgs e)
        {
            dataGridAdmin.Rows.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var index = dataGridAdmin.CurrentRow.Index;
            var admin = AdminService.ShowDialogAdd("Изменение", dataGridAdmin.Rows[index].Cells[1].Value.ToString());
            if (admin != null)
            {
                dataGridAdmin.Rows[index].Cells[1].Value = admin.Email;
            }
        }

        private void _btnAdminDelete_Click(object sender, EventArgs e)
        {
            dataGridAdmin.Rows.RemoveAt(dataGridAdmin.CurrentRow.Index);
        }
    }
}
