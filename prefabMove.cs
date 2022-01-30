using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prefabMove : MonoBehaviour
{   
    [SerializeField]
    private float speed = 5.0f;
    private Vector3 moveDirection;

    public void setup(Vector3 direction){
        moveDirection =direction;
    }
    private void Update() {
        //새로운 위치 = 현재 위치 + ( 방향 * 속도 )
        transform.position += moveDirection * speed * Time.deltaTime;
    }
}
