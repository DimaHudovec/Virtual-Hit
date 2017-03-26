using UnityEngine;
using System.Collections;

public class ExitMenu : MonoBehaviour {
    private bool buttonIsClicked = false;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnMouseDown()
    {
        this.buttonIsClicked = true;
        Application.Quit(); 
    }
   
    public bool GetButtonStatus()
    {
        return this.buttonIsClicked;
    }
}
