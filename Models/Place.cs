using System.Collections.Generic;
using System.Collections;

namespace Places.Models
{
	public class Place
	{
		private static Dictionary<string, Place> _instances = new Dictionary<string, Place>();
		private static List<Place> _instanceList = new List<Place>();
		
		private string _city;
		
		public Place(string city)
		{
			_city = city;
			
			_instances.Add(city, this);
			_instanceList.Add(this);
		}
		
		public string GetCity() {return _city;}
		
		public static Place Find(string city) {return _instances[city];}
		public static List<Place> GetAll() {return _instanceList;}
		
		public static void Remove(string city) 
		{
			_instanceList.Remove(_instances[city]);
			_instances.Remove(city);
		}
	}
}