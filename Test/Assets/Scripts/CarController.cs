using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    [SerializeField] private float runSpeed = 2f;
    public void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("MoveObst") || collision.gameObject.CompareTag("Finishh"))
        {
            runSpeed = 0f;

        }
    }

    private float gravity = -50f;
    private CharacterController characterController;
    private Vector3 velocity;
    private float horizontalInput;
 
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        horizontalInput = 1;

        //FaceForward
        transform.right = new Vector3(horizontalInput, 0, Mathf.Abs(horizontalInput) - 1);


        velocity.y += gravity * Time.deltaTime;



        characterController.Move(new Vector3(0, 0, horizontalInput * runSpeed) * Time.deltaTime);

    }
}
