using UnityEngine;
using System.Collections;

public class OptionMenu : MonoBehaviour {
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
    }

    public bool GetButtonStatus()
    {
        return this.buttonIsClicked;
    }
}
