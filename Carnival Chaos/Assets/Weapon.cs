using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firepoint;
    public GameObject bulletPrefab;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Shoot", 2f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Shoot()
    {
        //Shooting
        Instantiate(bulletPrefab, firepoint.position, firepoint.rotation);
    }
}
