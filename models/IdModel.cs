using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oodb_desktop_client.models
{
    public abstract class IdModel
    {
        public IdModel()
        {

        }

        public IdModel(string id)
        {
            Id = id;
        }

        public string Id { get; set; }
    }
}
