using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelController : MonoBehaviour
{
    public bool isActive = false;
    void Start()
    {
       gameObject.SetActive(isActive); 
    }

    public void ToggleActive()
    {
        isActive = !isActive;
        gameObject.SetActive(isActive);
    }
}
