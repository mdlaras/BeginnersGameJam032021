using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DimensionSwitch : MonoBehaviour
{
    public int Dimension;
    [SerializeField] SpriteRenderer objectSprite;
    [SerializeField] DimensionSwitch playerDimension;
    [SerializeField] bool isPlayer;
    [SerializeField] BoxCollider2D boxCollider2D;

    void ChangeColor()
    {
        if(Dimension == 0)
        {
            objectSprite.color = Color.blue;
        }
        else
        {
            objectSprite.color = Color.red;
        }
    }

    void AdjustCollider()
    {
        if(Dimension == FindObjectOfType<PlayerControl>().GetComponent<DimensionSwitch>().Dimension)
        {
            boxCollider2D.enabled = true;
        }
        else
        {
            boxCollider2D.enabled = false;
        }
    }
    public void SwitchDimension()
    {
        ++Dimension;
        if(Dimension == 2)
        {
            Dimension -= 2;
        }
        if(!isPlayer)
        {
            AdjustCollider();
        }
        ChangeColor();
    }

    void Start()
    {
        ChangeColor();
        AdjustCollider();
    }

    void Update()
    {
        if(!isPlayer)
        {
            if(Input.GetKeyUp(KeyCode.Space))
            {
                SwitchDimension();
            }
            AdjustCollider();
        }
    }
}
