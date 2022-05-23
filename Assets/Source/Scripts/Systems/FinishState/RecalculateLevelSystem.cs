using Kuhpik;
using UnityEngine;

public class RecalculateLevelSystem : GameSystem, IIniting
{
    private const string _animatorParameter = "State";

    void IIniting.OnInit()
    {
        GameEvents.ClearEvents();

        game.PlayerRB.GetComponentInChildren<Animator>().SetInteger(_animatorParameter, 4);
        player.Level++;
    }
}
