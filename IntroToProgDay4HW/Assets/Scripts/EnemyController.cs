using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using AnimatorController;

public class EnemyController : MonoBehaviour
{

    [SerializeField] Transform playerPosition;
    NavMeshAgent nav;

    // Start is called before the first frame update
    void Start()
    {
        nav = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        nav.SetDestination(playerPosition.position);
        nav.speed += 0.001f;
        if(nav.speed > 7)
        {
            nav.speed = 7;
        }

    }
}
