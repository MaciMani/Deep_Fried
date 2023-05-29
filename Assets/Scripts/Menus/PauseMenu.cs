using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public static bool isPaused = false;

    private PlayerLook _playerLook;

    // Start is called before the first frame update
    void Start()
    {
        _playerLook = GetComponent<PlayerLook>();

        pauseMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape)) 
        {
            if (isPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }

    public void PauseGame() 
    {
        pauseMenu?.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;

        _playerLook.mouseForInputLook = true;

        Cursor.visible = true;
    }

    public void ResumeGame()
    {
        pauseMenu?.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;

        //_playerLook.mouseForInputLook = false;

        Cursor.visible = false;
    }

    public void GoToMainMenu() 
    {

        //_playerLook.mouseForInputLook = false;

        Cursor.visible = true;


        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }

    public void QuitGame() 
    {
        Application.Quit();
    }
}
