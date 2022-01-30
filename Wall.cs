using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
   private void Awake() {
       spriteRenderer = GetComponent<SpriteRenderer>();
   }
   private void OnTriggerEnter2D(Collider2D ohter) {
       Destroy(ohter.gameObject);
       StartCoroutine("HitAnimation");
       //hitanimation을 불러온다. 
   }
   private IEnumerator HitAnimation(){
       spriteRenderer.color=Color.red;
       yield return new WaitForSeconds(0.1f);
       spriteRenderer.color=Color.white;
   }
}
