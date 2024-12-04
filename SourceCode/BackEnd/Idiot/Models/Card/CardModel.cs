namespace Models;

public class CardModel : ICardModel
{
    public string? Suit { get; set; }
    public string? Value { get; set; }
    public CardModel()
    {
        Suit = null;
        Value = null;
    }
}
