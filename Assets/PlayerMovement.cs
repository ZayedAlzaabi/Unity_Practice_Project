using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private CharacterController _characterController;

    [SerializeField] private float _speed = 15f;
    [SerializeField] private float _gravity = -9.8f;

    Vector3 velocity;
    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");

        Vector3 movement = transform.right * x + transform.forward * z;

        _characterController.Move(movement * (_speed * Time.deltaTime));

        velocity.y += _gravity * Time.deltaTime;
        _characterController.Move(velocity * Time.deltaTime);
    }
}
