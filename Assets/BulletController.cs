using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    float distance;
    
    public void BulletThrowForce(Vector3 firstPos,float range,Vector3 dir)
    {
        StartCoroutine(CheckDistance(firstPos,range,dir));
    }

    public IEnumerator CheckDistance(Vector3 firstPos,float range,Vector3 dir)
    {
        dir = dir.normalized;
        while (distance<range)
        {
            distance = Vector3.Distance(firstPos, transform.position);
            transform.position += dir;
            yield return new WaitForSeconds(0.1f);
        }

        Destroy(gameObject);
        Debug.Log("range out");
       
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
        Debug.Log("hit the object");
    }

}
