using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : Interactions
{
    public GameObject particle;

    //function where we design the interaction with code
    protected override void Interact()
    {
        Debug.Log("Interacted with " + gameObject.name);
        Destroy(gameObject);
    }
}
