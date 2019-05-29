using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlphaRotation : MonoBehaviour
{
    public bool flip;

    Material CogShader;
    Transform CogRotation;

    // Start is called before the first frame update
    void Start()
    {
        CogShader = gameObject.GetComponent<MeshRenderer>().material;
        CogRotation = gameObject.GetComponent<Transform>();
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //print(gameObject.GetComponent<Transform>().eulerAngles.z);
        if(flip == false)
        {
            CogShader.SetFloat("Vector1_F55E87F3", CogRotation.eulerAngles.z);
        } else
        {
            CogShader.SetFloat("Vector1_F55E87F3", CogRotation.eulerAngles.z*-1);
        }

        
    }
}
