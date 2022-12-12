using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    private PlayerInput playerInput;
    //private PlayerInput.OnFootActions onFoot;

    // Start is called before the first frame update
    void Start()
    {
        playerInput = new PlayerInput();
        ///onFoot = playerInput.OnFoot;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // On Enable
    private void OnEnable()
    {
        //onFoot.Enable();
    }

    // On Disable
    private void OnDisable()
    {
        //onFoot.Disable();
    }
}
