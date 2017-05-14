using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Initializer : MonoBehaviour 
{
	public Camera LeftCamera;
	public Camera RightCamera;
	public GameObject canvas;
	public VirtualButtonEventHandler handler;
	public bool paused;

	private Text leftScore;
	private Text rightScore;
	private Text leftLifes;
	private Text rightLifes;
	string heart = "❤";

	private void Start()
	{
		paused = false;
		var leftCanvas = GameObject.Instantiate (canvas).GetComponent<Canvas> ();
		leftCanvas.transform.parent = transform;
		leftCanvas.renderMode = RenderMode.ScreenSpaceCamera;
		leftCanvas.worldCamera = LeftCamera;
		leftScore = leftCanvas.GetComponentsInChildren<Text> ()[0];
		leftLifes = leftCanvas.GetComponentsInChildren<Text> ()[1];
		var rightCanvas = GameObject.Instantiate (canvas).GetComponent<Canvas> ();
		rightCanvas.transform.parent = transform;
		rightCanvas.renderMode = RenderMode.ScreenSpaceCamera;
		rightCanvas.worldCamera = RightCamera;
		rightScore = rightCanvas.GetComponentsInChildren<Text> ()[0];
		rightLifes = rightCanvas.GetComponentsInChildren<Text> ()[1];
	}

	private void Update()
	{
		leftLifes.text = "                                          ";
		leftScore.text = "Score: " + VirtualButtonEventHandler.Score + "                  Lifes:";
		for (int i = 0; i < VirtualButtonEventHandler.Lifes; i++) {
			leftLifes.text = leftLifes.text + heart;
		}
		rightScore.text = leftScore.text;
		rightLifes.text = leftLifes.text;
	}
}
