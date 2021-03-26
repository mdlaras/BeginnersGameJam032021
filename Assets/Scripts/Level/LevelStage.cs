using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelStage : MonoBehaviour
{
    public int shardTotal;

    public string sceneName;

    public Button stageButton;

    public Text textButton;

    private void Start()
    {
        if (SaveManager.Instance.hasLoaded)
        {
            if (SaveManager.Instance.activeSave.dimensionShard >= shardTotal)
            {
                stageButton.interactable = true;
            }

            textButton.text = SaveManager.Instance.activeSave.dimensionShard + "/" + shardTotal;
        }
    }

    public void LoadScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}
