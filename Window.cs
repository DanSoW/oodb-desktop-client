using oodb_desktop_client.constants;
using oodb_desktop_client.generators;
using oodb_desktop_client.models;
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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oodb_desktop_client
{
    public partial class Window : Form
    {
        private AdminService _adminService;
        private AdminGenerator _adminGenerator;

        private HostService _hostService;
        private HostGenerator _hostGenerator;

        private DataSourceService _dataSourceService;
        private DataSourceGenerator _dataSourceGenerator;

        private MonitorAppService _monitorAppService;
        private HostServiceService _hostServiceService;
        private ServiceService _serviceService;

        public object GridViewUtils { get; private set; }

        public Window()
        {
            InitializeComponent();

            _adminService = new AdminService(dataGridAdmin);
            _adminGenerator = new AdminGenerator(_adminService);

            _hostService = new HostService(dataGridHost);
            _hostGenerator = new HostGenerator(_hostService);

            _dataSourceService = new DataSourceService(dataGridDataSource);
            _dataSourceGenerator = new DataSourceGenerator(_dataSourceService);

            _monitorAppService = new MonitorAppService(dataGridMonitor);
            _hostServiceService = new HostServiceService(dataGridHostService);
            _serviceService = new ServiceService(dataGridService);
        }

        /// <summary>
        /// Загрузка всех данных для таблицы Admins
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void _btnLoadData_Click(object sender, EventArgs e)
        {
            await Task.Run(() => {
                _adminService.GetAll();
            });
        }

        /// <summary>
        /// Добавление новой записи для таблицы Admins
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _btnAddRow_Click(object sender, EventArgs e)
        {
            _adminService.ShowDialog("Добавление");
        }

        /// <summary>
        /// Очистка таблицы Admins
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _btnAdminClear_Click(object sender, EventArgs e)
        {
            dataGridAdmin.Rows.Clear();
        }

        /// <summary>
        /// Изменение записи в таблице Admins
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            var index = dataGridAdmin.CurrentRow.Index;
            _adminService.ShowDialog(
                "Изменение", 
                "update", 
                new AdminModel(
                    dataGridAdmin.Rows[index].Cells[0].Value.ToString(), 
                    dataGridAdmin.Rows[index].Cells[1].Value.ToString()
                )
            );
        }

        /// <summary>
        /// Удаление записи в таблице Admins
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _btnAdminDelete_Click(object sender, EventArgs e)
        {
            _adminService.Delete(dataGridAdmin.Rows[dataGridAdmin.CurrentRow.Index].Cells[0].Value.ToString());
        }

        /// <summary>
        /// Генерация данных в таблице Admins
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void _btnGenerateAdmin_Click(object sender, EventArgs e)
        {
            int count = 0;
            if(!Int32.TryParse(_cmbCountAdmin.Text, out count))
            {
                MessageBox.Show(
                    "Введите количество генерируемых записей",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            var progress = new Progress<ProgressInfo>(prog =>
            {
                _pBarAdmin.Value = prog.value;
                _lpbAdmin.Text = prog.info;
            });

            _pBarAdmin.Maximum = count;

            await Task.Run(() =>
            {
                _adminGenerator.GenerateAdmin(count, progress);
            });

            _pBarAdmin.Value = 0;
            _lpbAdmin.Text = "";
        }

        /// <summary>
        /// Добавление записи в таблицу Host
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _btdAddHost_Click(object sender, EventArgs e)
        {
            _hostService.ShowDialog("Добавление");
        }

        private void _btnLoadHost_Click(object sender, EventArgs e)
        {
            _hostService.GetAll();
        }

        private void _btnDeleteHost_Click(object sender, EventArgs e)
        {
            _hostService.Delete(dataGridHost.Rows[dataGridHost.CurrentRow.Index].Cells[0].Value.ToString());
        }

        private void _btnClearHost_Click(object sender, EventArgs e)
        {
            dataGridHost.Rows.Clear();
        }

        private void _btnEditHost_Click(object sender, EventArgs e)
        {
            var index = dataGridHost.CurrentRow.Index;
            _hostService.ShowDialog(
                "Изменение",
                "update",
                new HostModel(
                    dataGridHost.Rows[index].Cells[0].Value.ToString(),
                    dataGridHost.Rows[index].Cells[1].Value.ToString(),
                    dataGridHost.Rows[index].Cells[2].Value.ToString(),
                    dataGridHost.Rows[index].Cells[3].Value.ToString(),
                    dataGridHost.Rows[index].Cells[4].Value.ToString()
                )
            );
        }

        private async void _btnGenHost_Click(object sender, EventArgs e)
        {
            int count = 0;
            if (!Int32.TryParse(_cmbCountHost.Text, out count))
            {
                MessageBox.Show(
                    "Введите количество генерируемых записей",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            var progress = new Progress<ProgressInfo>(prog =>
            {
                _pbHostLoad.Value = prog.value;
                _lpbHost.Text = prog.info;
            });

            _pbHostLoad.Maximum = count;

            await Task.Run(() =>
            {
                _hostGenerator.GenerateHost(count, progress);
            });

            _pbHostLoad.Value = 0;
            _lpbHost.Text = "";
        }

        private void _btnClearDataSource_Click(object sender, EventArgs e)
        {
            dataGridDataSource.Rows.Clear();
        }

        private void _btnLoadDataSource_Click(object sender, EventArgs e)
        {
            _dataSourceService.GetAll();
        }

        private void _btdAddDataSource_Click(object sender, EventArgs e)
        {
            _dataSourceService.ShowDialog("Добавление");
        }

        private void _btdEditDataSource_Click(object sender, EventArgs e)
        {
            var index = dataGridDataSource.CurrentRow.Index;
            _dataSourceService.ShowDialog(
                "Изменение",
                "update",
                new DataSourceModel(
                    dataGridDataSource.Rows[index].Cells[0].Value.ToString(),
                    dataGridDataSource.Rows[index].Cells[1].Value.ToString(),
                    dataGridDataSource.Rows[index].Cells[2].Value.ToString()
                )
            );
        }

        private void _btnDeleteDataSource_Click(object sender, EventArgs e)
        {
            _dataSourceService.Delete(dataGridDataSource.Rows[dataGridDataSource.CurrentRow.Index].Cells[0].Value.ToString());
        }

        private async void _btnGenDataSource_Click(object sender, EventArgs e)
        {
            int count = 0;
            if (!Int32.TryParse(_cmbCountDataSource.Text, out count))
            {
                MessageBox.Show(
                    "Введите количество генерируемых записей",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            var progress = new Progress<ProgressInfo>(prog =>
            {
                _pBarDataSource.Value = prog.value;
                _lpbDataSource.Text = prog.info;
            });

            _pBarDataSource.Maximum = count;

            await Task.Run(() =>
            {
                _dataSourceGenerator.GenerateDataSource(count, progress);
            });

            _pBarDataSource.Value = 0;
            _lpbDataSource.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            _monitorAppService.GetAll();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridMonitor.Rows.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _monitorAppService.Delete(dataGridMonitor.Rows[dataGridMonitor.CurrentRow.Index].Cells[0].Value.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var index = dataGridMonitor.CurrentRow.Index;
            _monitorAppService.ShowDialog(
                "Изменение",
                "update",
                new MonitorAppModel(
                    dataGridMonitor.Rows[index].Cells[0].Value.ToString(),
                    dataGridMonitor.Rows[index].Cells[1].Value.ToString(),
                    dataGridMonitor.Rows[index].Cells[2].Value.ToString(),
                    dataGridMonitor.Rows[index].Cells[3].Value.ToString(),
                    dataGridMonitor.Rows[index].Cells[4].Value.ToString()
                )
            );
        }

        private void button5_Click(object sender, EventArgs e)
        {
            _monitorAppService.ShowDialog("Добавление");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            _hostServiceService.Delete(dataGridHostService.Rows[dataGridHostService.CurrentRow.Index].Cells[0].Value.ToString());
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            dataGridHostService.Rows.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            _hostServiceService.GetAll();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            _serviceService.Delete(dataGridService.Rows[dataGridService.CurrentRow.Index].Cells[0].Value.ToString());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            dataGridService.Rows.Clear();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            _serviceService.GetAll();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            List<string> combobox = new List<string>();
            _dataSourceService.GetAll();

            for(int i = 0; i < _dataSourceService.dataGridView.RowCount; i++)
            {
                combobox.Add(_dataSourceService.dataGridView.Rows[i].Cells[0].Value.ToString());
            }

            _serviceService.ShowDialog("Добавление", combobox.ToArray());
        }

        private void button11_Click(object sender, EventArgs e)
        {
            List<string> combobox = new List<string>();
            _dataSourceService.GetAll();

            for (int i = 0; i < _dataSourceService.dataGridView.RowCount; i++)
            {
                combobox.Add(_dataSourceService.dataGridView.Rows[i].Cells[0].Value.ToString());
            }

            var index = dataGridService.CurrentRow.Index;

            _serviceService.ShowDialog("Обновление", 
                combobox.ToArray(), 
                "update",
                new ServiceModel(
                    dataGridService.Rows[index].Cells[0].Value.ToString(),
                    dataGridService.Rows[index].Cells[1].Value.ToString(),
                    Int32.Parse(dataGridService.Rows[index].Cells[2].Value.ToString()),
                    Int32.Parse(dataGridService.Rows[index].Cells[3].Value.ToString()),
                    dataGridService.Rows[index].Cells[4].Value.ToString()
                )
            );
        }
    }
}
