using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anicontroller : MonoBehaviour
{
    private Animator animator;
    private void Awake() {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            animator.SetTrigger("isDie");
        }
    }
        public void OnDieEvent(){
        Debug.Log("end game");
    }
}

    
