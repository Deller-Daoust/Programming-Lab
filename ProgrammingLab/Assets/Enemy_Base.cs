using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Base : MonoBehaviour
{
    public float health;
    public float damage;
    public float speed;
    public GameObject player;

    public virtual void Movement()
    {
        gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, player.transform.position, Time.deltaTime * speed);
    }
}
