using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

// Purpose: Set where the player go
public class TargetSetter : MonoBehaviour
{
    private Camera _camera;
    [SerializeField] private SoPlayerData playerData;
    private void Awake()
    {
        _camera = Camera.main;
    }

    public void SetTarget(InputAction.CallbackContext context)
    {
        if (!context.started) return;
        var rayHit = Physics2D.GetRayIntersection(_camera.ScreenPointToRay(Mouse.current.position.ReadValue()));
        if(!rayHit.collider) return;
        playerData.SetTargetNode(rayHit.collider.transform.position);
    }
}
