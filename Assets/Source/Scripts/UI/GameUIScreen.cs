using Kuhpik;
using UnityEngine;
using UnityEngine.UI;

public class GameUIScreen : UIScreen
{
    [field: SerializeField] public FixedJoystick FixedJoystick { get; private set; }
    [field: SerializeField] public Button JumpButton { get; private set; }

    private void Start()
    {
        GameEvents.JumpOff_E += JumpSwitch; 
    }

    private void JumpSwitch(bool isActive)
    {
        JumpButton.enabled = isActive;
    }
}
