using UnityEngine;

public class cameraController : MonoBehaviour
{
    private Main_controller playerInput;

    public float movementSpeed;
    public float movementTime;
    public Transform followTransform;
    public Vector3 offset;

    public Vector3 newPosition;

    private void Awake() {
        playerInput = new Main_controller();
    }

    private void OnEnable() {
        playerInput.Enable();
    }

    private void OnDisable() {
        playerInput.Disable();
    }

    void Start() 
    {
        newPosition = transform.position + offset;
    }

    void Update()
    {   

        HandleMovementInput();
        
    }

    void HandleMovementInput()
    {
        Vector2 movementInput = playerInput.Camera.Move.ReadValue<Vector2>();
        Vector3 move = new Vector3(movementInput.x, 0f, movementInput.y);
        if (move != Vector3.zero)
        {
            newPosition += move * Time.deltaTime * movementSpeed;
            transform.position = Vector3.Lerp(transform.position, newPosition, Time.deltaTime * movementTime);
        }
        else
        {
            transform.position = followTransform.position + offset;
            newPosition = transform.position;
        }
        
    }
}
