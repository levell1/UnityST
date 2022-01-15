using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionevent : MonoBehaviour
{
    [SerializeField] //직렬화    
    private Color   color;
    private SpriteRenderer spriteRenderer;
    private void Awake() {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        spriteRenderer.color=color;
    }
    private void OnCollisionStay2D(Collision2D collision) {
        Debug.Log(gameObject.name + " : stay");
    }
    private void OnCollisionExit2D(Collision2D collision) {
        spriteRenderer.color=Color.white;
    }

}
