using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : Interactions
{
    private PlayerHealth pHealth;
    public GameObject player;
    //function where we design the interaction with code
    protected override void Interact()
    {
        pHealth = player.GetComponent<PlayerHealth>();
        if (pHealth.health < 100) Destroy(gameObject);
    }
}
