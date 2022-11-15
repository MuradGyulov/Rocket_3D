using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class GameCamera : MonoBehaviour
{
    [SerializeField] private float cameraMovementSpeed;
    [SerializeField] private Vector3 cameraOffset;

    private GameObject player;
    private Transform target;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Rocket");
        target = player.GetComponent<Transform>();
    }

    private void FixedUpdate()
    {
        Vector3 desiredPosition = target.position + cameraOffset;
        Vector3 smothPosition = Vector3.Lerp(transform.position, desiredPosition, cameraMovementSpeed);
        transform.position = smothPosition;
    }
}
