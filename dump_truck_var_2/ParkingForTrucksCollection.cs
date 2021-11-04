using System.Collections.Generic;
using System.Linq;

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
	}
}