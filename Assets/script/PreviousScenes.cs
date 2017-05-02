using UnityEngine;
using System.Collections;
using UnityEditor;

public class PreviousScenes : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Debug.Log("Save: " + Application.loadedLevelName);
        ScenesSource.Name = Application.loadedLevelName;
        //EditorApplication.currentScene;
    }
}
