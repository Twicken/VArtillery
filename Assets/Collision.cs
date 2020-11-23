using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{

    public GameObject terrain;

    // Start is called before the first frame update
    void Start()
    {
        terrain = GameObject.Find("Terrain");
    }

    public void OnCollisionEnter(UnityEngine.Collision c)
    {

        if (c.transform.tag == "Terrain")
        {
            float TextureDamageRadius = 5f;
            float TerrainDamageRadius = 5f;
            terrain.GetComponent<TerrainDeformer>().DestroyTerrain(c.contacts[0].point, TerrainDamageRadius, TextureDamageRadius);
        }
    }

}
