using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShot : MonoBehaviour
{
    [SerializeField]
    private KeyCode     keyCodeFire = KeyCode.Space;
    [SerializeField]
    private GameObject  Bulletprefab;
    private float       moveSpeed = 5.0f;
    private Vector3     lastMoveDirection = Vector3.right;
    private void Awake() {
    }
    private void Update() {
        
 
        float x = Input.GetAxisRaw("Horizontal");   //좌우      이동
        float y = Input.GetAxisRaw("Vertical");     //위아래    이동
        
        transform.position += new Vector3(x,y,0) * moveSpeed * Time.deltaTime;
        
        // 마지막 방향으로 총알 발사
        if (x !=0 || y !=0)
        {
            lastMoveDirection = new Vector3(x,y,0);
        }

        if (Input.GetKeyDown(keyCodeFire) )
        {
            GameObject clone = Instantiate(Bulletprefab,transform.position,Quaternion.identity);

            clone.name = "bullet";
            clone.transform.localScale=Vector3.one*0.5f;
            clone.GetComponent<SpriteRenderer>().color = Color.black;
            clone.GetComponent<prefabMove>().setup(lastMoveDirection); //

            Destroy(clone, 10);
        }

    }
}
