/*
 * (Noah Trillizio)
 * (Assignment 5A)
 * (Keeps track of the players score)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    public Text textbox;

    public int score = 0;

    public bool win = false;
    public GameObject winText;

    // Start is called before the first frame update
    void Start()
    {
        textbox = GetComponent<Text>();
        textbox.text = "Score: 0";
    }

    // Update is called once per frame
    void Update()
    {
        textbox.text = "Score: " + score;

        if (win == true)
        {
            winText.SetActive(true);
        }

    }
}
