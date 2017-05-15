using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour {
    public AudioSource audioSource;
    // Use this for initialization
    void Start () {
        audioSource.volume = VolumeSource.Volume;
    }
    
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape) || Input.GetKeyDown(KeyCode.Menu)) {
            Debug.Log("Score is saved: " + VirtualButtonEventHandler.Score + VirtualButtonEventHandler.Lifes);
            ScoreClass.Score = VirtualButtonEventHandler.Score;
            ScoreClass.Lifes = VirtualButtonEventHandler.Lifes;
            Application.LoadLevel("PauseMenu");
        }
			
	}
}
