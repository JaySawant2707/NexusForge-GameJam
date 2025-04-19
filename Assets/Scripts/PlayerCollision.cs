using Unity.VisualScripting;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
   void OnCollisionEnter(Collision other)
   {
        if (other.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("Hit " + other.gameObject.name);
            Debug.Log("Game Over!");
            GameManager.Instance.GameOver();
        }
   }

   void OnTriggerEnter(Collider other)
   {
        if (other.gameObject.CompareTag("GravityTrigger"))
        {
            //gravity change logic
        }
   }
}
