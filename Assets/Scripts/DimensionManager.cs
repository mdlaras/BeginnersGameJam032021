using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DimensionManager : MonoBehaviour
{
    DimensionSwitch[] childrenTerrain;
    DimensionSwitch player;

    void Start()
    {
        childrenTerrain = GetComponentsInChildren<DimensionSwitch>();
        player = FindObjectOfType<PlayerControl>().GetComponent<DimensionSwitch>();
    }

    public void ChangeTerrainDimension()
    {
        var playerDimension =  player.currentDimension;
        foreach(DimensionSwitch terrainDimension in childrenTerrain)
        {
            terrainDimension.SwitchDimension();
            terrainDimension.AdjustCollider(playerDimension);
        }
    }

    public void AdjustTerrain()
    {
        var playerDimension =  player.currentDimension;
        foreach(DimensionSwitch terrainDimension in childrenTerrain)
        {
            terrainDimension.AdjustCollider(playerDimension);
        }
    }
}
