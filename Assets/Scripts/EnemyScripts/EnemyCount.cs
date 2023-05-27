using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCount : MonoBehaviour
{
    public int numberOfEnemies;
    // Start is called before the first frame update
    void Start()
    {
        numberOfEnemies = 1;
    }

    // Update is called once per frame
    void Update()
    {
        numberOfEnemies = GameObject.FindGameObjectsWithTag("Enemy").Length;
        if (numberOfEnemies == 0)
        {

        }
        Debug.Log(numberOfEnemies);
    }
}
