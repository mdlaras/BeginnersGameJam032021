using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpikeController : MonoBehaviour
{
    GameObject dieScreen;
    void Start()
    {
        dieScreen = Resources.FindObjectsOfTypeAll<PanelController>()[0].gameObject;
    }

    void OnTriggerEnter2D(Collider2D collider2D)
    {
        dieScreen.GetComponent<PanelController>().ToggleActive();
        Destroy(collider2D.gameObject);
    }
}