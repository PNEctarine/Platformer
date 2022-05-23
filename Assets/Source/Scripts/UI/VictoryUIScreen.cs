using Kuhpik;
using UnityEngine;
using UnityEngine.UI;

public class VictoryUIScreen : UIScreen
{
    [SerializeField] private Button _nextButton;

    private void Start()
    {
        _nextButton.onClick.AddListener(() => Bootstrap.GameRestart(0));
    }
}
