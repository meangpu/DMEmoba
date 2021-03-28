 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private Main_controller playerInput;

    private CharacterController controller;
    private Vector3 playerVelocity;
    private bool groundedPlayer;
    [SerializeField]
    private float playerSpeed = 2.0f;
    // [SerializeField]
    // private float jumpHeight = 1.0f;
    [SerializeField]
    private float gravityValue = -9.81f;
    public Animator anim = null;

    private void Awake() {
        playerInput = new Main_controller();
        controller = GetComponent<CharacterController>();
    }

    private void OnEnable() {
        playerInput.Enable();
    }

    private void OnDisable() {
        playerInput.Disable();
    }

    void Update()
    {
        groundedPlayer = controller.isGrounded;
        if (groundedPlayer && playerVelocity.y < 0)
        {
            playerVelocity.y = 0f;
        }

        Vector2 movementInput = playerInput.Playermain.Move.ReadValue<Vector2>();
        // Debug.Log(movementInput);
        Vector3 move = new Vector3(movementInput.x, 0f, movementInput.y);

        //set animation speed
        anim.SetFloat("speed", (Mathf.Abs(move.x)+Mathf.Abs(move.z)) * playerSpeed);

        controller.Move(move * Time.deltaTime * playerSpeed);

        if (move != Vector3.zero)
        {
            gameObject.transform.forward = move;
        }

        // Changes the height position of the player..
        if (playerInput.Playermain.Attack.triggered)
        {
            anim.SetTrigger("attack");

            // playerVelocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravityValue);
        }

        playerVelocity.y += gravityValue * Time.deltaTime;
        controller.Move(playerVelocity * Time.deltaTime);
    }



}
