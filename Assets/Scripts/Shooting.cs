using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform Gun;
    public GameObject bulletPrefrab;

    // Update is called once per frame
    
    public void Shoot()
    {
        Instantiate(bulletPrefrab, Gun.position, Gun.rotation);
    }
}
