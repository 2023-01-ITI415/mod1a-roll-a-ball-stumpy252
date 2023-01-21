using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent <Rigidbody> ;
    }
    void FixedUpdate()
    {
        
    }
    void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.get<Vector2>;
    }
}
