using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MainMenuButtonHandler : MonoBehaviour {

    public Button playButton;
    public Button optionsButton;
    public Button exitButton;

    public Animator controller;

    void Start()
    {
        Button buttonPlay = playButton.GetComponent<Button>();
        Button buttonOption = optionsButton.GetComponent<Button>();
        Button buttonExit = exitButton.GetComponent<Button>();
        buttonPlay.onClick.AddListener(TaskOnClickPlay);
        buttonOption.onClick.AddListener(TaskOnClickOption);
        buttonExit.onClick.AddListener(TaskOnClickExit);
    }

    void TaskOnClickPlay()
    {
        Debug.Log("You have clicked the play button!");
        ScoreClass.Score = 0;
        controller.SetTrigger("IsPlay");
    }

    void TaskOnClickExit()
    {
        Debug.Log("You have clicked the exit button!");
        controller.SetTrigger("IsExit");
        //Application.Quit();
    }

    void TaskOnClickOption()
    {
        Debug.Log("You have clicked the option button!");
        controller.SetTrigger("IsOption");
    }
}
