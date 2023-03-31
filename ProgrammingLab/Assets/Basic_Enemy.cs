using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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

        if(health <= 0)
        {
            p_combat.score += 1;
            p_combat.scoreText.text = $"Score: {player.GetComponent<Player_Combat>().score}";
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.name == "Player")
        {
            p_combat.HealthPoints = p_combat.hp - damage;
        }
    }
}
