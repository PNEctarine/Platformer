using Kuhpik;
using UnityEngine;

public class PlayerLoadingSystem : GameSystem, IIniting
{
    [SerializeField] private Rigidbody _player;

    void IIniting.OnInit()
    {
        game.PlayerRB = _player;
        game.PlayerRB.position = player.CurrentLevel.GetComponent<LevelComponent>().SpawnPoint.position;
    }
}
