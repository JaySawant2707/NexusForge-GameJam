using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
   void OnCollisionEnter(Collision other)
   {
        if (other.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("Hit " + other.gameObject.name);
        }
   }
}
