using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Set the character movement speed

public class CharController : MonoBehaviour
{
    //[SerializedField] private Transform groundCheckTransform = null;
    private bool jumpKeyWasPressed;
    public float movementSpeed = 40f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float hMovement = Input.GetAxis("Horizontal") * movementSpeed / 2;
        float vMovement = Input.GetAxis("Vertical") * movementSpeed;

        transform.Translate(new Vector3(hMovement, 0, vMovement) * Time.deltaTime);

        // Check if space key is pressed down
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Debug.Log("Space Key Was Pressed Down");
            jumpKeyWasPressed = true;
        }
    }

 
    private void FixedUpdate()
    {

        if (jumpKeyWasPressed)
        {
            // Debug.Log("Space Key Was Pressed Down");
            GetComponent<Rigidbody>().AddForce(Vector3.up * 5, ForceMode.VelocityChange);
            jumpKeyWasPressed = false;
        }
    }

    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.gameObject.layer == 6)
    //    {
    //        Destroy(other.gameObject);
    //        ScoreScript.scoreValue += 1;
    //    }
    //}

}
