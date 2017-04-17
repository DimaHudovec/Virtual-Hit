using UnityEngine;
using UnityEngine.UI;

public class PauseMenuButtonHandler : MonoBehaviour {

    public Button continueButton;
    public Button saveButton;
    public Button optionButton;
    public Button menuButton;

    void Start()
    {
        Button buttonContinue = continueButton.GetComponent<Button>();
        Button buttonSave = saveButton.GetComponent<Button>();
        Button buttonOption = optionButton.GetComponent<Button>();
        Button buttonMenu = menuButton.GetComponent<Button>();
        buttonContinue.onClick.AddListener(TaskOnClickContinue);
        buttonSave.onClick.AddListener(TaskOnClickSave);
        buttonOption.onClick.AddListener(TaskOnClickOption);
        buttonMenu.onClick.AddListener(TaskOnClickMenu);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            Application.LoadLevel("AR4good");
    }

    void TaskOnClickContinue()
    {
        Debug.Log("You have clicked the pcontinue button!");
        Application.LoadLevel("AR4good");
    }

    void TaskOnClickSave()
    {
        Debug.Log("You have clicked the save button!");
    }

    void TaskOnClickOption()
    {
        Debug.Log("You have clicked the option button!");
    }

    void TaskOnClickMenu()
    {
        Debug.Log("You have clicked the menu button!");
        Application.LoadLevel("Menu");
    }
}
