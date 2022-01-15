using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triggerevent : MonoBehaviour
{
    [SerializeField]
    private GameObject moveObject;
    [SerializeField]
    private Vector3     moveDirection;
    private float       movespeed;
    private void Awake() {
        movespeed = 5.0f;
    }
    private void OnTriggerEnter2D(Collider2D collision) {
        moveObject.GetComponent<SpriteRenderer>().color = Color.black;
    }
    private void OnTriggerStay2D(Collider2D collision) {
        moveObject.transform.position += moveDirection * movespeed*Time.deltaTime;
    }
    private void OnTriggerExit2D(Collider2D collision) {
        moveObject.GetComponent<SpriteRenderer>().color =Color.white;
        //moveObject.transform.position = new Vector3(0,4,0);
    }
}
