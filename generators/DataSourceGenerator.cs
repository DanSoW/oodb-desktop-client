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
	/// <summary>
	/// Класс генератора объектов коллекции DataSource
	/// </summary>
	public class DataSourceGenerator
	{
		private DataSourceService _dataSourceService;

		public DataSourceGenerator(DataSourceService dataSourceService)
		{
			_dataSourceService = dataSourceService;
		}

		/// <summary>
		/// Генерация ресурсов
		/// </summary>
		/// <param name="count">Количество генерируемых записей</param>
		/// <param name="progress">Прогресс генерации</param>
		public void GenerateDataSource(
			int count,
			IProgress<ProgressInfo> progress
		)
		{
			var faker = new Faker("ru");

			for (var i = 0; i < count; i++)
			{
				var email = faker.Internet.Email();

				_dataSourceService.Save(
					new DataSourceModel("", 
						faker.System.FileName(),
						faker.Internet.Url()
				),
					ApiUrl.DATA_SOURCE
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
