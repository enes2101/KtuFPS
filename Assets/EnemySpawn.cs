using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject enemyPrefab;
    public int xPos;
    public int zPos;
    public int enemyCount;

    private void Start()
    {
        StartCoroutine(EnemyDrop());
    }

    IEnumerator EnemyDrop()
    {
        while (enemyCount < 3)
        {
            Instantiate(enemyPrefab, new Vector3(xPos, 2, zPos), Quaternion.identity);
            yield return new WaitForSeconds(0.1f);
            enemyCount += 1;
            xPos += 20;
            zPos += 10;
        }
    }

}
