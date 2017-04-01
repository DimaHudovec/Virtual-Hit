using UnityEngine;
using System.Collections;

public class BackButtonDevice : MonoBehaviour {

    private static string previousScene = "";
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Application.platform == RuntimePlatform.Android)
        {
            if (Input.GetKey(KeyCode.Escape))
            {
                if(previousScene != "" || previousScene != "PauseMenu")
                {
                    if (previousScene == "AR4good")
                        Pause.current.SetPause();

                    Application.LoadLevel(previousScene);
                }
            }
        }
    }

    public static void setPreviousScene(string currentScene)
    {
        previousScene = currentScene;
    }
}
