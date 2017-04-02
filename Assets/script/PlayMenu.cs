using UnityEngine;
using System.Collections;

public class PlayMenu : MonoBehaviour {
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnMouseDown()
    {
        ScoreClass.Score = 0;
        Debug.Log("Play game");
        Application.LoadLevel("AR4good");
        //EditorSceneManager.CreateScene("AR4good");
        //SceneManager.CreateScene("AR4good");
        //Application.loadedLevelName
    }
    
}
