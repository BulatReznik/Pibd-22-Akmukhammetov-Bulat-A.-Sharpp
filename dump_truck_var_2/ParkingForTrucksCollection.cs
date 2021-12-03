using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace dump_truck_var_2
{
	/// <summary>
	/// Класс-коллекция парковок
	/// </summary>
	class ParkingForTrucksCollection
	{
		/// <summary>
		/// Словарь (хранилище) с парковками
		/// </summary>
		readonly Dictionary<string, ParkingForTrucks<Vehicle>> parkingForTrucksStages;
		/// <summary>
		/// Возвращение списка названий праковок
		/// </summary>
		public List<string> Keys => parkingForTrucksStages.Keys.ToList();
		/// <summary>
		/// Ширина окна отрисовки
		/// </summary>
		private readonly int pictureWidth; 
		/// <summary>
		/// Высота окна отрисовки
		/// </summary>
		private readonly int pictureHeight;
		/// <summary>
		/// Разделитель для записи информации в файл
		/// </summary>
		private readonly char separator = ':';
		/// <summary>
		/// Конструктор
		/// </summary>
		/// <param name="pictureWidth"></param>
		/// <param name="pictureHeight"></param> 
		public ParkingForTrucksCollection(int pictureWidth, int pictureHeight)
		{
			parkingForTrucksStages = new Dictionary<string, ParkingForTrucks<Vehicle>>();
			this.pictureWidth = pictureWidth;
			this.pictureHeight = pictureHeight;
		}
		/// <summary>
		/// Добавление парковки
		/// </summary>
		/// <param name="name">Название парковки</param>
		public void AddParkingForTrucks(string name)
		{
			if (!parkingForTrucksStages.ContainsKey(name))
			{
				parkingForTrucksStages.Add(name, new ParkingForTrucks<Vehicle>(pictureWidth, pictureHeight));
			}
		}
		/// <summary>
		/// Удаление парковки
		/// </summary>
		/// <param name="name">Название парковки</param>
		public void DelParkingForTrucks(string name)
		{
			if (parkingForTrucksStages.ContainsKey(name))
			{
				parkingForTrucksStages.Remove(name);
			}
		}
		/// <summary>
		/// Доступ к парковке
		/// </summary>
		/// <param name="ind"></param>
		/// <returns></returns>
		public ParkingForTrucks<Vehicle> this[string ind]
		{
			get
			{
				if (parkingForTrucksStages.ContainsKey(ind))
				{
					return parkingForTrucksStages[ind];
				}
				else
				{
					return null;
				}
			}
		}
		/// <summary>
		/// Сохранение информации по автомобилям на парковках в файл
		/// </summary>
		/// <param name="filename">Путь и имя файла</param>
		/// <returns></returns>
		public void SaveData(string filename)
		{
			if (File.Exists(filename))
			{
				File.Delete(filename);
			}
			using (StreamWriter sw = new StreamWriter(filename))
			{
				sw.Write($"ParkingForTrucksCollection{Environment.NewLine}");
				foreach (var level in parkingForTrucksStages)
				{
					sw.Write($"ParkingForTrucks{separator}{level.Key}{Environment.NewLine}");
					ITransport dumpcar = null;
					for (int i = 0; (dumpcar = level.Value.GetNext(i)) != null; i++)
					{
						if (dumpcar != null)
						{
							if (dumpcar.GetType().Name == "TruckCar")
							{
								sw.Write($"TruckCar{separator}");
							}
							if (dumpcar.GetType().Name == "DumpCar")
							{
								sw.Write($"DumpCar{separator}");
							}
							sw.Write(dumpcar + Environment.NewLine);
						}
					}
				}
			}
		}
		/// <summary>
		/// Загрузка нформации по автомобилям на парковках из файла
		/// </summary>
		/// <param name="filename"></param>
		/// <returns></returns>
		public void LoadData(string filename)
		{
			if (!File.Exists(filename))
			{
				throw new FileNotFoundException();
			}
			using (StreamReader sr = new StreamReader(filename))
			{
				string line = sr.ReadLine();
				if (line.Contains("ParkingForTrucksCollection"))
				{
					parkingForTrucksStages.Clear();
				}
				else
				{
					//если нет такой записи, то это не те данные - выводим исключение
					throw new FormatException("Неверный формат файла");

				}
				Vehicle dumpcar = null;
				string key = string.Empty;
				for (int i = 1; (line = sr.ReadLine()) != null; ++i)
				{
					//идем по считанным записям
					if (line.Contains("ParkingForTrucks"))
					{
						//начинаем новую парковку
						key = line.Split(separator)[1];
						parkingForTrucksStages.Add(key, new ParkingForTrucks<Vehicle>(pictureWidth, pictureHeight));
						continue;
					}
					if (string.IsNullOrEmpty(line))
					{
						continue;
					}
					if (line.Split(separator)[0] == "TruckCar")
					{
						dumpcar = new TruckCar(line.Split(separator)[1]);
					}
					else if (line.Split(separator)[0] == "DumpCar")
					{
						dumpcar = new DumpCar(line.Split(separator)[1]);
					}
					var result = parkingForTrucksStages[key] + dumpcar;
					if (result == -1)
					{
						throw new TypeLoadException("Не удалось загрузить грузовик на парковку");
					}
				}
			}
		}
	}
}
