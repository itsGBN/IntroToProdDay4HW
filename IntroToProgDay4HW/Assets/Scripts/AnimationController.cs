using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AnimatorController
{
    public class AnimationController : MonoBehaviour
    {
        Animator anim;
        [SerializeField] GameObject Player;
        [SerializeField] SpriteRenderer[] Parts;

        void Start ()
        {
            anim = Player.GetComponent<Animator>();
        }
        public void Running()
        {
            anim.SetBool("isRunning", true);
        }

        public void Idle()
        {
            anim.SetBool("isRunning", false);
        }

        public void Left ()
        {
            foreach (var part in Parts)
            {
                part.flipX = false;
            }
        }

        public void Right ()
        {
            foreach (var part in Parts)
            {
                part.flipX = true;
            }
        }
    }
}

