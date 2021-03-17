using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharController : MonoBehaviour
{
    private bool jumpKeyWasPressed;
    public float movementSpeed = 40f;
    private Rigidbody rigidbodyComponent;
    private bool isGrounded;

    public Rigidbody rigidBody;

    // Start is called before the first frame update
    void Start()
    {
        rigidbodyComponent = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //rigidBody.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, -Camera.main.transform.position.z));

        float hMovement = Input.GetAxis("Horizontal") * movementSpeed / 2;
        float vMovement = Input.GetAxis("Vertical") * movementSpeed;

        transform.Translate(new Vector3(hMovement, 0, vMovement) * Time.deltaTime);
        transform.Rotate(new Vector3(0, Input.GetAxis("Mouse X") * 100, 0) * Time.deltaTime);

        // Check if space key is pressed down
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Debug.Log("Space Key Was Pressed Down");
            jumpKeyWasPressed = true;
        }

    }

 
    private void FixedUpdate()
    {
        if (!isGrounded)
        {
            return;
        }

        if (jumpKeyWasPressed)
        {
            // Debug.Log("Space Key Was Pressed Down");
            rigidbodyComponent.AddForce(Vector3.up * 10, ForceMode.VelocityChange);
            jumpKeyWasPressed = false;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 6)
        {
            //Debug.Log("Collision Detected");
            Destroy(other.gameObject);
            ScoreScript.scoreValue += 2;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        isGrounded = true;
    }
    private void OnCollisionExit(Collision collision)
    {
        isGrounded = false;
    }

}
