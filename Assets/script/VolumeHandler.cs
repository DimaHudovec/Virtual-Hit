using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class VolumeHandler : MonoBehaviour {

    public Slider slider;
    public Button saveButton;
    public Button backButton;
    public AudioSource audioSource;

    // Use this for initialization
    void Start()
    {
        Button buttonSave = saveButton.GetComponent<Button>();
        Button buttonBack = backButton.GetComponent<Button>();
        buttonSave.onClick.AddListener(TaskOnClickSave);
        buttonBack.onClick.AddListener(TaskOnClickBack);
        audioSource.volume = VolumeSource.Volume;
        slider.value = VolumeSource.Volume;
    }

    void TaskOnClickSave()
    {
        Debug.Log("You have clicked the save button!");
        VolumeSource.Volume = slider.value;
        audioSource.volume = VolumeSource.Volume;
    }

    void TaskOnClickBack()
    {
        SceneManager.LoadScene(ScenesSource.Name);
        Debug.Log("You have clicked the back button!");
    }
}
