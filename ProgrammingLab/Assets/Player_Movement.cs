using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    private Vector3 movement;

    private Rigidbody2D body;

    private float moveSpeed = 5f;

    [SerializeField] private GameObject enemyPrefab;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();

        StartCoroutine(EnemySpawning());
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        body.MovePosition(body.transform.position + movement * moveSpeed * Time.fixedDeltaTime);
    }

    IEnumerator EnemySpawning()
    {
        while(true)
        {
            Instantiate(enemyPrefab);
            yield return new WaitForSeconds(1);
        }
    }
}
