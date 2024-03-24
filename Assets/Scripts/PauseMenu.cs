using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool Paused = false;
    public static bool showHint = false;

    public GameObject PauseMenuCanvas;
    public GameObject TipsMenuCanvas;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Paused)
                Play();
            else
                Stop();
        }
    }

    void Stop()
    {
        PauseMenuCanvas.SetActive(true);
        Time.timeScale = 0f;
        Paused = true;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void Play()
    {
        if (showHint == false)
        {
            PauseMenuCanvas.SetActive(false);
            Time.timeScale = 1f;
            Paused = false;
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
        else
        {
            Back();
        }
    }

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }


    public void Hints()
    {
        TipsMenuCanvas.SetActive(true);
        showHint = true;
    }

    public void Back()
    {
        TipsMenuCanvas.SetActive(false);
        showHint = false;
    }
}
