using UnityEngine;
using System.Collections;

//open MainMenuScene
public class OpenMainMenu : MonoBehaviour {

    public void OnMouseDown()
    {
        Application.LoadLevel("Menu");
    }
}
