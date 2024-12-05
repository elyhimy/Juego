using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class textos : MonoBehaviour
{
    // Start is called before the first frame update
    public Tiempo tiempoScript; // Referencia al script Tiempo

    private Vector3 previusposition;
    [SerializeField]
    private float movimientoF = 10f;
    private bool movimientoActivo = true; // Variable para activar/desactivar el movimiento

    //SALTO////
    private bool saltoActivo = true; // Variable para activar/desactivar el movimiento

    public float fuerzaSalto = 10f;
    public float longitudRaycast = 0.1f;
    public LayerMask capasuelo;

    private bool enSuelo;
    public Rigidbody2D rbd;


    // Start is called before the first frame update
    void Start()
    {

        previusposition = transform.localPosition;

        //salto
        rbd = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        if (movimientoActivo)
        {
            float movementX = Input.GetAxisRaw("Horizontal");

            RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, longitudRaycast, capasuelo);
            enSuelo = hit.collider != null;
            if (enSuelo && Input.GetKeyDown(KeyCode.Space))
            {
                rbd.AddForce(new Vector2(0f, fuerzaSalto), ForceMode2D.Impulse);

            }

            Vector2 poiscionjug = transform.position;

            poiscionjug = poiscionjug + new Vector2(movementX, 0f) * movimientoF * Time.deltaTime;

            transform.position = poiscionjug;
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            Movimiento movimientoScript = FindObjectOfType<Movimiento>(); // Desactivar el movimiento cuando el tiempo llega a 7
            if (movimientoScript != null)
            {
                movimientoScript.ActivarMovimiento(true);
            }
            Tiempo tiempooScript = FindObjectOfType<Tiempo>(); // Desactivar el movimiento cuando el tiempo llega a 7
            if (tiempooScript != null)
            {
                tiempooScript.ReiniciarTiempo(true);
            }
            
        }
    }
    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position, transform.position + Vector3.down * longitudRaycast);
    }

    public void ActivarMovimiento(bool activar)
    {
        movimientoActivo = activar;
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("carro"))
        {
            gameObject.transform.position = previusposition;
           
        }
    }

}
