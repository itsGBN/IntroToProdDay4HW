using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Main.Character;
using Main.Utlities;
using AnimatorController;

namespace AnimatorController
{
    public class AnimationController : MonoBehaviour
    {
        //data fields
        Animator anim;
        [SerializeField] GameObject Player;
        [SerializeField] SpriteRenderer[] Parts;

        void Start ()
        {
            //initalize
            anim = Player.GetComponent<Animator>();
        }
        public void Running()
        {
            //start the running animation
            anim.SetBool("isRunning", true);
        }

        public void Idle()
        {
            //start the idle animation
            anim.SetBool("isRunning", false);
        }

        public void Left ()
        {
            //flip the charcter
            foreach (var part in Parts)
            {
                part.flipX = false;
            }
        }

        public void Right ()
        {
            //flip the charcter
            foreach (var part in Parts)
            {
                part.flipX = true;
            }
        }
    }
}

