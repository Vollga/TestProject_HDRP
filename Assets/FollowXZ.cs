using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowXZ : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    public bool LookAt = false;
    public bool Once = false;
    public float step = 0.1f;

    void Update() {
        if ( target == null ) return;

        Vector3 tPos = target.position + offset;
        tPos.y = transform.position.y;

        if ( Once ) {
            enabled = false;
            transform.position = Vector3.Lerp(transform.position, tPos, 1f);
        }
        else {
            transform.position = Vector3.Lerp(transform.position, tPos, step);
        }
    
        if ( LookAt ) {
            transform.LookAt( target );
        }
    }
}