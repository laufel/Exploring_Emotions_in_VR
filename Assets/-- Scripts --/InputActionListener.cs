using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class InputActionListener : MonoBehaviour
{

    public InputActionProperty InputActionProperty;

    public UnityEvent ActionPerformed;

    private void OnEnable()
    {
        InputActionProperty.action.performed += OnActionPerformed;
    }


    private void OnActionPerformed(InputAction.CallbackContext context)
    {
        ActionPerformed?.Invoke();
    }
}
