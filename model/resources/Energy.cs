using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceColony.Model
{
	class Energy : BaseResource
	{
		public Energy(int amount) 
			: base(amount) {}

		public override string Name => "Энергия";

		protected override BaseResource Add(BaseResource b)
		{
			Energy res = new Energy(Amount + b.Amount);
			return res;
		}

		protected override BaseResource Sub(BaseResource b)
		{
			Energy res = new Energy(Amount - b.Amount);
			return res;
		}

		protected override BaseResource Multi(int n)
		{
			Energy res = new Energy(Amount * n);
			return res;
		}
	}
}
