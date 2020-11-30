using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{

    public float speed = 40;
    public GameObject bullet;
    public Transform barrel;
    public AudioSource audioSource;
    public AudioClip audioClip;
    public int life = 10;
    public int exitOffset = 0;
    public bool UseYInstead = false;

    public void Fire()
    {
        GameObject spawnedBullet = Instantiate(bullet, barrel.position, barrel.rotation);
        if (UseYInstead)
        {
            spawnedBullet.GetComponent<Rigidbody>().velocity = speed * barrel.right;
        }
        else
        {
            spawnedBullet.GetComponent<Rigidbody>().velocity = speed * barrel.forward;


        }

        audioSource.PlayOneShot(audioClip);
        Destroy(spawnedBullet, life);

    }
    // Start is called before the first frame update
    //void Start()
    //{
        
    //}

    // Update is called once per frame
    //void Update()
    //{
        
    //}
}
