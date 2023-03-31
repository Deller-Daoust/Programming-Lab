using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Projectile_Behaviour : MonoBehaviour
{
    private GameObject player;
    private Vector3 mousePos;

    void Awake()
    {
        player = GameObject.Find("Player");
    }

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(player.transform.position.x, player.transform.position.y, 0);
        mousePos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 3));

        StartCoroutine(Despawn());
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, mousePos * 2, Time.deltaTime);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.name != "Player" && col.gameObject.tag != "Enemy")
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Enemy")
        {
            col.gameObject.GetComponent<Basic_Enemy>().health -= 1;
            Destroy(gameObject);
        }
    }

    IEnumerator Despawn()
    {
        yield return new WaitForSeconds(2.5f);

        Destroy(gameObject);
    }
}
