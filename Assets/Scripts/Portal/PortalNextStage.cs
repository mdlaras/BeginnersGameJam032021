using UnityEngine;
using UnityEngine.SceneManagement;

public class PortalNextStage : MonoBehaviour
{
    public string sceneName;

    public bool isSave = false;
    public bool isLoad = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (isSave)
            {
                SaveManager.Instance.Save();
            }

            if (isLoad)
            {
                SaveManager.Instance.Load();
            }
                
            SceneManager.LoadScene(sceneName);
        }
    }
}
