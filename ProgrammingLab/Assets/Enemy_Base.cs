using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Base : MonoBehaviour
{
    public float health;
    public float damage;
    public float speed;

    public virtual void Stats()
    {
        health = 1;
        damage = 1;
        speed = 1;
    }
}
