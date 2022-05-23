using Kuhpik;
using UnityEngine;

public class LevelLoadingSystem : GameSystem, IIniting
{
    [SerializeField] private int _maxLevel;

    private const string _levelsPath = "Levels/Level{0}";
    private GameObject _levelGameObject;

    void IIniting.OnInit()
    {
        if (Bootstrap.GetLastGamestate() != EGamestate.Lose)
        {
            player.LevelToLoad = player.Level < _maxLevel ? player.Level : Random.Range(0, _maxLevel);
        }

        _levelGameObject = Resources.Load<GameObject>(string.Format(_levelsPath, player.LevelToLoad + 1));
        player.CurrentLevel = Instantiate(_levelGameObject);
    }
}
