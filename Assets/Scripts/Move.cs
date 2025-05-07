using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] float moveSpeed = 8;
    // Start is called before the first frame update
    void Start()
    {
        Instruction();
    }

    // Update is called once per frame
    void Update()
    {
        movePlayer();
    }

    void Instruction()
    {
        Debug.Log("Welcome to the game!");
        Debug.Log("Move your player with WASD or arrow key");
        Debug.Log("Don't hit the walls!");
    }
    void movePlayer()
    {
        float x = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float z = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(x, 0, z);
    }
}
