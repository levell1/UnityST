using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnPointer : MonoBehaviour
{
    [SerializeField]
    private int maxcount = 10;
    [SerializeField]
    private GameObject[] prefabArray;
    [SerializeField]
    private Transform[] spawnPointArray;
    private float timer;        //스폰주기
    [SerializeField]
    private float waittime = 1.0f;
    private int currentcount = 0;
    private Vector3 moveDirection ;

   private void Awake() {
        timer = 0.0f;

        int prefabIndex   = Random.Range(0, prefabArray.Length);    
        int spawnIndex   = Random.Range(0, spawnPointArray.Length);
        Vector3 position = spawnPointArray[spawnIndex].position; //랜덤한 위치
//     for (int i = 0; i < count; i++)
//     {
        
//         GameObject clone =Instantiate(prefabArray[prefabIndex], position, Quaternion.identity);
//         moveDirection = (spawnIndex == 0 ? Vector3.right : Vector3.left);
//         // // D = A ? B : C; A의 조건문이 참이면 B 에 거짓이면 C 에 D를저장
//         // if (spawnIndex==0)
//         // {
//         //     moveDirection = Vector3.right; 
//         // }else
//         // {
//         //     moveDirection = Vector3.left;
//         // }
//         clone.GetComponent<prefabMove>().setup(moveDirection);
//         clone.GetComponent<SpriteRenderer>().color = Color.black;
        
//     }   
   }
//     UPdate 로 주기적으로 생성
   void Update()
    {
        if (currentcount +1 > maxcount) //개수제한
        {
            return;
        }
        int prefabIndex   = Random.Range(0, prefabArray.Length);    
        int spawnIndex   = Random.Range(0, spawnPointArray.Length);
        Vector3 position = spawnPointArray[spawnIndex].position; //배열 중 랜덤한 위치

        timer += Time.deltaTime;
        if (timer > waittime)
        {
            GameObject clone =Instantiate(prefabArray[prefabIndex], position, Quaternion.identity);
            moveDirection = (spawnIndex == 0 ? Vector3.right : Vector3.left);

            clone.GetComponent<prefabMove>().setup(moveDirection);
            clone.GetComponent<SpriteRenderer>().color = Color.black;
            currentcount ++;
            timer = 0;
            Destroy(clone, 20); //X초 뒤 삭제
        }
        
    }
}
