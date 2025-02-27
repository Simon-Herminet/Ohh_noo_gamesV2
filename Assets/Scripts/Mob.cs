using UnityEngine;

public class Mob : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision) 
    {
        if (collision.gameObject.CompareTag("Player")) 
        {
            PlayerPrefs.SetInt("MobDestroyed", 1) ;
            Destroy (gameObject);
        }
    }
}

