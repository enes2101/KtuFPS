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
        BulletController bullet=Instantiate(wData.bulletPrefab,wData.barrel.transform.position,rotation).GetComponent<BulletController>();
        bullet.Init();
        bullet.transform.GetComponent<BulletController>().BulletThrowForce(bullet.transform.position,wData.shootingRange,dir);
    }
}
