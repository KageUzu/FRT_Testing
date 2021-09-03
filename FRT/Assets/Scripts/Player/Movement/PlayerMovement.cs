using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;

    public Light flashlight;

    public float speed = 12f;
    public float gravity = -9.81f;
    public float JumpHeight = 3f;

    public float ClimbSpeed = 2f;

    public Transform GroundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    Vector3 velocity;
    bool isGrounded;
    bool isClimbing;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //checks if play on ground
        isGrounded = Physics.CheckSphere(GroundCheck.position, groundDistance, groundMask);

        //if playone on ground velocity is reduced
        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        //movement
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        if (isClimbing)
        {
            velocity.y = Mathf.Sqrt(ClimbSpeed * -2f * gravity);
        }

        //jump
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(JumpHeight * -2f * gravity);
        }

        //gravity at work
        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.V))
        {
            FindObjectOfType<GameOver>().EndGame();
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            Flashlight();
        }

    }
    //Checks if surface is climbable
    private void OnTriggerEnter(Collider climbable)
    {
        isClimbing = true;
    }

    private void OnTriggerExit(Collider climbable)
    {
        isClimbing = false;
    }

    //Turns Flashlight off/on
    void Flashlight()
    {
        flashlight.enabled = !flashlight.enabled;
    }



}
