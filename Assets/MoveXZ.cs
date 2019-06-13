using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveXZ : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        float speed = Time.deltaTime * 10;
        transform.Translate(Input.GetAxis("Horizontal") * speed, 0, Input.GetAxis("Vertical") * speed, Space.World);
    }
}
