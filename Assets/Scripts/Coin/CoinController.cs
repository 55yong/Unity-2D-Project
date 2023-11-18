using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    GameObject sc;

    private void Start()
    {
        sc = GameObject.Find("Score");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            sc.GetComponent<ScoreController>().AddScore();
        }
        Destroy(gameObject);
    }
}
