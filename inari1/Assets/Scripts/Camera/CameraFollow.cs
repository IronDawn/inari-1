using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform target;
    public float smoothTime;
    public float disToPlayer;
    public Vector4 boundaries;
    Vector2 vel = Vector2.zero;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 targetPos = new Vector2(Mathf.Clamp(target.position.x,boundaries.x,boundaries.z),Mathf.Clamp(target.position.y,boundaries.y,boundaries.w));
        transform.position = Vector2.SmoothDamp(transform.position, targetPos, ref vel, smoothTime);
        transform.position = new Vector3(transform.position.x, transform.position.y, disToPlayer);
    }
}
