using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject projectilePrefab;
    public Transform firePoint;
    public float fireRate = 0.5f;
    private float nextFireTime = 0f;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButton("Fire1") && Time.time >= nextFireTime){
            Shoot();
            nextFireTime = Time.time + fireRate;
        
        }
    }

    void Shoot(){
        Instantiate(projectilePrefab, firePoint.position, firePoint.rotation);
    }
}
