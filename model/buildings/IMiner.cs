

namespace SpaceColony.Model
{
	interface IMiner
	{
		int MinePerSecond { get; }
		void MineResources();
	}
}
