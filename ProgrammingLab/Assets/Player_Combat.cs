using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Combat : MonoBehaviour
{
    private float damage;

    public float hp = 6;

    [SerializeField] private Game_Controller game;

    [SerializeField] private GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(projectilePrefab);
        }

        if(hp <= 0)
        {
            game.state = Game_Controller.GameState.GameOver;
        }

        Debug.Log(hp);
    }
}
