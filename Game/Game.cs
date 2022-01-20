using Game.Entity;

namespace Game;

public class Game
{
    public void Start(IEnumerable<Player> players)
    {
        foreach (var player in players)
        {
        }
    }
        
    public void Stop() {}
    public void Save() {}
}