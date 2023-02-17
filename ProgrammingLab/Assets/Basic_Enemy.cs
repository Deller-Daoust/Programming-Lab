using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basic_Enemy : Enemy_Base
{
    // Start is called before the first frame update
    void Start()
    {
        health = 1;
        damage = 1;
        speed = 0.5f;

        player = GameObject.Find("Player");
    }

    void Update()
    {
        base.Movement();
    }
}
