using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectspawner : MonoBehaviour
{
    [SerializeField]
    private GameObject boxprefab;
    private void Awake() {
        Quaternion rotation = Quaternion.Euler(0,0,45);
        Instantiate(boxprefab);
        Instantiate(boxprefab,new Vector3(2,3,0),Quaternion.identity);
        // 오브젝트, 위치 , 회전값 Quaternion.identity-> 0,0,0
        Instantiate(boxprefab,new Vector3(2,3,0),rotation);

        //생성하면서 이름지정, 내용변경
        GameObject clone = Instantiate(boxprefab,Vector3.zero,rotation);
        clone.name = "box 001";
        clone.GetComponent<SpriteRenderer>().color = Color.black;
        clone.transform.position = new Vector3(2,1,0);      //위치
        clone.transform.localScale = new Vector3(3,2,1);    //크기
        
    }
}
