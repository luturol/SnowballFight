 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    public float jumpForce;

    public KeyCode left;
    public KeyCode right;
    public KeyCode jump;
    public KeyCode throwBall;

    private Rigidbody2D rigidbody2D;

    //Controlar se o player está no chão ou não
    public Transform groundCheckPoint;
    public bool isGrounded;
    public float groundCheckRadius;
    public LayerMask whatIsGround; //Default layer = Tudo que está nela, ou seja, by default são os componentes criados no unity


    private Animator animator;

    public GameObject snowBall;
    public Transform throwPoint;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();

        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //Vai desenhar um circulo envolta do ponto e ver se ele está no chão ou não e retornar um bool
        isGrounded = Physics2D.OverlapCircle(groundCheckPoint.position, groundCheckRadius, whatIsGround);

        if(Input.GetKey(left))
        {
            rigidbody2D.velocity = new Vector2(-moveSpeed, rigidbody2D.velocity.y);
        }
        else if (Input.GetKey(right))
        {
            rigidbody2D.velocity = new Vector2(moveSpeed, rigidbody2D.velocity.y);
        }
        else
        {
            rigidbody2D.velocity = new Vector2(0, rigidbody2D.velocity.y);
        }

        //Pode pular somente se estiver no chão
        //Faz com que o player só consiga pular uma vez e não infinitos pulos
        if(Input.GetKeyDown(jump) && isGrounded)
        {
            rigidbody2D.velocity = new Vector2(rigidbody2D.velocity.x, jumpForce);
        }

        if (Input.GetKeyDown(throwBall))
        {
            GameObject ballClone = (GameObject) Instantiate(snowBall, throwPoint.position, throwPoint.rotation);
            ballClone.transform.localScale = transform.localScale; //Adjust scale from snowball

            animator.SetTrigger("Throw");
        }

        if(rigidbody2D.velocity.x < 0) //Moving to the left
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
        else if(rigidbody2D.velocity.x > 0) //Moving to the right
        {
            transform.localScale = new Vector3(1, 1, 1);
        }

        animator.SetFloat("Speed", Mathf.Abs(rigidbody2D.velocity.x));
        animator.SetBool("Grounded", isGrounded);
        
    }
}
