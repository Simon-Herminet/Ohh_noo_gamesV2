using UnityEngine;
using TMPro ;
using UnityEngine.UI;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public TMP_Text WinnerText;

    public GameObject WinnerPanel;
    public GameObject button;
    
    public void OnTriggerEnter2D(Collider2D collision){

        if (collision.CompareTag("Player"))
        {
        Debug.Log("Tas gagné BG");
        WinnerText.gameObject.SetActive(true);
        WinnerPanel.gameObject.SetActive(true);
        button.gameObject.SetActive(true);
        }
    }

    
}
