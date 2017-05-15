using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class PauseMenuButtonHandler : MonoBehaviour {

    public Button continueButton;
    public Button saveButton;
    public Button optionButton;
    public Button menuButton;
    public Animator controller;
    public AudioSource audioSource;
    public InputField inputField;
    public Canvas mainCanvas;
    public Canvas saveNameCanvas;
    public Button saveNameButton;
    public static bool canContinue = false;

    void Start()
    {
        Button buttonContinue = continueButton.GetComponent<Button>();
        Button buttonSave = saveButton.GetComponent<Button>();
        Button buttonOption = optionButton.GetComponent<Button>();
        Button buttonMenu = menuButton.GetComponent<Button>();
        Button saveName = saveNameButton.GetComponent<Button>();
        buttonContinue.onClick.AddListener(TaskOnClickContinue);
        buttonSave.onClick.AddListener(TaskOnClickSave);
        buttonOption.onClick.AddListener(TaskOnClickOption);
        buttonMenu.onClick.AddListener(TaskOnClickMenu);
        saveName.onClick.AddListener(TaskOnClickSaveWithName);
        saveName.onClick.AddListener(TaskOnClickSaveWithName);
        audioSource.volume = VolumeSource.Volume;

        saveNameCanvas.enabled = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            Application.LoadLevel("AR4good");
    }

    void TaskOnClickContinue()
    {
        Debug.Log("You have clicked the pcontinue button!");
        controller.SetTrigger("IsContinue");
    }

    void TaskOnClickSave()
    {
        Debug.Log("You have clicked the save button!");
        //controller.SetTrigger("IsSave");
        
        mainCanvas.enabled = false;
        saveNameCanvas.enabled = true;
       
    }

    void TaskOnClickSaveWithName()
    {
        StreamWriter sw;
        FileInfo f = new FileInfo("last.txt");
        if (!f.Exists) f.Create();


        mainCanvas.enabled = true;
        saveNameCanvas.enabled = false;

        sw = f.AppendText();
        sw.WriteLine(inputField.text + "/" + ScoreClass.Score + "/" + ScoreClass.Lifes);
        sw.Close();

        Debug.Log("You have clicked the save button with name!");
    }

    void TaskOnClickOption()
    {
        Debug.Log("You have clicked the option button!");
        controller.SetTrigger("IsOption");
    }

    void TaskOnClickMenu()
    {
        Debug.Log("You have clicked the menu button!");
        controller.SetTrigger("IsMenu");
    }
}
