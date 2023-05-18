using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathMenu : MonoBehaviour
{
    public GameObject deathMenu;
    private PlayerHealth pHealth;
    public static bool isDead = false;

    void Start()
    {
        deathMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        pHealth = GetComponent<PlayerHealth>();
        if (pHealth.health <= 0)
        {
            deathMenu?.SetActive(true);
            Time.timeScale = 0f;
            pHealth.health = 100f;          
        }
    }

    public void GoToMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }
}
