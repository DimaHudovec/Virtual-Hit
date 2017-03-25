using UnityEngine;
using System.Collections.Generic;
using Vuforia;
using System;

public class VirtualButtonEventHandler : MonoBehaviour, IVirtualButtonEventHandler {

	public int Score { get { return score; } }

    // Private fields to store the models
    private GameObject model_1;
    private GameObject model_2;
	private GameObject model_3;
	private int model_num;
	private int score;
	private float timer;
	public bool paused; 
	//private GameObject btn_1;
	//private GameObject btn_2;
    /// Called when the scene is loaded
	public static int GenerateModelNum()
	{
		System.Random rand = new System.Random ();
		return rand.Next(3);
	}

	public void SetNewModel()
	{
		model_num = GenerateModelNum ();
		switch (model_num) {
		case 0:
			model_1.SetActive (true);
			break;
		case 1:
			model_2.SetActive (true);
			break;
		case 2:
			model_3.SetActive (true);
			break;
		}
		timer = 2;
	}

	public void ResetModel()
	{
		switch (model_num) {
		case 0:
			model_1.SetActive (false);
			break;
		case 1:
			model_2.SetActive (false);
			break;
		case 2:
			model_3.SetActive (false);
			break;
		}
	}

	public void CalculateScore (bool direction)
	{
		if (direction == true)
			score++;
		else if (direction == false && score > 0)
			score--;
	}
		
    void Start() {
		score = 0;
		timer = 2;
        // Search for all Children from this ImageTarget with type VirtualButtonBehaviour
        VirtualButtonBehaviour[] vbs = GetComponentsInChildren<VirtualButtonBehaviour>();
        for (int i = 0; i < vbs.Length; ++i) {
            // Register with the virtual buttons TrackableBehaviour
            vbs[i].RegisterEventHandler(this);
        }

        // Find the models based on the names in the Hierarchy
		model_1 = transform.FindChild("samuzai").gameObject;
		model_2 = transform.FindChild("samuzai2").gameObject;
		model_3 = transform.FindChild ("samuzai3").gameObject;
        // We don't want to show Jin during the startup
		model_1.SetActive(false);
		model_2.SetActive(false);
		model_3.SetActive(false);

		SetNewModel ();
    }
 
    /// <summary>
    /// Called when the virtual button has just been pressed:
    /// </summary>
    public void OnButtonPressed(VirtualButtonAbstractBehaviour vb) {
		//Debug.Log(vb.VirtualButtonName);
		Debug.Log("Button pressed!");
        
		switch(vb.VirtualButtonName) {
		case "button1":
			if (model_num == 0 && timer > 0)
				CalculateScore (true);
			else
				CalculateScore (false);
			ResetModel ();
			SetNewModel ();
                    break;
		case "button2":
			if (model_num == 1 && timer > 0)
				CalculateScore (true);
			else
				CalculateScore (false);
			ResetModel ();
			SetNewModel ();
           break;
		case "button3":
			if (model_num == 2 && timer > 0)
				CalculateScore (true);
			else
				CalculateScore (false);
			ResetModel ();
			SetNewModel ();
			break;
         //   default:
         //       throw new UnityException("Button not supported: " + vb.VirtualButtonName);
         //           break;
        }
        
    }

    /// Called when the virtual button has just been released:
    public void OnButtonReleased(VirtualButtonAbstractBehaviour vb) { 
		Debug.Log("Button released!");
	}

	void Update()
	{
		if (timer > 0) {
			timer -= Time.deltaTime;
		} else if (timer < 0) {
			ResetModel ();
			SetNewModel ();
		}
			
	}
		
}