using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyController : MonoBehaviour
{
    ScoreController scoreControl;
    public int enemyHP;
    public int point;

    // Start is called before the first frame update
    void Start()
    {
        scoreControl = GameObject.Find("GameController").GetComponent<ScoreController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(int damage)
    {
        enemyHP -= damage;
        if (enemyHP <= 0)
        {
            GameObject.Find("GameController").GetComponent<EnemySpawn>().CreateEnemy(this.transform.position);
            Debug.Log("object spawned");
            Destroy(this.gameObject);
            scoreControl.IncreaseScore(point);
        }
    }
}
