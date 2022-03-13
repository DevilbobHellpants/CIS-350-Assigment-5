using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DisplayText : MonoBehaviour
{
    public Text displayVictory;

    public bool called = false;

    private float timer;
    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < 360)
        {
            timer++;
        }
        else if (timer >= 360)
        {
            if (called == false)
            {
                displayVictory.text = "";
                called = true;
            }
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("MyFirstPersonPlayer");
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("display");
            Destroy(gameObject);
            displayVictory.text = "Congratulations, you did it! You Win! Press R to restart.";
        }
    }
}
