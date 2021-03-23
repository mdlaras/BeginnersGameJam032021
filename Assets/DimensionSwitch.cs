using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DimensionSwitch : MonoBehaviour
{
    public int Dimension;
    [SerializeField] SpriteRenderer objectSprite;
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

    public void AdjustCollider(int player)
    {
        if(Dimension == player)
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
            AdjustCollider(FindObjectOfType<PlayerControl>().GetComponent<DimensionSwitch>().Dimension);
        }
        ChangeColor();
    }

    void Start()
    {
        ChangeColor();
        AdjustCollider(FindObjectOfType<PlayerControl>().GetComponent<DimensionSwitch>().Dimension);
    }

    void Update()
    {
        if(isPlayer)
        {
            if(Input.GetKeyUp(KeyCode.Space))
            {
                SwitchDimension();
            }
        }
    }
}
