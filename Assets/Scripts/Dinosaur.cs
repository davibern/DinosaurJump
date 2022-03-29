using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dinosaur : MonoBehaviour
{
    // Variables
    public GameObject stand;
    public GameObject crouch;
    private Rigidbody2D rb;
    private bool isJumping;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        isJumping = false;
    }

    // Update is called once per frame
    void Update()
    {
        // Salto
        if (Input.GetKey(KeyCode.Space) && isJumping == false)
        {
            rb.velocity = new Vector3(0, 20, 0);
            isJumping = true;
        }

        // Agacharse
        if (Input.GetKey("down") && isJumping == false)
        {
            crouch.SetActive(true);
            stand.SetActive(false);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Si ya está saltando se evita saltar infinitamente
        if (isJumping == true)
        {
            isJumping = false;
        }
    }
}
