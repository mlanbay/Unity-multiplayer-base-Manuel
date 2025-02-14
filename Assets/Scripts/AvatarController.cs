using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using Unity.Netcode;
using ED.SC;

public class AvatarController : NetworkBehaviour
{
    [SerializeField] private float speed = 5.0f;
    
    private Vector2 inputVector; 
    private bool keydown;
    
    // crea un avatar (Cliente) y le asigna un color distinto
    void Start()
    {

    }

    // controla la posicion de todos los clientes
    void Update()
    {

        if (IsOwner)
        {
            Move();
        }

        
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
            transform.Translate(inputVector*speed*Time.deltaTime);
        }
    }
}
