using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int dimensionShard;

    private void Awake()
    {
        // if (SaveManager.Instance.hasLoaded)
        // {
        //     dimensionShard = SaveManager.Instance.activeSave.dimensionShard;
        // }
        // else
        // {
        //     SaveManager.Instance.activeSave.dimensionShard = dimensionShard;
        // }

        GameObject[] objs = GameObject.FindGameObjectsWithTag("GameManager");

        if (objs.Length > 1)
        {
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(this.gameObject);
    }
}
