using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{

    public GameObject terrain;
    public float TextureDamageRadius = 22f;
    public float TerrainDamageRadius = 22f;

    // Start is called before the first frame update
    void Start()
    {
        terrain = GameObject.Find("Terrain");
    }

    public void OnCollisionEnter(UnityEngine.Collision c)
    {

        if (c.transform.tag == "Terrain")
        {

            terrain.GetComponent<TerrainDeformer>().DestroyTerrain(c.contacts[0].point, TerrainDamageRadius, TextureDamageRadius);
            Destroy(this.gameObject);
        }
    }

}
