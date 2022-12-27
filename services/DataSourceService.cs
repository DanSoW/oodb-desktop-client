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
    public class DataSourceService : BaseService
    {
        public DataSourceService(DataGridView data) : base(data) { }

        /// <summary>
        /// Получение всех записей из таблицы DataSource
        /// </summary>
        public void GetAll()
        {
            GetAll<DataSourceModel>(ApiUrl.DATA_SOURCE, "DataSourceId");
        }

        /// <summary>
        /// Сохранение новой записи в таблицу DataSource
        /// </summary>
        public void Save(DataSourceModel body)
        {
            Save(body, ApiUrl.DATA_SOURCE);
        }

        /// <summary>
        /// Обновление записи в таблице DataSource
        /// </summary>
        /// <param name="body">Новые данные</param>
        public void Update(DataSourceModel body)
        {
            Update(body, ApiUrl.DATA_SOURCE, "DataSourceId");
        }

        /// <summary>
        /// Удаление записи из таблицы DataSource
        /// </summary>
        /// <param name="id">ID записи в ООБД</param>
        public void Delete(string id)
        {
            Delete<DataSourceModel>(id, ApiUrl.DATA_SOURCE, "DataSourceId");
        }

        /// <summary>
        /// Формирование новой записи
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public void ShowDialog(
            string text,
            string operation = "save",
            DataSourceModel oldValue = null)
        {
            Form prompt = new Form()
            {
                Width = 400,
                Height = 200,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = text,
                StartPosition = FormStartPosition.CenterScreen
            };

            Label labelName = new Label() { Left = 100, Top = 20, Width = 100, Text = "Введите название ресурса:" };
            TextBox textBoxName = new TextBox() { Left = 100, Top = 50, Width = 100, Text = (oldValue != null) ? oldValue.Name : "" };

            Label labelUrl = new Label() { Left = 100, Top = 90, Width = 100, Text = "Введите URL ресурса:" };
            TextBox textBoxUrl = new TextBox() { Left = 100, Top = 120, Width = 100, Text = (oldValue != null) ? oldValue.Url : "" };

            Button confirmation = new Button() { Text = text, Left = 100, Width = 100, Top = 150, DialogResult = DialogResult.OK };

            confirmation.Click += (sender, e) => {
                prompt.Close();
            };

            prompt.Controls.Add(labelName);
            prompt.Controls.Add(textBoxName);

            prompt.Controls.Add(labelUrl);
            prompt.Controls.Add(textBoxUrl);

            prompt.AcceptButton = confirmation;

            if (prompt.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            /*if (!ValidateUtil.IsValidEmail(textBox.Text))
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
                    new DataSourceModel(
                        Guid.NewGuid().ToString(),
                        textBoxName.Text,
                        textBoxUrl.Text
                    )
                );
            }
            else if (operation == "update")
            {
                Update(
                    new DataSourceModel(
                        oldValue.Id,
                        textBoxName.Text,
                        textBoxUrl.Text
                    )
                );
            }
        }
    }
}
