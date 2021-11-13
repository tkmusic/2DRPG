using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform target;
    public float smoothing;
    public Vector2 maxPosition;
    public Vector2 minPosition;
    private Vector3 Velocity = Vector3.zero;

    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (transform.position.x != target.position.x || transform.position.y != target.position.y)
        {
            
            Vector3 targetPosition = new Vector3(target.position.x, target.position.y, transform.position.z);
            targetPosition.x = Mathf.Clamp(targetPosition.x, minPosition.x, maxPosition.x);
            targetPosition.y = Mathf.Clamp(targetPosition.y, minPosition.y, maxPosition.y);
            transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref Velocity, smoothing);
        }
    }

    // max x 0.09
    // max y 9.03
    // min x -18.13
    // min y 0
}
