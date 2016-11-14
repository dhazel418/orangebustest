namespace SkeletonCode.CardGame
{
	public class PackOfCardsCreator : IPackOfCardsCreator
	{
		public IPackOfCards Create()
		{
			return new PackOfCards();
		}
	}
}
