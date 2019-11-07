using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceColony.Model
{
	public abstract class BaseResource
	{
		public abstract string Name { get; }

		public int Amount { get; set; }

		public BaseResource(int amount)
		{
			Amount = amount;
		}

		protected abstract BaseResource Add(BaseResource b);
		public static BaseResource operator +(BaseResource a, BaseResource b)
		{
			return a.Add(b);
		}

		protected abstract BaseResource Sub(BaseResource b);
		public static BaseResource operator -(BaseResource a, BaseResource b)
		{
			return a.Sub(b);
		}

		protected abstract BaseResource Multi(int n);
		public static BaseResource operator *(BaseResource a, int n)
		{
			return a.Multi(n);
		}
	}
}
