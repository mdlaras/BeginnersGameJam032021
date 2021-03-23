using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.localPosition += new Vector3(-5,0,0) * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.localPosition += new Vector3(5,0,0) * Time.deltaTime;
        }
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.localPosition += new Vector3(0,100,0) * Time.deltaTime;
        }
    }
}
