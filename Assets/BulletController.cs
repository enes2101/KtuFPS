using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    float distance;
    BulletData bData;
    public Rigidbody rb;
    public int speed;

    public void Init()
    {
        bData = this.gameObject.GetComponent<BulletData>();
        rb = this.gameObject.GetComponent<Rigidbody>();
    }

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
            rb.MovePosition(transform.position + dir*Time.deltaTime*speed);
            yield return new WaitForSeconds(0.01f);
        }

        Destroy(gameObject);
        Debug.Log("range out");
       
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("enemy"))
        {
            collision.gameObject.GetComponent<EnemyController>().TakeDamage(50);
            Destroy(gameObject);
            Debug.Log("hit the object");
        }
        
    }

}
