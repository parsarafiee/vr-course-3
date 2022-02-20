using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float gravity = -9.81f;
    private float fallingSpeed;
    public CharacterController characterController;
    public LayerMask leyers;
    public bool isGrounded;
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        isGrounded = CheckIfGrounded();
        if (isGrounded)
            fallingSpeed = 0;
        else
            fallingSpeed += gravity * Time.deltaTime;
        characterController.Move(Vector3.up * fallingSpeed * Time.deltaTime);
    }
    bool CheckIfGrounded()
    {
        Vector3 raystart = transform.TransformPoint(characterController.center);
        float rayLenght = characterController.center.y + 0.01f;
        bool hasHit = Physics.SphereCast(raystart, characterController.radius, Vector3.down, out RaycastHit hitInfo, rayLenght, leyers);
        return hasHit;

    }
}
