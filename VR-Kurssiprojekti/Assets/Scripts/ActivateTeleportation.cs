using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ActivateTeleportation : MonoBehaviour
{
    public GameObject rightTeleport;
    public InputActionProperty rightActivate;

    public InputActionProperty rightExit;

    // Update is called once per frame
    void Update()
    {
        rightTeleport.SetActive(rightExit.action.ReadValue<float>() == 0 && rightActivate.action.ReadValue<float>() > 0.1f);
    }
}
