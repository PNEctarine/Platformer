using UnityEngine;

public class PlayerCollisionComponent : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Dynamic"))
        {
            gameObject.transform.parent = collision.transform;
        }

        if (collision.gameObject.layer == LayerMask.NameToLayer("Dynamic") || collision.gameObject.layer == LayerMask.NameToLayer("Static"))
        {
            GameEvents.JumpOff_E?.Invoke(true); 
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Dynamic"))
        {
            gameObject.transform.parent = null;
        }

        if (collision.gameObject.layer == LayerMask.NameToLayer("Dynamic") || collision.gameObject.layer == LayerMask.NameToLayer("Static"))
        {
            GameEvents.JumpOff_E?.Invoke(false); 
        }
    }
}
