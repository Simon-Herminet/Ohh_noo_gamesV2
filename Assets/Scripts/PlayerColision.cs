using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerColision : MonoBehaviour
{
    public int life = 3;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("spikes"))
        {
            TakeDamages(3);
        }
        if (collision.CompareTag("Endlevel"))
        {
           if (PlayerPrefs.GetInt("MobDestroyed", 0 ) == 1)
           {
            print("Bravo !");
           }  else
           {
            print("Il faut détruire le monstre !");
           }
        }
    }
    public void TakeDamages(int damage)
    {
        life -= damage;

        Die();
    }

    public void Die()
    {
        GetComponent<Rigidbody2D>().AddForce(Vector3.up * 180);
        GetComponent<Collider2D>().isTrigger = true;
        Invoke("RestartLevel", 1);
    }
    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
