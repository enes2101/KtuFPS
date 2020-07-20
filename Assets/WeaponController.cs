using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour
{

    WeaponData wData;

    // Start is called before the first frame update
    void Start()
    {
        wData = transform.GetComponent<WeaponData>();
    }

    public void BulletFire(Vector3 dir,Quaternion rotation)
    {
        GameObject bullet=Instantiate(wData.bulletPrefab,wData.barrel.transform.position,rotation);
        bullet.transform.GetComponent<BulletController>().BulletThrowForce(bullet.transform.position,wData.shootingRange,dir);
    }
}
