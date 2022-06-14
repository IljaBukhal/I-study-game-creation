using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroInputReader : MonoBehaviour
{
    [SerializeField]private Hero _hero;

    private void Update()
    {
        var horizontal = Input.GetAxis("Horizontal");
        _hero.SetDirection(horizontal);

        if (Input.GetButtonUp("Fire1"))
        {
            _hero.SaySomething("Огонь!");
        }
        //if (Input.GetKey(KeyCode.A))
        //{
        //    _hero.SetDirection(-1);
        //}
        //else if (Input.GetKey(KeyCode.D))
        //{
        //    _hero.SetDirection(1);
        //}
        //else
        //{
        //    _hero.SetDirection(0);
        //}
    }
}