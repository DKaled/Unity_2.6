using UnityEngine;
using IEnumerator = System.Collections.IEnumerator;

public class Colision : MonoBehaviour
{
    private Animator animator;
    private bool haColisionado = false;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Hero") && !haColisionado)
        {
            haColisionado = true;

            animator.SetTrigger("Desaparecer");
            Debug.Log("Colision detectada");
        }
    }

}