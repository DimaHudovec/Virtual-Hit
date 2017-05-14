using UnityEngine;
using System.Collections.Generic;
using Vuforia;
using System;

public class VirtualButtonEventHandler : MonoBehaviour, IVirtualButtonEventHandler {

	public static int Score { get { return score; } set { VirtualButtonEventHandler.score = value; } }
	public static int Lifes { get { return lifes; } set { VirtualButtonEventHandler.lifes = value; } }
	public int ModelNum { get { return model_num; } }
    // Private fields to store the models
	private GameObject model_1;
	private GameObject model_2;
	private GameObject model_3;
	private int model_num;
	private static int score;
	private float timer; 
	public Pause p;
	public AudioClip clip;
	public AudioSource audio;
	private static int lifes;
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
		timer = 4;
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
		score = ScoreClass.Score;
		timer = 4;
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
		Lifes = 5;
    }
 
    /// <summary>
    /// Called when the virtual button has just been pressed:
    /// </summary>
    public void OnButtonPressed(VirtualButtonAbstractBehaviour vb) {
		//Debug.Log(vb.VirtualButtonName);
		Debug.Log("Button pressed!");
			switch(vb.VirtualButtonName) {
		case "button1":
			audio.PlayOneShot (clip);
			if (model_num == 0 && timer > 0)
				CalculateScore (true);
			else {
				CalculateScore (false);
				Lifes--;
			}
				ResetModel ();
				SetNewModel ();
	            break;
		case "button2":
			audio.PlayOneShot (clip);
			if (model_num == 1 && timer > 0)
				CalculateScore (true);
			else {
				CalculateScore (false);
				Lifes--;
			}
				ResetModel ();
				SetNewModel ();
	           break;
		case "button3":
			audio.PlayOneShot (clip);
			if (model_num == 2 && timer > 0)
				CalculateScore (true);
			else {
				CalculateScore (false);
				Lifes--;
			}
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
		if (timer > 0) 
		{
			timer -= Time.deltaTime;
		} 
		else if (timer < 0) 
		{
			ResetModel ();
			SetNewModel ();
		}

	}
}