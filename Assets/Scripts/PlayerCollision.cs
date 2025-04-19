using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    [SerializeField] GameManager gm;
   void OnCollisionEnter(Collision other)
   {
        if (other.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("Hit " + other.gameObject.name);
            Debug.Log("Game Over!");
            gm.GameOver();
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
