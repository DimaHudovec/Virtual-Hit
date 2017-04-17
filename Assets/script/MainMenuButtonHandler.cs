using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MainMenuButtonHandler : MonoBehaviour {

    public Button playButton;
    public Button optionsButton;
    public Button exitButton;

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
        Application.LoadLevel("AR4good");
    }

    void TaskOnClickExit()
    {
        Debug.Log("You have clicked the exit button!");
        Application.Quit();
    }

    void TaskOnClickOption()
    {
        Debug.Log("You have clicked the option button!");
    }
}
