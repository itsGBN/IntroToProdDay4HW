using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;
using Main.Character;
using Main.Utlities;
using AnimatorController;


namespace Main.Character
{
    public class EnemyController : MonoBehaviour
    {
        //data feilds
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
            //move the enemy to the payer
            nav.SetDestination(playerPosition.position);
            nav.speed += 0.002f;
            if (nav.speed > 4)
            {
                nav.speed = 4;
            }
        }
    }
}

