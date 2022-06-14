using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class HeroInputReader : MonoBehaviour
{
    [SerializeField]private Hero _hero;
    float directionX, directionY;

    public void OnHorizontalMovement(InputAction.CallbackContext context)
    {
        directionX = context.ReadValue<float>();
        _hero.SetDirection(directionX, directionY);
    }

    public void OnVerticalMovement(InputAction.CallbackContext context)
    {
        directionY = context.ReadValue<float>();
        _hero.SetDirection(directionX, directionY);
    }

    public void OnSaySomething(InputAction.CallbackContext context)
    {
        _hero.SaySomething("Something");
    }
}