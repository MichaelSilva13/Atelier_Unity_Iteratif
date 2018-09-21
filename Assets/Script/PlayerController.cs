using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	[SerializeField]
	private float speed;

	private float x, z;
	
	[SerializeField]
	private float variation, jumpForce, gravity;

	[SerializeField]
	private bool isGrounded = true;

	private Rigidbody rb;

    private Vector3 facingVect = new Vector3(1,1,1);


	// Use this for initialization of variables
	void Start ()
	{
		rb = GetComponent<Rigidbody>();
	}

	//TODO this session
	/*private void OnCollisionEnter(Collision collision)
	{
		GameObject other = collision.gameObject;
		//Resets the ability to jump
		if (other.CompareTag("Ground"))
		{
			isGrounded = true;
		}
		
	}*/

	private void OnCollisionExit(Collision collision)
	{
		
		
	}

	private void Update()
	{
		
	}

	// Update is called once per frame
	//We use fix update for the movement as it is better to use this instead of update for the physics
	void FixedUpdate ()
	{

		//sets the gravity to give the world a less floaty feel
		Physics.gravity = new Vector3(0, -gravity, 0);

		//Start of the jump, when the player presses the jump btn
		if (Input.GetButtonDown("Jump") && isGrounded)
		{
			// Instantly push the avatar upward.
			rb.AddForce(Vector3.up * jumpForce, ForceMode.VelocityChange);
			isGrounded = false;
		}
		//if the player is still in the air 
		//TODO in another session
		/*else if (!isGrounded)
		{
			
		}*/
		
		//TODO this session : facing will be used to make the character move relative to the camera
		//float facing = Camera.main.transform.eulerAngles.y;

		//Set the variables according to the imput. They will be used for the movement of the player
		x = Input.GetAxis("Horizontal");
		z = Input.GetAxis("Vertical"); //We use z cause unity doesn't understand standard axis
		
		//Set the animation variables
		//TODO in another session
		
		
		//We set the new velocity without the camera facing. We keep the normal y speed of the rigidbody because at 0 the character will float in the air instead of falling
		Vector3 inputs = new Vector3(x * speed, this.GetComponent<Rigidbody>().velocity.y, z * speed);

		//TODO this session :  We change our inputs vector so it rotates so the player can move relative to how the camera is positionned
		//Vector3 myTurnedInputs = Quaternion.Euler(0, facing, 0) * inputs;

		//We set the velocity of the player with our new inputs
		rb.velocity = inputs;

		//We rotate our character so turns to the direction he is moving towards
		facingVect = new Vector3();

		//make the player character look in that direction


	}
}
