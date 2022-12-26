using Newtonsoft.Json;
using oodb_desktop_client.constants;
using oodb_desktop_client.utils;
using oodb_project.models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oodb_desktop_client.services
{
    public class AdminService
    {
        public List<AdminModel> adminList = new List<AdminModel>();

        public void GetAll()
        {
            adminList.Clear();

            var url = $"{ApiUrl.BASE_URL}{ApiUrl.PERST_DOMAIN}{ApiUrl.ADMIN}{ApiUrl.GET_ALL}";

            var httpRequest = (HttpWebRequest)WebRequest.Create(url);
            var httpResponse = (HttpWebResponse)httpRequest.GetResponse();

            using(var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                adminList = JsonConvert.DeserializeObject<List<AdminModel>>(result.ToString());
            }

            httpResponse.Close();
        }

        /// <summary>
        /// Формирование новой записи
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static AdminModel ShowDialogAdd(string text, string email = "")
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
            TextBox textBox = new TextBox() { Left = 100, Top = 50, Width = 100, Text = email };
            Button confirmation = new Button() { Text = "Добавить", Left = 100, Width = 100, Top = 90, DialogResult = DialogResult.OK };
            
            confirmation.Click += (sender, e) => {
                prompt.Close();
            };

            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);

            prompt.AcceptButton = confirmation;

            if(prompt.ShowDialog() != DialogResult.OK)
            {
                return null;
            }

            if (!ValidateUtil.IsValidEmail(textBox.Text))
            {
                MessageBox.Show(
                    "Не правильный формат Email-адреса",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return null;
            }

            return new AdminModel(Guid.NewGuid().ToString(), textBox.Text);
        }
    }
}
