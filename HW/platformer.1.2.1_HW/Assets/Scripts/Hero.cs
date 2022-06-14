using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{
    [SerializeField] private float _speed;
    private float _directionX;
    private float _directionY;

    public void SetDirection(float directionX = 0, float directionY = 0)
    {
        _directionX = directionX;
        _directionY = directionY;
    }

    private void Update()
    {
        if (_directionX != 0)
        {
            var delta = _directionX * _speed * Time.deltaTime;
            var newXPosition = transform.position.x + delta;
            transform.position = new Vector3(newXPosition, transform.position.y, transform.position.z);
        }
        if (_directionY != 0)
        {
            var delta = _directionY * _speed * Time.deltaTime;
            var newYPosition = transform.position.y + delta;
            transform.position = new Vector3(transform.position.x, newYPosition, transform.position.z);
        }
    }

    public void SaySomething(string cueText)
    {
        Debug.Log($"Вы сказали: {cueText}");
    }
}
