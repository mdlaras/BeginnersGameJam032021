using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalControl : MonoBehaviour
{
    [SerializeField] bool isTransport;
    [SerializeField] bool isChanger;
    [SerializeField] bool isPortalIn;
    [SerializeField] PortalControl portalOut;

    void OnTriggerEnter2D (Collider2D collision)
    {
        if(isTransport && isPortalIn)
        {
            collision.gameObject.transform.localPosition = portalOut.gameObject.transform.position;
        }
        if(isChanger)
        {
            FindObjectOfType<DimensionManager>().ChangeTerrainDimension();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
