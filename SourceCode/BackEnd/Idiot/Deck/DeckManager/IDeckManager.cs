namespace Deck;
using Models;

public interface IDeckManager
{
    public ICollection<ICardModel> CreateNewDeck();
    public ICardModel DealCard(ICollection<ICardModel> deck);
    public ICollection<ICardModel> ShuffleDeck(ICollection<ICardModel> deck);
    public ICollection<ICardModel> AddCardsToDeck(ICollection<ICardModel> cards, ICollection<ICardModel> deck);

}
