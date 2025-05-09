using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] playerPosition playerPosition;
    private float moveSpeed = 5f;
    private Rigidbody2D rb;
    private Vector2 moveInput;
    [SerializeField] private Animator animator;

    // Start is called before the first frame update
    private void Awake()
    {
        this.transform.position = playerPosition.position;
    }

    void Start()
    {
        
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = (moveInput * moveSpeed);
        if (rb.velocity != Vector2.zero)
        {
            //Move
        }

    }
    public void Move(InputAction.CallbackContext context)
    {
        Debug.Log("moving");
        animator.SetBool("isWalking", true);
        moveInput = context.ReadValue<Vector2>();
        if (context.canceled)
        {
            animator.SetBool("isWalking", false);
            animator.SetFloat("LastInputX", moveInput.x);
            animator.SetFloat("LastInputY", moveInput.y);
            return;
        }


        animator.SetFloat("InputX", moveInput.x);
        animator.SetFloat("InputY", moveInput.y);
        Debug.Log(moveInput.x);
        Debug.Log(moveInput.y);
    }
}
