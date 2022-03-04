/*
 * (Noah Trillizio)
 * (Assignment 5A)
 * (Detects if the player has won)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectVictory : MonoBehaviour
{

    private ScoreText displayVictory;

    // Start is called before the first frame update
    void Start()
    {
        displayVictory = GameObject.FindGameObjectWithTag("Gems Collected").GetComponent<ScoreText>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            displayVictory.win = true;
            Destroy(gameObject);
        }
    }
}
