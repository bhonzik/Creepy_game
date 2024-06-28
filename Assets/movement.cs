using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    private Vector3 PlayerMovementInput;
    private float pitchAngle = 0f;

    [SerializeField] private Rigidbody PlayerBody;
    [SerializeField] private Transform PlayerCamera;
    [Space]
    [SerializeField] private float Speed;
    [SerializeField] private float Sensitivity;
    [SerializeField] private float Jumpforce;
    [SerializeField] private float maxPitchAngle = 80f; // Max pitch angle in degrees.

    private void LateUpdate()
    {
        // Update player movement input
        PlayerMovementInput = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));

        // Update player mouse input
        float pitch = Input.GetAxis("Mouse Y") * -Sensitivity;
        float yaw = Input.GetAxis("Mouse X") * Sensitivity;

        // Apply yaw (horizontal rotation around the y-axis)
        transform.Rotate(0f, yaw, 0f, Space.World);

        // Update pitch angle and clamp it
        pitchAngle = Mathf.Clamp(pitchAngle + pitch, -maxPitchAngle, maxPitchAngle);

        // Apply pitch (vertical rotation around the x-axis) based on clamped angle
        PlayerCamera.localEulerAngles = new Vector3(pitchAngle, PlayerCamera.localEulerAngles.y, PlayerCamera.localEulerAngles.z);

        // Move the player
        MovePlayer();
    }

    private void MovePlayer()
    {
        // Calculate the movement vector
        Vector3 moveVector = transform.TransformDirection(PlayerMovementInput) * Speed;

        // Set the player's velocity, maintaining the existing Y velocity
        PlayerBody.velocity = new Vector3(moveVector.x, PlayerBody.velocity.y, moveVector.z);

        // Check for jump input
        if (Input.GetKeyDown(KeyCode.Space) && Mathf.Abs(PlayerBody.velocity.y) < 0.01f) // Add a small threshold to ensure jumping is smooth
        {
            PlayerBody.AddForce(Vector3.up * Jumpforce, ForceMode.Impulse);
        }
    }
}