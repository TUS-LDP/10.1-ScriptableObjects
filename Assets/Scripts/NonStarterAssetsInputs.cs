using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class NonStarterAssetsInputs : MonoBehaviour
{
    public bool testing;
    public bool teleport;

    public void OnTesting(InputValue value)
    {
        testing = value.isPressed;
    }

    public void OnTeleport(InputValue value)
    {
        Debug.Log("OnTeleport");
        teleport = value.isPressed;
    }
}
