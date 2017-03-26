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
        Debug.Log("Pushed play game");
        Application.LoadLevel("AR4good");
        //EditorSceneManager.CreateScene("AR4good");
        //SceneManager.CreateScene("AR4good");
        //Application.loadedLevelName
    }
    
}
