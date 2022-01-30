using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerEx : MonoBehaviour
{
       [SerializeField]
    private GameObject boxprefab;
    private void Awake() {
        Quaternion rotation = Quaternion.Euler(0,0,0);
        for (int y = 0; y < 10; y++)
        {
            for (int x = 0; x < 10; x++)
            {
                if ( x == y || x+y==9 )
                {
                    continue;
                }
                Vector3 position = new Vector3(-4.5f +x,4.5f-y,0);
                Instantiate(boxprefab,position,rotation);
            }
        }
        
    }
}
