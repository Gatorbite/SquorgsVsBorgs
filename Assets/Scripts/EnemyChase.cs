using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyChase : MonoBehaviour
{

    public NavMeshAgent Enemy;
    public Transform Player;

    // Start is called before the first frame update
    private void Awake()
    {
        Player = GameObject.FindWithTag("Player").transform;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Enemy.SetDestination(Player.position);
    }


}
