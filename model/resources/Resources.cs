using SpaceColony.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceColony.Model
{
	public class Resources
	{
		public Resources(ICollection<BaseResource> resources)
		{
			SetResources(resources);
		}

		private ICollection<BaseResource> resources;

		public ICollection<BaseResource> GetResources()
		{
			return resources;
		}

		public void SetResources(ICollection<BaseResource> value)
		{
			resources = value;
		}

		public int GetResource<T>() where T : BaseResource
		{
			foreach (BaseResource resource in GetResources())
				if (typeof(T) == resource.GetType())
					return ((T)resource).Amount;
			return 0;
		}

		public static Resources operator +(Resources a, Resources b)
		{
			ICollection<BaseResource> c1 = a.GetResources();
			ICollection<BaseResource> c2 = b.GetResources();
			var sumResources = c1.Zip(
				c2,
				(first, second) => first + second);
			Resources res = new Resources(sumResources.ToList());
			return res;
		}


		public static Resources operator -(Resources a, Resources b)
		{
			IList<BaseResource> c1 = a.GetResources().ToList();
			IList<BaseResource> c2 = b.GetResources().ToList();

			bool f = true;
			for (int i = 0; i < c1.Count && i < c2.Count; i++)
			{
				if (c1[i].Amount < c2[i].Amount)
				{
					f = false;
					break;
				}
				c1[i] -= c2[i];
			}

			if (f)
			{
				Resources res = new Resources(c1);
				return res;
			}
			else
			{
				//a.Empty();
				return null;
			}
		}

		//public event Action Empty;
	}
}
