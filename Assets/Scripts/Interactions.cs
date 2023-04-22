using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Interactions : MonoBehaviour
{
    //add or remove an interactionEvent component to this gameObject 
    public bool useEvents;
    [SerializeField]
    //message displayed when looking at interactable
    public string promptMessage;

    //function called by player
    public void BaseInteract()
    {
        if (useEvents)
            GetComponent<InteractionEvent>().onInteract.Invoke();
        Interact();
    }

    protected virtual void Interact()
    {
        //template function for our subclasses
    }
}
