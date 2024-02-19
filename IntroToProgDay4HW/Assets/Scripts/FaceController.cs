using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Main.Character;
using Main.Utlities;
using AnimatorController;

namespace Main.Utlilities
{
    public class FaceController : MonoBehaviour
    {
        //Transform refernce
        Transform targetToLook;

        // Start is called before the first frame update
        void Start()
        {
            //find a refernece to the main camera
            targetToLook = Camera.main.transform;
        }

        // Update is called once per frame
        void Update()
        {
            //make the player look at the camera
            transform.rotation = Quaternion.LookRotation(targetToLook.forward, Vector3.up);
        }
    }
}
