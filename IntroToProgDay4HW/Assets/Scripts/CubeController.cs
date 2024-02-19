using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Main.Character;
using Main.Utlities;
using AnimatorController;


namespace Main.Utlilities
{
    public class CubeController : MonoBehaviour
    {
        //data fields
        bool up = true;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            //Move up if reached position
            if (up)
            {
                transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, 1.16f, transform.position.z), Time.deltaTime / 2);
                if (transform.position == new Vector3(transform.position.x, 1.16f, transform.position.z))
                {
                    up = false;
                }
            }
            //Move down if reached position
            if (!up)
            {
                transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, 0.023f, transform.position.z), Time.deltaTime / 2);
                if (transform.position == new Vector3(transform.position.x, 0.023f, transform.position.z))
                {
                    up = true;
                }
            }


        }
    }
}



