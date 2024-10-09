using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public float velocidadX = 5f;          // Velocidad de movimiento en X
    public float fuerzaSalto = 5f;         // Fuerza del salto
    public float gravedad = 2f; // Ajuste de la gravedad
    private Rigidbody rb;                  // Referencia al Rigidbody

    void Start()
    {
        // Obtener el Rigidbody del objeto
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false;  // Desactivar la gravedad est�ndar de Unity
    }

    void Update()
    {
        // Movimiento en el eje X
        transform.position += new Vector3(velocidadX * Time.deltaTime, 0, 0);

        // Aplicar gravedad personalizada manualmente
        rb.AddForce(Vector3.down * gravedad, ForceMode.Acceleration);

        // Si el jugador presiona la barra espaciadora y la pelota est� en el suelo
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Saltar();
        }
    }

    void Saltar()
    {
        // A�adir fuerza en el eje Y para saltar
        rb.AddForce(Vector3.up * fuerzaSalto, ForceMode.Impulse);
    }

}
