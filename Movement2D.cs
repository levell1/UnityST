using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement2D : MonoBehaviour
{
    private float moveSpeed = 5.0f;
    //private Vector3 moveDirection = Vector3.zero;
    private Rigidbody2D rigid2D;
    private void Awake() {
        rigid2D = GetComponent<Rigidbody2D>();
    }
    private void Update() {
        
        //transform.position = transform.position + new Vector3(1,0,0)*speed;
        //transform.position += Vector3.right * speed * Time.deltaTime;
        float x = Input.GetAxisRaw("Horizontal");   //좌우      이동
        // Negative Left , a : -1
        // Positive Right , d : 1
        // Non : 0

        float y = Input.GetAxisRaw("Vertical");     //위아래    이동
        // Negative Donw , S : -1
        // Positive UP , W : 1
        // Non : 0

        // 이동방향 설정
        //moveDirection = new Vector3(x,y,0);

        // 새로운위치 = 현재 위치 + (방향 * 속도)
       // transform.position += moveDirection* moveSpeed * Time.deltaTime;
        rigid2D.velocity = new Vector3(x,y,0) * moveSpeed;
    }
}
