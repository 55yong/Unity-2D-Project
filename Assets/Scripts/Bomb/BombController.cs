using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombController : MonoBehaviour
{
    GameObject hp;
    GameObject sc;

    private void Start()
    {
        hp = GameObject.Find("HP");
        sc = GameObject.Find("Score");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            hp.GetComponent<HPController>().HpControl();
        }
        
        //if(collision.gameObject.tag == "Ground")
        //{
        //    sc.GetComponent<ScoreController>().AddScore();
        //}
        Destroy(gameObject);
    }
}
