using Newtonsoft.Json;
using oodb_desktop_client.constants;
using oodb_desktop_client.models;
using oodb_desktop_client.utils;
using oodb_project.models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oodb_desktop_client.services
{
    /// <summary>
    /// Класс сервиса для коллекции объектов Service
    /// </summary>
    public class ServiceService : BaseService
    {
        public ServiceService(DataGridView data) : base(data) { }

        /// <summary>
        /// Получение всех записей из таблицы Service
        /// </summary>
        public void GetAll()
        {
            GetAll<ServiceModel>(ApiUrl.SERVICE, "ServiceId");
        }

        /// <summary>
        /// Сохранение новой записи в таблицу Service
        /// </summary>
        public void Save(ServiceModel body)
        {
            Save(body, ApiUrl.SERVICE);
        }

        /// <summary>
        /// Обновление записи в таблице Service
        /// </summary>
        /// <param name="body">Новые данные</param>
        public void Update(ServiceModel body)
        {
            Update(body, ApiUrl.SERVICE, "ServiceId");
        }

        /// <summary>
        /// Удаление записи из таблицы Service
        /// </summary>
        /// <param name="id">ID записи в ООБД</param>
        public void Delete(string id)
        {
            Delete<ServiceModel>(id, ApiUrl.SERVICE, "ServiceId");
        }

        /// <summary>
        /// Формирование новой записи
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public void ShowDialog(
            string text,
            string[] dataSources,
            string operation = "save",
            ServiceModel oldValue = null
        )
        {
            Form prompt = new Form()
            {
                Width = 300,
                Height = 400,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = text,
                StartPosition = FormStartPosition.CenterScreen
            };

            Label labelName = new Label() { Left = 100, Top = 20, Width = 100, Text = "Введите название сервиса:" };
            TextBox textBoxName = new TextBox() { Left = 100, Top = 50, Width = 100, Text = (oldValue != null) ? oldValue.Name : "" };

            Label labelUrl = new Label() { Left = 100, Top = 90, Width = 100, Text = "Введите порт сервиса:" };
            TextBox textBoxUrl = new TextBox() { Left = 100, Top = 120, Width = 100, Text = (oldValue != null) ? oldValue.Port.ToString() : "" };

            Label labelIPv4 = new Label() { Left = 100, Top = 160, Width = 100, Text = "Введите время обновления сервиса:" };
            TextBox textBoxIPv4 = new TextBox() { Left = 100, Top = 190, Width = 100, Text = (oldValue != null) ? oldValue.TimeUpdate.ToString() : "" };

            Label labelSystem = new Label() { Left = 100, Top = 230, Width = 180, Text = "Введите DataSourceId:" };
            ComboBox comboBox = new ComboBox() { Left = 100, Top = 260, Width = 100, Text = (oldValue != null) ? oldValue.DataSourceId : "" };
            foreach(var item in dataSources)
            {
                comboBox.Items.Add(item);
            }

            Button confirmation = new Button() { Text = text, Left = 100, Width = 100, Top = 300, DialogResult = DialogResult.OK };

            confirmation.Click += (sender, e) => {
                prompt.Close();
            };

            prompt.Controls.Add(labelName);
            prompt.Controls.Add(textBoxName);

            prompt.Controls.Add(labelUrl);
            prompt.Controls.Add(textBoxUrl);

            prompt.Controls.Add(labelIPv4);
            prompt.Controls.Add(textBoxIPv4);

            prompt.Controls.Add(labelSystem);
            prompt.Controls.Add(comboBox);

            prompt.Controls.Add(confirmation);

            prompt.AcceptButton = confirmation;

            if (prompt.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            /*if (!ValidateUtil.IsValidEmail(textBoxName.Text))
            {
                MessageBox.Show(
                    "Не правильный формат Email-адреса",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return;
            }*/

            if (operation == "save")
            {
                Save(
                    new ServiceModel(
                        Guid.NewGuid().ToString(),
                        textBoxName.Text,
                        Int32.Parse(textBoxUrl.Text),
                        Int32.Parse(textBoxIPv4.Text),
                        comboBox.Text
                    )
                );
            }
            else if (operation == "update")
            {
                Update(
                    new ServiceModel(
                        oldValue.Id,
                        textBoxName.Text,
                        Int32.Parse(textBoxUrl.Text),
                        Int32.Parse(textBoxIPv4.Text),
                        comboBox.Text
                    )
                );
            }
        }
    }
}
