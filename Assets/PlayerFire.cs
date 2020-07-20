using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerFire : MonoBehaviour
{
    public GameObject gun;
    Vector3 direction;

    public float attackSpeed;
    public float attackReadyTime;

    public int bulletCount;
    public Text bulletCountText;

    void Update()
    {
        
        if (Input.GetMouseButton(0))
        {
            
            if (attackReadyTime<Time.time&&bulletCount>0)
            {
                direction = Camera.main.transform.forward;
                gun.transform.GetComponent<WeaponController>().BulletFire(direction, transform.rotation);
                attackReadyTime = Time.time + (1 / attackSpeed);
                bulletCount--;
                bulletCountText.text = bulletCount.ToString();
            }
        }
    }
}