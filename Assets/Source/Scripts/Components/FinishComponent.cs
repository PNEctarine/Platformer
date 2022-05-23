using Kuhpik;
using UnityEngine;

public class FinishComponent : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out PlayerCollisionComponent player))
        {
            Bootstrap.ChangeGameState(EGamestate.Victory);
        }
    }
}
