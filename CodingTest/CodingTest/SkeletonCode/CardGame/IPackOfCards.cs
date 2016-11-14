using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkeletonCode.CardGame
{
	public interface IPackOfCards : IReadOnlyCollection<ICard>
	{
		void Shuffle ();
		ICard TakeCardFromTopOfPack ();
	}
}
