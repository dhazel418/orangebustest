using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace SkeletonCode.CardGame
{
  public class PackOfCards : IPackOfCards
  {
    private IReadOnlyCollection<ICard> _cardCollection; 

    public PackOfCards()
    {
      IList<ICard> cardList = new List<ICard>();
      for (EnumSuit suit = EnumSuit.Clubs; suit <= EnumSuit.Diamonds; suit++)
      {
        for (EnumCardNumber cardNo = EnumCardNumber.Two; cardNo <= EnumCardNumber.Ace; cardNo++)
        {
          cardList.Add(new Card(suit, cardNo));
        }
      }

      _cardCollection = new ReadOnlyCollection<ICard>(cardList);
    }

    #region Implementation of IEnumerable

    /// <summary>
    /// Returns an enumerator that iterates through the collection.
    /// </summary>
    /// <returns>
    /// A <see cref="T:System.Collections.Generic.IEnumerator`1"/> that can be used to iterate through the collection.
    /// </returns>
    public IEnumerator<ICard> GetEnumerator()
    {
      return _cardCollection.GetEnumerator();
    }

    /// <summary>
    /// Returns an enumerator that iterates through a collection.
    /// </summary>
    /// <returns>
    /// An <see cref="T:System.Collections.IEnumerator"/> object that can be used to iterate through the collection.
    /// </returns>
    IEnumerator IEnumerable.GetEnumerator()
    {
      return GetEnumerator();
    }

    #endregion

    #region Implementation of IReadOnlyCollection<out ICard>

    /// <summary>
    /// Gets the number of elements in the collection.
    /// </summary>
    /// <returns>
    /// The number of elements in the collection. 
    /// </returns>
    public int Count { get { return _cardCollection.Count; } }

    #endregion

    #region Implementation of IPackOfCards

    public void Shuffle()
    {
      IList<ICard> cardList = _cardCollection.ToList();
      _cardCollection = new ReadOnlyCollection<ICard>(cardList.OrderBy(a => Guid.NewGuid()).ToList());
    }

    public ICard TakeCardFromTopOfPack()
    {
      IList<ICard> cardList = _cardCollection.ToList();
      ICard topCard = cardList[0];
      cardList.Remove(topCard);
      _cardCollection = new ReadOnlyCollection<ICard>(cardList);
      return topCard;
    }

    #endregion
  }
}
