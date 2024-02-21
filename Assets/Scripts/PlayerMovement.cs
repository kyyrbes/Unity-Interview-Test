using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 0f;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        var rigidBody = GameObject.Find("Player").GetComponent<Rigidbody>();

        //Get our user input from the keyboard
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");


        //Calculate movement vector based on input
        var movement = new Vector3(moveHorizontal, 0f, moveVertical);

        //Apply the vector to the player
        rigidBody.AddForce(movement*speed);

    }
}
