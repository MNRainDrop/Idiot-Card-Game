namespace Models;

public interface IPlayerModel
{
    public string Username { get; set; }
    public ICollection<ICardModel>? Hand { get; set; }
    public ICollection<ICardModel>? FaceDownLife { get; set; }
    public ICollection<ICardModel>? FaceUpLife { get; set; }
}
