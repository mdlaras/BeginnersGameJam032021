using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int dimensionShard;
    [SerializeField] AudioSource changeStageSound;
    [SerializeField] AudioSource shardCollectSound;

    private void Start()
    {
        if (SaveManager.Instance.hasLoaded)
        {
            dimensionShard = SaveManager.Instance.activeSave.dimensionShard;
        }
    }

    private void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("GameManager");

        if (objs.Length > 1)
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }

    public void PlayStageChangeSound()
    {
        changeStageSound.Play();
    }

    public void PlayCollectShardSound()
    {
        shardCollectSound.Play();
    }
}
