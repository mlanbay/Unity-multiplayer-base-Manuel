using UnityEngine;
using UnityEngine.InputSystem;

public class AvatarController : MonoBehaviour
{
    [SerializeField] private float speed = 3.0f;
    private SpriteRenderer spriteRenderer;
    
    // crea un avatar (Cliente) y le asigna un color distinto
    void Start()
    {
        
    }

    // controla la posicion de los clientes
    void Update()
    {
        
    }
    
    //maneja el input del Cliente que posees

    public void Move(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Vector2 movement = context.ReadValue<Vector2>();
            transform.Translate(movement * speed * Time.deltaTime, Space.World);
        }
    }
    
}
