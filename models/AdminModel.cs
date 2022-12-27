using oodb_desktop_client.models;

namespace oodb_project.models
{
    /// <summary>
    /// Модель, характеризующая администратора приложения для мониторинга
    /// </summary>
    public class AdminModel : IdModel
    {
        public AdminModel()
        {
        }

        public AdminModel(string id, string email): base(id)
        {
            Email = email;
        }

        public string Email { get; set; }
    }
}
