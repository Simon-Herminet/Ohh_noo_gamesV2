using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;
public class PlayerColision : MonoBehaviour
{
    public int life = 3;
    public TMP_Text GameOverText;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("spikes"))
        {
            TakeDamages(3);
        }
        if (collision.CompareTag("Endlevel"))
        {
            if (PlayerPrefs.GetInt("MobDestroyed", 0) == 1)
            {
                print("Bravo !");
            }
            else
            {
                print("Il faut détruire le monstre !");
            }
        }
    }

    public void TakeDamages(int damage)
    {
        life -= damage;

        if (life <= 0)
        {
            Die();
        }
    }

    public void Die()
    {
        Debug.Log("Le joueur est mort !");
        GetComponent<Rigidbody2D>().AddForce(Vector3.up * 180);
        GetComponent<Collider2D>().isTrigger = true;
        GameOverText.gameObject.SetActive(true);
        Invoke("RestartLevel", 3);
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        // SceneManager.LoadScene(1);
    }
}
