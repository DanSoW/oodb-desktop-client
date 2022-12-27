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
    public class HostServiceService : BaseService
    {
        public HostServiceService(DataGridView data) : base(data) { }

        /// <summary>
        /// Получение всех записей из таблицы HostService
        /// </summary>
        public void GetAll()
        {
            GetAll<HostServiceModel>(ApiUrl.HOST_SERVICE, "HostServiceId");
        }

        /// <summary>
        /// Сохранение новой записи в таблицу HostService
        /// </summary>
        public void Save(HostServiceModel body)
        {
            Save(body, ApiUrl.HOST_SERVICE);
        }

        /// <summary>
        /// Обновление записи в таблице HostService
        /// </summary>
        /// <param name="body">Новые данные</param>
        public void Update(HostServiceModel body)
        {
            Update(body, ApiUrl.HOST_SERVICE, "HostServiceId");
        }

        /// <summary>
        /// Удаление записи из таблицы HostService
        /// </summary>
        /// <param name="id">ID записи в ООБД</param>
        public void Delete(string id)
        {
            Delete<HostServiceModel>(id, ApiUrl.HOST_SERVICE, "HostServiceId");
        }
    }
}
