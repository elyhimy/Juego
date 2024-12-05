using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public Tiempo tiempoScript; // Referencia al script Tiempo

    private Vector3 previusposition;
    public int vidas = 3;

    [SerializeField]
    private float movimientoF = 10f;
    private bool movimientoActivo = true; // Variable para activar/desactivar el movimiento

    //SALTO////
    private bool saltoActivo = true; // Variable para activar/desactivar el movimiento

    public float fuerzaSalto =10f;
    public float longitudRaycast = 0.1f;
    public LayerMask capasuelo;

    private bool enSuelo;
    public Rigidbody2D rbd;

    public Animator animator;   //ANIMACION MOVIMIENTO

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

            animator.SetFloat("movement", movementX*movimientoF);
                     
            RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, longitudRaycast, capasuelo);
            enSuelo = hit.collider != null;
            if (enSuelo && Input.GetKeyDown(KeyCode.Space))
            {
                rbd.AddForce(new Vector2(0f, fuerzaSalto), ForceMode2D.Impulse);

            }
            animator.SetBool("ensuelo",enSuelo);

            if (movementX < 0)
            {
                transform.localScale = new Vector3(-1,1,1);
            }
            if (movementX > 0)
            {
                transform.localScale = new Vector3(1,1,1);
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
           /* salto saltoScript = FindObjectOfType<salto>();  // Desactivar el salto cuando el tiempo llega a 7

            if (saltoScript != null)
            {
                saltoScript.ActivarSalto(true);
            }*/
            Tiempo tiempooScript = FindObjectOfType<Tiempo>(); // Desactivar el movimiento cuando el tiempo llega a 7
            if (tiempooScript != null)
            {
                tiempooScript.ReiniciarTiempo(true);
            }
            /*GameOver gameoverScript = FindObjectOfType<GameOver>(); // Desactivar el movimiento cuando el tiempo llega a 7
            if (tiempooScript != null)
            {
                gameoverScript.game(true);
            }*/
            print("ULTIMA OPORTUNIDAD... tienes 10 segundos");
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
            print("CUIDADO!!!, no lo toques!");
            vidas = vidas - 1;
            if (vidas == 0)
            {
                print("GAME OVER");
            }
        }

        if (collision.gameObject.CompareTag("vida"))
        {
            print("MONEDA");
            //Destroy(collision.gameObject);
        }

        //Destroy(gameObject);
    }
    /*public void ActivarSalto(bool activar)
    {
        saltoActivo = activar;
    }*/ 
    private void OnMouseDown()
    {
        print("Me pincharon");
    }
}