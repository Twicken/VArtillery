using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{

    public GameObject terrain;
    public GameObject bedrock;
    public float TextureDamageRadius = 22f;
    public float TerrainDamageRadius = 22f;
    public GameObject explosion;

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
            GameObject explosionClone = Instantiate(explosion, c.contacts[0].point, Quaternion.Euler(new Vector3(0, 0, 0)));

            Destroy(explosionClone, 2);
            Destroy(this.gameObject);
        }
    }

}
