using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class controller_player : MonoBehaviour
{
    private Vector3 moveInput;

    [SerializeField] private float speed;
    public float turnSmoothTime = 0.1f;
    float turnSmoothVelocity;
    float angle;

    [SerializeField] private float jumpForce;

    public CharacterController controller;
    private int score;
    public TextMeshProUGUI scoreText;

    // Add a reference to the Animator component
    private Animator animator;

    void Start()
    {
        // Get the Animator component from the player GameObject
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        ProcessInputs();
    }

    void ProcessInputs()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

        // Set the "Speed" parameter in the Animator based on the direction magnitude
        animator.SetFloat("Speed", direction.magnitude);

        if (direction.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);

            transform.rotation = Quaternion.Euler(0f, angle, 0f);

            controller.Move(direction * speed * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (controller.isGrounded)
            {
                moveInput.y = jumpForce;

                // Set the "IsJumping" parameter to true when the player jumps
                animator.SetBool("IsJumping", true);
            }
        }
        else if (controller.isGrounded)
        {
            // Set the "IsJumping" parameter to false when the player is grounded
            animator.SetBool("IsJumping", false);
        }

        moveInput.y += Physics.gravity.y * Time.deltaTime;
        controller.Move(moveInput * Time.deltaTime);
    }
}

