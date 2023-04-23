using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : Interactions
{
    //this bool is used to know if the player collected the key
    public GameObject particle;
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
        Debug.Log("Interacted with " + gameObject.name);
        Destroy(gameObject);
        Instantiate(particle, transform.position, Quaternion.identity);
    }
}
