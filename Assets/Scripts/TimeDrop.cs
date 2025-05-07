using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeDrop : MonoBehaviour
{
    [SerializeField] float timeTowait = 3f;
    Renderer renderer;
    Rigidbody rigid;
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<Renderer>();
        rigid = GetComponent<Rigidbody>();
        renderer.enabled = false;
        renderer.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > timeTowait)
        {
            renderer.enabled = true;
            rigid.useGravity = true;
        }
    }
}
