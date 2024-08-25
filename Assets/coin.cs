using UnityEngine;

public class coin : MonoBehaviour
{
   
    public GameManagerS gm; 

    // This function is called when another object enters the collider
    private void OnTriggerEnter(Collider other)
    {
        // Check if the object that collided with the coin is tagged as "Player"
        if (other.gameObject.CompareTag("Player"))
        {
          
            gm.coinAdd();
            // Destroy the coin after it's collected
            Destroy(gameObject);
        }
    }
}