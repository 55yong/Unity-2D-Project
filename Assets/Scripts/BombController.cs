using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombController : MonoBehaviour
{
    GameObject hp;

    private void Start()
    {
        hp = GameObject.Find("HP");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            hp.GetComponent<HPController>().HpControl();
        }
        Destroy(gameObject);
    }
}
