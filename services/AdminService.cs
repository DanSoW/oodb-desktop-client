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
    /// Класс сервиса для коллекции объектов Admin
    /// </summary>
    public class AdminService : BaseService
    {
        public AdminService(DataGridView data) : base(data) {}

        /// <summary>
        /// Получение всех записей из таблицы Admins
        /// </summary>
        public void GetAll()
        {
            GetAll<AdminModel>(ApiUrl.ADMIN, "AdminId1");
        }

        /// <summary>
        /// Сохранение новой записи в таблицу Admins
        /// </summary>
        public void Save(AdminModel body)
        {
            Save(body, ApiUrl.ADMIN);
        }

        /// <summary>
        /// Обновление записи в таблице Admins
        /// </summary>
        /// <param name="body">Новые данные</param>
        public void Update(AdminModel body)
        {
            Update(body, ApiUrl.ADMIN, "AdminId1");
        }

        /// <summary>
        /// Удаление записи из таблицы Admins
        /// </summary>
        /// <param name="id">ID записи в ООБД</param>
        public void Delete(string id)
        {
            Delete<AdminModel>(id, ApiUrl.ADMIN, "AdminId1");
        }

        /// <summary>
        /// Формирование новой записи
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public void ShowDialog(
            string text,
            string operation = "save", 
            AdminModel oldValue = null)
        {
            Form prompt = new Form()
            {
                Width = 300,
                Height = 200,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = text,
                StartPosition = FormStartPosition.CenterScreen
            };

            Label textLabel = new Label() { Left = 100, Top = 20, Width = 100, Text = "Введите Email" };
            TextBox textBox = new TextBox() { Left = 100, Top = 50, Width = 100, Text = (oldValue != null)? oldValue.Email : "" };
            Button confirmation = new Button() { Text = text, Left = 100, Width = 100, Top = 90, DialogResult = DialogResult.OK };
            
            confirmation.Click += (sender, e) => {
                prompt.Close();
            };

            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);

            prompt.AcceptButton = confirmation;

            if(prompt.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            if (!ValidateUtil.IsValidEmail(textBox.Text))
            {
                MessageBox.Show(
                    "Не правильный формат Email-адреса",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return;
            }
            
            if(operation == "save")
            {
                Save(new AdminModel(Guid.NewGuid().ToString(), textBox.Text));
            }else if(operation == "update")
            {
                Update(new AdminModel(oldValue.Id, textBox.Text));
            }
        }
    }
}
