using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartMenuManager : MonoBehaviour
{
    [Header("��w��H����")]
    public GameObject _buttons;
    [Header("�L���ؼ�")]
    public LoadScenes _loadScenes;

    private void Start()
    {
        ButtonStates(false);
        _loadScenes.LoadNewScene("�L���e��");
    }

    private void Update()
    {
        if(_loadScenes.Progress >= 100f) { ButtonStates(true); }
    }

    public void StartButton(float delay) 
    {
        Invoke("DelayStartGame", delay);
    }

    public void SettingButton()
    { 
        //Not using.
    }

    public void GalleryButton() 
    {
        Debug.Log("Gallery is not ready yet.");
    }

    public void QuitButton(float delay) 
    {
        Invoke("DelayQuitButton", delay);
    }

    public void DelayStartGame()
    {
        _loadScenes._targetScene._sceneName = "�}�Y";
        _loadScenes._asyncload.allowSceneActivation = true;
    }

    public void DelayQuitButton() 
    {
        Application.Quit();
    }

    private void ButtonStates(bool active) 
    {
        _buttons.SetActive(active);
    }
}
