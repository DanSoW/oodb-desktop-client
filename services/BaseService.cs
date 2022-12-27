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
    /// Абстрактный класс определяющий базовые CRUD-операции для работы с таблицами
    /// </summary>
    public abstract class BaseService
    {
        protected DataGridView _dataGridView;
        public BaseService(DataGridView data)
        {
            _dataGridView = data;
        }

        /// <summary>
        /// Получение всех данных из таблицы
        /// </summary>
        /// <typeparam name="T">Тип данных</typeparam>
        /// <param name="domainPath">Путь к домену таблицы</param>
        /// <param name="columnName">Название столбца первичного ключа</param>
        public void GetAll<T>(string domainPath, string columnName) where T : IdModel
        {
            var url = $"{ApiUrl.BASE_URL}{ApiUrl.PERST_DOMAIN}{domainPath}{ApiUrl.GET_ALL}";

            var httpRequest = (HttpWebRequest)WebRequest.Create(url);
            var httpResponse = (HttpWebResponse)httpRequest.GetResponse();

            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                var list = JsonConvert.DeserializeObject<List<T>>(result.ToString());

                foreach (T item in list)
                {
                    if (GridViewUtil.GetIndexByValue(_dataGridView, columnName, item.Id) < 0)
                    {
                        var fields = ReflectionUtil.getFields(item);

                        Action action = () => _dataGridView.Rows.Add(fields.ToArray());
                        _dataGridView.Invoke(action);
                    }
                }
            }

            httpResponse.Close();
        }

        /// <summary>
        /// Изменение данных
        /// </summary>
        /// <param name="body">Данные для изменения</param>
        public void Update<T>(T body, string domainPath, string columnName) where T : IdModel
        {
            var url = $"{ApiUrl.BASE_URL}{ApiUrl.PERST_DOMAIN}{domainPath}{ApiUrl.UPDATE}";

            var httpRequest = (HttpWebRequest)WebRequest.Create(url);
            httpRequest.Method = "POST";
            httpRequest.ContentType = "application/json";

            var data = JsonConvert.SerializeObject(body);

            using (var streamWriter = new StreamWriter(httpRequest.GetRequestStream()))
            {
                streamWriter.Write(data);
            }

            var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
            object output = null;

            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                output = (object)JsonConvert.DeserializeObject<T>(result.ToString());

                if (((T)output).Id == null)
                {
                    MessageBox.Show(
                        (JsonConvert.DeserializeObject<MessageModel>(result.ToString())).message,
                        "Ошибка",
                         MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
                else
                {
                    T model = ((T)output);
                    var index = GridViewUtil.GetIndexByValue(_dataGridView, columnName, model.Id);
                    var fields = ReflectionUtil.getFields(model);

                    Action action = () =>
                    {
                        for (var i = 0; i < fields.Count; i++)
                        {
                            _dataGridView.Rows[index].Cells[i].Value = fields[i];
                        }
                    };

                    _dataGridView.Invoke(action);
                }
            }

            httpResponse.Close();
        }

        /// <summary>
        /// Сохранение данных
        /// </summary>
        /// <param name="body">Данные для сохранения</param>
        public void Save<T>(T body, string domainPath) where T : IdModel
        {
            var url = $"{ApiUrl.BASE_URL}{ApiUrl.PERST_DOMAIN}{domainPath}{ApiUrl.SAVE}";

            var httpRequest = (HttpWebRequest)WebRequest.Create(url);
            httpRequest.Method = "POST";
            httpRequest.ContentType = "application/json";

            var data = JsonConvert.SerializeObject(body);

            using (var streamWriter = new StreamWriter(httpRequest.GetRequestStream()))
            {
                streamWriter.Write(data);
            }

            var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
            object output = null;

            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                output = (object)JsonConvert.DeserializeObject<T>(result.ToString());

                if (((T)output).Id == null)
                {
                    MessageBox.Show(
                        (JsonConvert.DeserializeObject<MessageModel>(result.ToString())).message,
                        "Ошибка",
                         MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
                else
                {
                    var fields = ReflectionUtil.getFields((T)output);

                    Action action = () => _dataGridView.Rows.Add(fields.ToArray());
                    _dataGridView.Invoke(action);
                }
            }

            httpResponse.Close();
        }

        /// <summary>
        /// Удаление записи
        /// </summary>
        /// <param name="admin">Данные для сохранения</param>
        public void Delete<T>(string id, string domainPath, string columnId) where T : IdModel
        {
            var url = $"{ApiUrl.BASE_URL}{ApiUrl.PERST_DOMAIN}{domainPath}{ApiUrl.DELETE}/{id}";

            var httpRequest = (HttpWebRequest)WebRequest.Create(url);
            httpRequest.Method = "POST";
            httpRequest.ContentType = "application/json";

            var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
            object output = null;

            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                output = (object)JsonConvert.DeserializeObject<T>(result.ToString());

                if (((T)output).Id == null)
                {
                    MessageBox.Show(
                        (JsonConvert.DeserializeObject<MessageModel>(result.ToString())).message,
                        "Ошибка",
                         MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
                else
                {
                    var index = GridViewUtil.GetIndexByValue(_dataGridView, columnId, id);
                    Action action = () => _dataGridView.Rows.RemoveAt(index);
                    _dataGridView.Invoke(action);
                }
            }

            httpResponse.Close();
        }
    }
}
