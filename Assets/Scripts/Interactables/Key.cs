using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : Interactions
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //function where we design the interation with code
    protected override void Interact()
    {
        Debug.Log("Interacted with" + gameObject.name);
    }
}
