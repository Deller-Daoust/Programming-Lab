using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Combat : MonoBehaviour
{
    private float damage;

    public float hp = 5;

    [SerializeField] private Game_Controller game;

    [SerializeField] private GameObject projectilePrefab;

    public Text scoreText;

    public Text hpText;

    public int score;

    // Start is called before the first frame update
    void Start()
    {
        HealthPoints = 10;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(projectilePrefab);
        }

        hpText.text = $"HP: {HealthPoints}";

        if(HealthPoints <= 0)
        {
            game.state = Game_Controller.GameState.GameOver;
            Destroy(gameObject);
        }
    }

    public float HealthPoints
    {
        get {
            return hp;
        } set {
            hp = value;
        }
    }
}
