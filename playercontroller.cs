using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour
{
    private Movement2D movement2D;
    private void Awake() {
        movement2D = GetComponent<Movement2D>();
    }

    private void Update() {
        
        float x = Input.GetAxisRaw("Horizontal");
        movement2D.Move(x);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            movement2D.jump();
        }
        if (Input.GetKey(KeyCode.Space))
        {
            movement2D.isLongJump = true;
        }
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            movement2D.isLongJump = false;
        }

    }
}

