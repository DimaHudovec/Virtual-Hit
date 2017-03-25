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

	private void Start()
	{
		paused = false;
		var leftCanvas = GameObject.Instantiate (canvas).GetComponent<Canvas> ();
		leftCanvas.transform.parent = transform;
		leftCanvas.renderMode = RenderMode.ScreenSpaceCamera;
		leftCanvas.worldCamera = LeftCamera;
		leftScore = leftCanvas.GetComponentInChildren<Text> ();
		var rightCanvas = GameObject.Instantiate (canvas).GetComponent<Canvas> ();
		rightCanvas.transform.parent = transform;
		rightCanvas.renderMode = RenderMode.ScreenSpaceCamera;
		rightCanvas.worldCamera = RightCamera;
		rightScore = rightCanvas.GetComponentInChildren<Text> ();
	}

	private void Update()
	{
		leftScore.text = "Score: " + handler.Score;
		rightScore.text = leftScore.text;
	}
}
