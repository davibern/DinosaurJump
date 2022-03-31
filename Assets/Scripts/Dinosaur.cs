using UnityEngine;

public class Dinosaur : MonoBehaviour
{
    // Variables
    public GameManager gameManager;
    public GameObject stand;
    public GameObject crouch;
    private Rigidbody2D rb;
    private bool isJumping;
    private AudioSource jumpSound;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        isJumping = false;
        jumpSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        // Salto
        jumpButton();

        // Agacharse
        crouchButton();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Si ya está saltando se evita saltar infinitamente
        if (isJumping == true)
        {
            isJumping = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("obstacle"))
        {
            gameManager.GameOver();
        }
    }

    public void jumpButton()
    {
        if (Input.GetKey(KeyCode.Space) && isJumping == false)
        {
            rb.velocity = Vector2.up * 20;
            isJumping = true;
            jumpSound.Play();
            Debug.Log("Salto");
        }
    }

    public void crouchButton()
    {
        if (Input.GetKey("down") && isJumping == false)
        {
            crouch.SetActive(true);
            stand.SetActive(false);
        }
    }
}
