using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    [SerializeField] bool isGrounded;
    [SerializeField] float jumpHeight;
    [SerializeField] float velocity;
    [SerializeField] Transform foot;
    [SerializeField] float footRadius;
    [SerializeField] LayerMask mask;
    [SerializeField] SpriteRenderer eye;
    // Start is called before the first frame update
    void Start()
    {
    }

    void AnimationControl()
    {
        if(Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.RightArrow))
        {
            gameObject.GetComponent<Animator>().SetBool("isMoving", false);
        }
        else if(Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow))
        {
            gameObject.GetComponent<Animator>().SetBool("isMoving", true);
        }
    }
    // Update is called once per frame
    void Update()
    {
        AnimationControl();
        isGrounded = Physics2D.OverlapCircle(foot.position, footRadius, mask) != null ? true : false;
       
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.localPosition += new Vector3(-velocity,0,0) * Time.deltaTime;
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
            eye.flipX = true;
        }
        else if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.localPosition += new Vector3(velocity,0,0) * Time.deltaTime;
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
            
        }
        if(Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0,jumpHeight), ForceMode2D.Force);
        }
        
    }
}
