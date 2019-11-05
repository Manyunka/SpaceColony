using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceColony.Model
{
	class Crystals : BaseResource
	{
		public Crystals(int amount)
			: base(amount) {}

		public override string Name => "Кристаллы";

		protected override BaseResource Add(BaseResource b)
		{
			Crystals res = new Crystals(Amount + b.Amount);
			return res;
		}

		protected override BaseResource Sub(BaseResource b)
		{
			Crystals res = new Crystals(Amount - b.Amount);
			return res;
		}
	}
}
