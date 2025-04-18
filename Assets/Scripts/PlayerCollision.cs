using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
   void OnCollisionEnter(Collision other)
   {
        if (other.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("Hit " + other.gameObject.name);
            Debug.Log("Game Over!");
        }
   }

   void OnTriggerEnter(Collider other)
   {
        if (other.gameObject.CompareTag("Collectible"))
        {
            Debug.Log("Collected " + other.gameObject.name);
        }
   }
}
