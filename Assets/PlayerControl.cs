using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    bool isGrounded = true;
    [SerializeField] float jumpHeight;
    [SerializeField] float velocity;
    // Start is called before the first frame update
    void Start()
    {
    }

    void OnCollisionEnter2D (Collision2D collision)
    {
        isGrounded = true;
    }

    void OnCollisionExit2D (Collision2D collision)
    {
        isGrounded = false;
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.D))
        {
            transform.localPosition += new Vector3(-velocity,0,0) * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.A))
        {
            transform.localPosition += new Vector3(velocity,0,0) * Time.deltaTime;
        }
        if(Input.GetKeyDown(KeyCode.W) && isGrounded)
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0,jumpHeight), ForceMode2D.Force);
        }
    }
}
