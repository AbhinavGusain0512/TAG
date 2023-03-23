using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun : MonoBehaviour
{
    public Transform BulletSpawnPoint;
    public GameObject bulletPrefabL;
    public GameObject bulletPrefabR;
    public float bulletSpeed = 10;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0)){
            var bullet = Instantiate(bulletPrefabL, BulletSpawnPoint.position, BulletSpawnPoint.rotation);
            bullet.GetComponent<Rigidbody>().velocity = BulletSpawnPoint.forward * bulletSpeed;
        }
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            var bullet = Instantiate(bulletPrefabR, BulletSpawnPoint.position, BulletSpawnPoint.rotation);
            bullet.GetComponent<Rigidbody>().velocity = BulletSpawnPoint.forward * bulletSpeed;
        }

    }
}
