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
    public class PlayerController : MonoBehaviour
    {
        //refernce to rigidbody
        [SerializeField] Rigidbody playerRigidBody;
        //data fields
        public float speed = 5f;
        bool grounded = true;
        NavMeshAgent agent;

        AnimationController animator;

        // Start is called before the first frame update
        void Start()
        {
            //initialize componenets
            agent = GetComponent<NavMeshAgent>();
            animator = GetComponent<AnimationController>();
        }

        // Update is called once per frame
        void Update()
        {
            //Movemnt Inputs
            if (Input.GetKey(KeyCode.A)) { transform.position += new Vector3(-speed * Time.deltaTime, 0, 0); animator.Left(); }
            if (Input.GetKey(KeyCode.D)) { transform.position += new Vector3(speed * Time.deltaTime, 0, 0); animator.Right(); }
            if (Input.GetKey(KeyCode.W)) { transform.position += new Vector3(0, 0, speed * Time.deltaTime); }
            if (Input.GetKey(KeyCode.S)) { transform.position += new Vector3(0, 0, -speed * Time.deltaTime); }

            //Jumo movemeny
            if (Input.GetKeyDown(KeyCode.Space) && grounded) { playerRigidBody.AddForce(Vector3.up * 400); grounded = false; }

            //Animaion Controller
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S)) { animator.Running(); }
            else { animator.Idle(); }

        }

        private void OnCollisionEnter(Collision collision)
        {
            //check if the player on the floor
            if (collision.gameObject.tag == "ground") { grounded = true; }
        }

        private void OnTriggerEnter(Collider other)
        {
            //check if player is tagged
            if (other.gameObject.tag == "enemy") { SceneManager.LoadScene("New Scene 1"); }
        }
    }
}


