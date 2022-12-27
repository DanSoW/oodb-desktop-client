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
    public class HostService : BaseService
    {
        public HostService(DataGridView data) : base(data) { }

        /// <summary>
        /// Получение всех записей из таблицы Host
        /// </summary>
        public void GetAll()
        {
            GetAll<HostModel>(ApiUrl.HOST, "HostId");
        }

        /// <summary>
        /// Сохранение новой записи в таблицу Host
        /// </summary>
        public void Save(HostModel body)
        {
            Save(body, ApiUrl.HOST);
        }

        /// <summary>
        /// Обновление записи в таблице Host
        /// </summary>
        /// <param name="body">Новые данные</param>
        public void Update(HostModel body)
        {
            Update(body, ApiUrl.HOST, "HostId");
        }

        /// <summary>
        /// Удаление записи из таблицы Host
        /// </summary>
        /// <param name="id">ID записи в ООБД</param>
        public void Delete(string id)
        {
            Delete<HostModel>(id, ApiUrl.HOST, "HostId");
        }

        /// <summary>
        /// Формирование новой записи
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public void ShowDialog(
            string text,
            string operation = "save",
            HostModel oldValue = null)
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

            Label labelUrl= new Label() { Left = 100, Top = 90, Width = 100, Text = "Введите URL сервиса:" };
            TextBox textBoxUrl = new TextBox() { Left = 100, Top = 120, Width = 100, Text = (oldValue != null) ? oldValue.Url : "" };

            Label labelIPv4 = new Label() { Left = 100, Top = 160, Width = 100, Text = "Введите IPv4 сервиса:" };
            TextBox textBoxIPv4 = new TextBox() { Left = 100, Top = 190, Width = 100, Text = (oldValue != null) ? oldValue.IPv4 : "" };

            Label labelSystem = new Label() { Left = 100, Top = 230, Width = 100, Text = "Введите название системы:" };
            TextBox textBoxSystem = new TextBox() { Left = 100, Top = 260, Width = 100, Text = (oldValue != null) ? oldValue.System : "" };

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
            prompt.Controls.Add(textBoxSystem);

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
                    new HostModel(
                        Guid.NewGuid().ToString(),
                        textBoxName.Text,
                        textBoxUrl.Text,
                        textBoxIPv4.Text,
                        textBoxSystem.Text
                    )
                );
            }
            else if (operation == "update")
            {
                Update(
                    new HostModel(
                        oldValue.Id,
                        textBoxName.Text,
                        textBoxUrl.Text,
                        textBoxIPv4.Text,
                        textBoxSystem.Text
                    )
                );
            }
        }
    }
}
