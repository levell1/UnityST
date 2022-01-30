using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomprefab : MonoBehaviour
{
    [SerializeField]
    private GameObject[] prefabArray;
    [SerializeField]
    private int number;
    

   private void Awake() {
    for (int i = 0; i < number; i++)
    {
        int index   = Random.Range(0, prefabArray.Length);    //
        float x     = Random.Range(-7.5f,7.5f);
        float y     = Random.Range(-4.5f,4.5f);
        
        Vector3 position = new Vector3(x,y,0);

        GameObject clone =Instantiate(prefabArray[index], position, Quaternion.identity);
        clone.GetComponent<SpriteRenderer>().color = Color.black;
    }   
   }
}
