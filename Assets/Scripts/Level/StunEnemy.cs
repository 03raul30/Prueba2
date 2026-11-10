using UnityEngine;

public class StunEnemy : MonoBehaviour
{
    [SerializeField] float stunTime = 1f;

    void OnTriggerEnter2D(Collider2D other)
    {
        PlayerPhysics player = other.GetComponent<PlayerPhysics>();
        if (player != null)
        {
            
            //player.Stun(stunTime)
        }
    }
}
