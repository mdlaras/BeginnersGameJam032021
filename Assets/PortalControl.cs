using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalControl : MonoBehaviour
{
    [SerializeField] bool isTransport;
    [SerializeField] bool isChanger;
    [SerializeField] bool isPortalIn;
    [SerializeField] PortalControl portalOut;

    void OnCollisionEnter2D (Collision2D collision)
    {
        if(isTransport && isPortalIn)
        {
            collision.gameObject.transform.localPosition = portalOut.gameObject.transform.position;
        }
        if(isChanger)
        {
            collision.gameObject.GetComponent<DimensionSwitch>().SwitchDimension();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
