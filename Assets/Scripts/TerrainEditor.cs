using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainEditor : MonoBehaviour
{
    public Terrain terrain;
    private float multiplier = 0.01f;
    // Start is called before the first frame update
    void Start()
    {
        var res = this.terrain.terrainData.heightmapResolution;
        var mesh = new float[res,res];
        mesh = this.terrain.terrainData.GetHeights(0,0,res,res);
        
        for (int i = 0; i < res; i++)
        {
            for (int j = 0; j < res; j++)
            {
                mesh[i,j] = Mathf.PerlinNoise(i* multiplier, j * multiplier) * 0.1f;
            }
        }
        this.terrain.terrainData.SetHeights(0,0,mesh);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
