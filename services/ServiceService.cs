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
    }
}
