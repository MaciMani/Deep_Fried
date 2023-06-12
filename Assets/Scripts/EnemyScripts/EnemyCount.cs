using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCount : MonoBehaviour
{
    [SerializeField] private AudioSource deathSound;
    public int numberOfEnemies;
    int currentNumberOfEnemies;
    // Start is called before the first frame update
    void Start()
    {
        numberOfEnemies = 1;
    }

    // Update is called once per frame
    void Update()
    {
        numberOfEnemies = GameObject.FindGameObjectsWithTag("Enemy").Length;
        if (numberOfEnemies != currentNumberOfEnemies)
        {
            deathSound.Play();
        }
        currentNumberOfEnemies = numberOfEnemies;
        Debug.Log(numberOfEnemies);
    }
}
