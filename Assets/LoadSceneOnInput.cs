using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneOnInput : MonoBehaviour {

	private string nextScene;
	public int mazeNumber;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		// Get active scene
        Scene scene = SceneManager.GetActiveScene();

        // change scene according to the active scene
        if (scene.name == "Title")
        {
        	nextScene = "Play";
        }
        else if (scene.name == "GameOver")
        {
        	nextScene = "Title";
        }

		if (Input.GetAxis("Submit") == 1) 
		{
			SceneManager.LoadScene(nextScene);
		}
	}
}
