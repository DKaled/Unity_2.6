using UnityEngine;

public class MovimientoPersonaje : MonoBehaviour
{
    public float velocidad = 150f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        
        float movimientoVertical = Input.GetAxis("Vertical");

        rb.linearVelocity = new Vector2(movimientoHorizontal * velocidad, movimientoVertical * velocidad);
    }
}