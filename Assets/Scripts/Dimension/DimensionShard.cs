using UnityEngine;

public class DimensionShard : MonoBehaviour
{
    public int shard;
        
    private GameObject _gameManager;

    private void Start()
    {
        if (SaveManager.Instance.hasLoaded)
        {
            switch (shard)
            {
                case 1:
                    gameObject.SetActive(SaveManager.Instance.activeSave.shard1);
                    break;
                case 2:
                    gameObject.SetActive(SaveManager.Instance.activeSave.shard2);
                    break;
                case 3:
                    gameObject.SetActive(SaveManager.Instance.activeSave.shard3);
                    break;
                default:
                    Debug.Log("dimension not found");
                    break;
            }
        }
    }

    private void Awake()
    {
        _gameManager = GameObject.Find("GameManager");
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            gameObject.SetActive(false);

            switch (shard)
            {
                case 1:
                    SaveManager.Instance.activeSave.shard1 = false;
                    break;
                case 2:
                    SaveManager.Instance.activeSave.shard2 = false;
                    break;
                case 3:
                    SaveManager.Instance.activeSave.shard3 = false;
                    break;
                default:
                    Debug.Log("dimension not found");
                    break;
            }

            _gameManager.GetComponent<GameManager>().dimensionShard++;
            
            SaveManager.Instance.activeSave.dimensionShard = _gameManager.GetComponent<GameManager>().dimensionShard;
            
            Debug.Log(_gameManager);
        }
    }
}
