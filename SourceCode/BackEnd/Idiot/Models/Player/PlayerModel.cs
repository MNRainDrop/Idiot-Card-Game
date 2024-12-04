namespace Models;

public class PlayerModel : IPlayerModel
{
    public string Username { get; set; }
    public ICollection<ICardModel>? Hand { get; set; }
    public ICollection<ICardModel>? FaceDownLife { get; set; }
    public ICollection<ICardModel>? FaceUpLife { get; set; }
    
    public PlayerModel(string username)
    {
        Username = username;
    }
}
