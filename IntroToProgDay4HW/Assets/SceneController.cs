using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Main.Character;
using Main.Utlities;
using AnimatorController;


namespace Main.Utlities
{
    public class SceneController : MonoBehaviour
    {
        // Start is called before the first frame update    
        public void StartGame()
        {
            //go to game scene
            SceneManager.LoadScene("SampleScene");
        }
        public void ReserGame()
        {
            //go to main menu
            SceneManager.LoadScene("New Scene");
        }
    }
}



