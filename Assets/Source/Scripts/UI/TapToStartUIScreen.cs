using Kuhpik;
using UnityEngine;
using UnityEngine.UI;

public class TapToStartUIScreen : UIScreen
{
    [SerializeField] private Button TapToStartButton;

    private void Start()
    {
        TapToStartButton.onClick.AddListener(() => Bootstrap.ChangeGameState(EGamestate.Game));
    }
}
