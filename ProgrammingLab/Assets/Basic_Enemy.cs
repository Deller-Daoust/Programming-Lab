using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basic_Enemy : Enemy_Base
{
    Basic_Enemy_Stats stats = new Basic_Enemy_Stats();

    [SerializeField] private Player_Combat p_combat;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        p_combat = player.GetComponent<Player_Combat>();

        health = stats.health;
        damage = stats.damage;
    }

    void Update()
    {
        speed = stats.speed;

        stats.speed += 0.0001f;
        stats.SpeedCheck();

        base.Movement();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.name == "Player")
        {
            p_combat.hp -= damage;
        }
    }
}
