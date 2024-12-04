namespace Deck;
using Models;
using System.Collections.Generic;
using System.Security.Cryptography;

public class DeckManager : IDeckManager
{
    #region Add Cards to Deck Documentation
    /// <summary>
    /// Combines two ICollection of ICardModel together and returns it.
    /// </summary>
    /// <param name="cards">
    /// The ICollection of cards that will be added from.
    /// </param>
    /// <param name="deck">
    /// The ICollection of cards that will be added to.
    /// </param>
    /// <returns>
    /// ICollection of ICardModel that merges the two card inputs and deck inputs together.
    /// </returns>
    #endregion
    public ICollection<ICardModel> AddCardsToDeck(ICollection<ICardModel> cards, ICollection<ICardModel> deck)
    {
        #region Validate paramteters
        if (deck == null)
        {
            throw new ArgumentException($"{nameof(deck)} cannot be null");
        }
        if (deck.Count == 0)
        {
            throw new ArgumentException($"Length of {nameof(deck)} must be greater than 0");
        }
        #endregion

        deck.Add(DealCard(cards));

        return deck;
    }

    #region Create New Deck Documentation
    /// <summary>
    /// Creates a new standard 52 card deck.
    /// </summary>
    /// <returns>
    /// A standard 52 card deck grouped by suit and sorted by value.
    /// </returns>
    #endregion
    public ICollection<ICardModel> CreateNewDeck()
    {
        string[] suits = { "♠", "♣", "♡", "♢" };
        string[] values = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };

        var return_list = new List<ICardModel>();
        foreach (string s in suits)
        {
            foreach (string v in values)
            {
                return_list.Add(new CardModel
                {
                    Suit = s,
                    Value = v
                });
            }
        }
        return return_list;
    }

    #region Deal Card Documentation
    /// <summary>
    /// Returns a single card from the top of a given deck of cards. That same card is removed from the list of cards.
    /// </summary>
    /// <param name="deck">
    /// Collection of ICardModel that the card will be removed from.
    /// </param>
    /// <returns>
    /// The top card of a deck
    /// </returns>
    #endregion
    public ICardModel DealCard(ICollection<ICardModel> deck)
    {
        #region Validate paramteters
        if (deck == null)
        {
            throw new ArgumentException($"{nameof(deck)} cannot be null");
        }
        if (deck.Count == 0)
        {
            throw new ArgumentException($"Length of {nameof(deck)} must be greater than 0");
        }
        #endregion
        ICardModel? topCard = deck.FirstOrDefault();

        if (topCard == null)
        {
            throw new ArgumentException($"Items in {nameof(deck)} must not be null");
        }
        else
        {
            deck.Remove(topCard);
        }

        return topCard;
    }

    #region Shuffle Deck Documentation
    /// <summary>
    /// Randomizes the order of the cards in the deck.
    /// </summary>
    /// <param name="deck">
    /// ICollection of ICardModel that will be shuffled.
    /// </param>
    /// <returns>
    /// ICollection of ICardModel that will have the same cards in the deck, but will be in a different order.
    /// </returns>
    #endregion
    public ICollection<ICardModel> ShuffleDeck(ICollection<ICardModel> deck)
    {
        List<ICardModel>? _deckList = deck as List<ICardModel>;
        #region Validate paramteters
        if (_deckList == null)
        {
            throw new ArgumentException($"{nameof(deck)} cannot be null");
        }
        if (_deckList.Count == 0)
        {
            throw new ArgumentException($"Length of {nameof(deck)} must be greater than 0");
        }
        #endregion

        for (int i = 0; i > deck.Count() - 1; i++)
        {
            Random rand = new Random();
            var randomCard = rand.Next(0, deck.Count() - 1);

            ICardModel temp = _deckList[randomCard];
            _deckList[randomCard] = _deckList[i];
            _deckList[i] = temp;
        }
        return _deckList;
    }
}
