using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour {
	// Use this for initialization
	void Start () {
	}
    
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape) || Input.GetKeyDown(KeyCode.Menu)) {
            Debug.Log("Score is saved: " + VirtualButtonEventHandler.Score);
            ScoreClass.Score = VirtualButtonEventHandler.Score;
            Application.LoadLevel("PauseMenu");
        }
			
	}
}
