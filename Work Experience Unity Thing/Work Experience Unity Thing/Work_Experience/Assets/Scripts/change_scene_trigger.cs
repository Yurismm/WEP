using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
// this is for scene management ^^


public class change_scene_trigger : MonoBehaviour
{
    // Start is called before the first frame update

    public int scene = 2;

    // defined string here to allow me to change the scene number from unity

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")

            // player will be a tag which i can make for only the player,
            // this makes sure that the game does not think or allow any other object to trigger this event
            
        {
            SceneManager.LoadScene(scene);

            // i call the above over here (scene)

            // this numbber is configured from the build settings
            // 1 here is just the other scene, there will be multiple switches for this
            // this is the level 1 one, it just is specific to the cube


        }
    }


}
