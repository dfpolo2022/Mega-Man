using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed;
    public float jumpForce;
    public LayerMask layerFloor;
    
    private Rigidbody2D rigidbody;
    private bool right = true;
    private BoxCollider2D boxCollider;
    private Animator animator;
    private Vector3 respawnPoint;

    // Funcion start
    private void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        boxCollider = GetComponent<BoxCollider2D>();
        animator = GetComponent<Animator>();
        respawnPoint = transform.position;
    }

    // Funcion update
    void Update()
    {
        ProcessUpdate();
        checkJump();
        checkAir();
    }

    // Funcion para actualizar el movimiento del jugador
    void ProcessUpdate()
    {
        float movementInput = Input.GetAxis("Horizontal");


        // Verificar si el jugador esta corriendo
        if(movementInput != 0f)
        {
            animator.SetBool("isRunning", true);
        } else
        {
            animator.SetBool("isRunning", false);
        }

        rigidbody.velocity = new Vector2(movementInput * speed, rigidbody.velocity.y);
        checkDirection(movementInput);
    }


    // Funcion para cambiar la direccion en la que mira el personaje al moverse
    void checkDirection(float movementInput)
    {
        if ((right == true && movementInput < 0) || (right == false && movementInput > 0))
        {
            right = !right;
            transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);
        }
    }


    // Funcion para que el jugador salte
    void checkJump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && checkGround())
        {
            rigidbody.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }

    }


    // Funcion para verificar si esta en el aire
    void checkAir()
    {
        if (checkGround())
        {
            animator.SetBool("isJumping", false);
        } else
        {
            animator.SetBool("isJumping", true);
        }
    }

    // Funcion para verificar contacto con el suelo
    bool checkGround()
    {
        RaycastHit2D raycastHit  = Physics2D.BoxCast(boxCollider.bounds.center, new Vector2(boxCollider.bounds.size.x, boxCollider.bounds.size.y), 0f, Vector2.down, 0.2f, layerFloor);
        return raycastHit.collider != null;
    }

    // Funcion para respawnear personaje al colisionar con objetos insta-kill
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "instakill")
        {
            transform.position = respawnPoint;
        }
        else if (collision.tag == "checkpoint")
        {
            respawnPoint = transform.position;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "instakill")
        {
            transform.position = respawnPoint;
        }

    }
}
