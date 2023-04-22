using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class InputManager : MonoBehaviour
{
    private PlayerInput playerInput;
    public PlayerInput.WalkinActions walkin;

    private PlayerMov movement;
    private PlayerLook look;
    // Start is called before the first frame update
    void Awake()
    {
        playerInput = new PlayerInput();
        walkin = playerInput.Walkin;
        
        movement = GetComponent<PlayerMov>();
        look = GetComponent<PlayerLook>();

        walkin.Jump.performed += ctx => movement.Jump();

        walkin.Crouch.performed += ctx => movement.Crouch();
        walkin.Sprint.performed += ctx => movement.Sprint();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //tell the playermov to move using value from our movement action
        movement.ProcessMove(walkin.Movement.ReadValue<Vector2>());
    }

    private void LateUpdate()
    {
        look.ProcessLook(walkin.Look.ReadValue<Vector2>());
    }

    private void OnEnable()
    {
        walkin.Enable();
    }
    private void OnDisable() 
    {
        walkin.Disable();
    }
}
