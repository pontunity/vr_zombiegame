using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateEnemies : MonoBehaviour
{
    public GameObject theEnemy;
    public int xpos;
    public int zpos;
    public int enemyCount;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(EnemyDrop());
    }
        IEnumerator EnemyDrop()
        {
            while (enemyCount < 5)
            {
                xpos = Random.Range(-9, 15);
                zpos = Random.Range(48, 55);
                Instantiate(theEnemy, new Vector3(xpos, 0, zpos), Quaternion.identity);
                yield return new WaitForSeconds(0.1f);
                enemyCount += 1;
            }
        }

    public void respawn()
    {
        Instantiate(theEnemy, new Vector3(xpos, 0, zpos), Quaternion.identity);
        /*
        {
            if (theEnemy != null)
            {
                Destroy(gameObject);
            }
        }
        */
    }

    }


