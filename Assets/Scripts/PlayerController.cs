﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public void OnMove(InputValue movementValue)
    {
        Debug.Log(movementValue.Get<Vector2>());
    }
}