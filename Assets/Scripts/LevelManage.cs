using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManage : MonoBehaviour
{
    
    public void Openlevel(int levelID)
    {
        SceneManager.LoadScene(levelID);
    }

}