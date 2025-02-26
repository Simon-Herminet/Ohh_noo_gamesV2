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
