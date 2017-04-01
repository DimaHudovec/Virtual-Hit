using UnityEngine;
using System.Collections;

//open PauseMenu
public class MenuButtonDevice : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
        if (Application.platform == RuntimePlatform.Android)
        {
            if(Input.GetKey(KeyCode.Menu))
            {
                Pause.current.SetPause();
                BackButtonDevice.setPreviousScene(Application.loadedLevelName);
                Application.LoadLevel("PauseMenu");
            }
        }
    }
}
