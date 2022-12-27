using oodb_desktop_client.models;

namespace oodb_project.models
{
    /// <summary>
    /// Модель связки конкретных сервисов с конкретными хостами
    /// </summary>
    public class HostServiceModel : IdModel
    {
        public HostServiceModel()
        {
        }

        public HostServiceModel(string id, string hostId, string serviceId) : base(id)
        {
            HostId = hostId;
            ServiceId = serviceId;
        }

        public string HostId { get; set; }
        public string ServiceId { get; set; }
    }
}
