using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    public float playerSpeed = 5.0f;
    public float upPlayerSpeed = 15.0f;
    private float range = 10.0F;

    public Transform target;
    private Transform myTransform;

    void Start()
    {
        myTransform.position = new Vector3(0, 3, 0);
        myTransform.position = new Vector3(0, 10, 0);

    }
    void Update()
    {
        transform.Translate(Vector3.right * Input.GetAxis("Horizontal") *
            playerSpeed * Time.deltaTime
            );
    }
}
