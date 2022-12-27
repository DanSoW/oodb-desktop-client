using Bogus;
using oodb_desktop_client.constants;
using oodb_desktop_client.services;
using oodb_project.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace oodb_desktop_client.generators
{
    public class HostGenerator
    {
		private HostService _hostService;

		public HostGenerator(HostService hostService)
		{
			_hostService = hostService;
		}

		/// <summary>
		/// Генерация хостов
		/// </summary>
		/// <param name="count">Количество генерируемых записей</param>
		/// <param name="progress">Прогресс генерации</param>
		public void GenerateHost(
			int count,
			IProgress<ProgressInfo> progress
		)
		{
			var faker = new Faker("ru");

			for (var i = 0; i < count; i++)
			{
				var email = faker.Internet.Email();

				_hostService.Save(
					new HostModel("", faker.System.FileName(), 
					faker.Internet.Url(), faker.Internet.Ip(), 
					faker.System.FileName()
				), 
					ApiUrl.HOST
				);

				var info = $"Сгенерировано записей: {i}";

				progress?.Report(new ProgressInfo
				{
					value = i + 1,
					info = info
				});

				Thread.Sleep(1);
			}
		}
	}
}
