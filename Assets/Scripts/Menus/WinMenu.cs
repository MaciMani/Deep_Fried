using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinMenu : MonoBehaviour
{
    public GameObject WMenu;
    private EnemyCount nEnemies;

    void Start()
    {
        WMenu.SetActive(false);
        Time.timeScale = 1f;
    }

    void Update()
    {
        nEnemies = GetComponent<EnemyCount>();
        if (nEnemies.numberOfEnemies == 0)
        {
            WMenu?.SetActive(true);

            Time.timeScale = 1f;

            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }

    public void PlayAgain()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }
}
