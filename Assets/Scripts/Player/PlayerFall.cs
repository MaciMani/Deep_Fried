using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFall : MonoBehaviour
{
    public GameObject player;
    private PlayerHealth pHealth;

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position;
        if (player.transform.position.y < -20)
        {
            pHealth = player.GetComponent<PlayerHealth>();
            pHealth.health = 0;
        }
    }
}
