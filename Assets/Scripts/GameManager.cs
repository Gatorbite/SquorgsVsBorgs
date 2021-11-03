using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager singleton;
    public GameObject EnemyPrefab;    
    private int xPos;
    private int zPos;
    public int enemyCount;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);

        if (singleton != null && singleton != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            singleton = this;
        }
    }
        // Start is called before the first frame update
        void Start()
    {
        StartCoroutine(EnemySpawn());        
    }  

    IEnumerator EnemySpawn()
    {
        while(true)
        {
            if(enemyCount < 10)
            {
                xPos = Random.Range(1, 4);
                zPos = Random.Range(1, 56);
                Instantiate(EnemyPrefab, new Vector3(xPos, 2, zPos), Quaternion.identity);
                enemyCount += 1;
            }            
            yield return new WaitForSeconds(1);            
        }
    }

    public void decreaseEnemy()
    {
        enemyCount--;
    }




}
