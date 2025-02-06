using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class AvatarController : MonoBehaviour
{
    [SerializeField] private float speed = 3.0f;
    private SpriteRenderer spriteRenderer;
    private Vector2 inputVector;
    private Rigidbody2D rigidbody2D;
    
    private bool keydown;
    
    // crea un avatar (Cliente) y le asigna un color distinto
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();    
    }

    // controla la posicion de los clientes
    void Update()
    {
        Move();
    }
    
    
    
    //maneja el input del Cliente que posees

    public void OnMoveInput(InputAction.CallbackContext context)
    {
        inputVector = context.ReadValue<Vector2>();
        if (context.canceled)
        {
            keydown = false;
        }else if (context.started)
        {
            keydown = true;
        }
    }

    public void Move()
    {
        if (keydown)
        {
            rigidbody2D.linearVelocity = inputVector * (speed * Time.deltaTime);
        }
    }
}
