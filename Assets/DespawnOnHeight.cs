using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DespawnOnHeight : MonoBehaviour
{
	public float yPos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        yPos = transform.position.y;
        // yPos of the player is 1.238275 standing on floor; less than that means player has fallen
        if (yPos < 1.2) {
        	DontDestroy.instance = null;
        	Destroy(GameObject.Find("WhisperSource"));
        	LevelGenerator.mazeNumber = 1;
        	SceneManager.LoadScene("GameOver");
        }
    }
}
