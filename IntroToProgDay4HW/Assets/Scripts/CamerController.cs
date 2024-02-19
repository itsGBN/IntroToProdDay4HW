using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Main.Character;
using Main.Utlities;
using AnimatorController;


namespace Main.Utlilities
{
    public class CamerController : MonoBehaviour
    {
        [SerializeField] GameObject Player;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            //Make the camera follow the player
            transform.position = new Vector3(Player.transform.position.x + 0.12f, Player.transform.position.y + 5.04f, Player.transform.position.z - 6f);
        }
    }
}


