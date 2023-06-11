using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class STransitionMenu : MonoBehaviour
{
    public GameObject sTMenu;
    private EnemyCount nEnemies;
    public string stage;

    void Start()
    {
        sTMenu.SetActive(false);
    }

    void Update()
    {
        nEnemies = GetComponent<EnemyCount>();
        if (nEnemies.numberOfEnemies == 0)
        {
            sTMenu?.SetActive(true);

            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }

    public void GoToNextStage()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Debug.Log("It works!!!!!!");
    }
}
