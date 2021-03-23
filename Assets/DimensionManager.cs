using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DimensionManager : MonoBehaviour
{
    DimensionSwitch[] childrenTerrain;

    void Start()
    {
        childrenTerrain = GetComponentsInChildren<DimensionSwitch>();
    }

    public void ChangeTerrainDimension()
    {
        foreach(DimensionSwitch terrainDimension in childrenTerrain)
        {
            terrainDimension.SwitchDimension();
            terrainDimension.AdjustCollider(FindObjectOfType<PlayerControl>().GetComponent<DimensionSwitch>().Dimension);
        }
    }
    // Update is called once per frame
    void Update()
    {
        foreach(DimensionSwitch terrainDimension in childrenTerrain)
        {
            terrainDimension.AdjustCollider(FindObjectOfType<PlayerControl>().GetComponent<DimensionSwitch>().Dimension);
        }
    }
}
