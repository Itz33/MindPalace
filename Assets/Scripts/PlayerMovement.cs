using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private float moveSpeed = 5f;
    private Rigidbody2D rb;
    private Vector2 moveInput;
    [SerializeField] private Animator animator;
    //[SerializeField] BoxCollider2D boxCollider;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //Debug.Log("The vertical size of the box is: " + boxCollider.size.y);
        //Debug.Log("The horizontal size of the box is: " + boxCollider.size.x);
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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        /*ContactPoint2D[] contacts = new ContactPoint2D[10];
        int numContacts = collision.GetContacts(contacts) ;

        for (int i = 0; i < numContacts; i++)
        {
            ContactPoint2D contact = contacts[i];

            // Access contact point properties
            Vector2 contactPoint = contact.point;
            Vector2 contactNormal = contact.normal;

            if (contactNormal[0] < 0) {
                if (contactPoint[0] < boxCollider.size.y / 2)
                {

                }
            }
            

            // Do something with the contact information
            Debug.Log("Contact point: " + contactPoint + ", Normal: " + contactNormal);
        }*/


        /*var direction = transform.InverseTransformPoint(collision.transform.position);

        if (direction.x > 0)
        {
            //rb.AddForce(new Vector2 (0f,100f));
            rb.MovePosition(new Vector2(transform.position.x + 0, transform.position.y + 0.05f));
            Debug.Log("Collision on the left side!");
        }
        else
        {
            Debug.Log("Collision on the right side!");
            rb.MovePosition(new Vector2(transform.position.x + 0, transform.position.y - 0.05f));

        }*/

        /*ContactPoint2D contact = collision.contacts[0];

        if (Mathf.Abs(contact.normal.y) > Mathf.Abs(contact.normal.x))
        { // Primarily up or down
            if (contact.normal.y > 0)
            {
                // Top collision
                Debug.Log("Top collision");
            }
            else
            {
                // Bottom collision
                Debug.Log("Bottom collision");
            }
        }
        else
        { // Primarily left or right
            var direction = transform.InverseTransformPoint(collision.transform.position);

            if (direction.x > 0)
            {
                //rb.AddForce(new Vector2 (0f,100f));
                rb.MovePosition(new Vector2(transform.position.x + 0, transform.position.y + 0.05f));
                Debug.Log("Collision on the left side!");
            }
            else
            {
                Debug.Log("Collision on the right side!");
                rb.MovePosition(new Vector2(transform.position.x + 0, transform.position.y - 0.05f));

            }
            if (contact.normal.x > 0)
            {
                // Right collision
                Debug.Log("Right collision");
            }
            else
            {
                // Left collision
                Debug.Log("Left collision");
            }
        }*/
        // Access the contact point
        /*ContactPoint2D contact = collision.contacts[0]; // Assuming single contact point for simplicity
        Vector2 contactPoint = contact.point;

        // Get the bounds of the collider
        Bounds bounds = GetComponent<Collider2D>().bounds;

        // Determine the side of the collision
        if (IsSideCollision(contactPoint, bounds, "left"))
        {
            Debug.Log("Collided on the left side!");
        }
        else if (IsSideCollision(contactPoint, bounds, "right"))
        {
            Debug.Log("Collided on the right side!");
        }
        else if (IsSideCollision(contactPoint, bounds, "top"))
        {
            Debug.Log("Collided on the top side!");
        }
        else if (IsSideCollision(contactPoint, bounds, "bottom"))
        {
            Debug.Log("Collided on the bottom side!");
        }
    }

    // Helper function to determine if the collision is on a specific side
    private bool IsSideCollision(Vector2 contactPoint, Bounds bounds, string side)
    {
        float tolerance = 0.01f; // Adjust for small discrepancies

        if (side == "left")
        {
            return contactPoint.x < bounds.min.x + tolerance;
        }
        else if (side == "right")
        {
            return contactPoint.x > bounds.max.x - tolerance;
        }
        else if (side == "top")
        {
            return contactPoint.y > bounds.max.y - tolerance;
        }
        else if (side == "bottom")
        {
            return contactPoint.y < bounds.min.y + tolerance;
        }
        return false;*/
    
}
}
