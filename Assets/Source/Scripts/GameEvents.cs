using System;
using UnityEngine;

public class GameEvents : MonoBehaviour
{
    public static Action<bool> JumpOff_E;

    public static void ClearEvents()
    {
        JumpOff_E = null;
    }
}
