using UnityEngine;
using System.Collections;

//open MainMenuScene
public class OpenMainMenu : MonoBehaviour {

    public void OnMouseDown()
    {
        BackButtonDevice.setPreviousScene(Application.loadedLevelName);
        Application.LoadLevel("Menu");
    }
}
