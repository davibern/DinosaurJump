using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dinosaur2 : MonoBehaviour
{
    // Variables
    public GameManager gameManager;
    public GameObject stand;
    public GameObject crouch;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Levantarse
        if (Input.GetKeyUp("down"))
        {
            stand.SetActive(true);
            crouch.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("obstacle"))
        {
            gameManager.GameOver();
        }
    }
}
