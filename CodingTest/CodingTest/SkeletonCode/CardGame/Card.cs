namespace SkeletonCode.CardGame
{
  public class Card : ICard
  {
    public Card(EnumSuit suit, EnumCardNumber cardNumber)
    {
      Suit = suit;
      CardNumber = cardNumber;
    }

    #region Implementation of ICard

    public EnumSuit Suit { get; private set; }
    public EnumCardNumber CardNumber { get; private set; }

    #endregion
  }
}
