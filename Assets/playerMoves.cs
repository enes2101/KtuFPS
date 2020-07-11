using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoves : MonoBehaviour
{

    public float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(WaitCoroutine());
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(moveSpeed * Input.GetAxis("Horizontal") * Time.deltaTime, 0f, moveSpeed * Input.GetAxis("Vertical") * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.position += new Vector3(0, 1, 0);
            StartCoroutine(WaitCoroutine());
            
        }
    }
    IEnumerator WaitCoroutine()
    {
        yield return new WaitForSeconds(0.2f);
        transform.position -= new Vector3(0, 1, 0);
    }
}