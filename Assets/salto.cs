using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;
/*
public class salto : MonoBehaviour
{
    private bool saltoActivo = true; // Variable para activar/desactivar el movimiento

    public Rigidbody2D rbd;
    public float fuerza;
    public float longitudRaycast =0.1f;
    public LayerMask capasuelo;
    public Animator animator;   //ANIMACION salto

    private bool enSuelo;

    // Start is called before the first frame update
    void Start()
    {
        rbd = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (saltoActivo)
        { 
            transform.position = new Vector3(vel);
            RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, longitudRaycast, capasuelo);
            enSuelo = hit.collider != null;
            if (enSuelo && Input.GetKeyDown(KeyCode.Space))
            {
                rbd.AddForce(Vector2.up * fuerza, ForceMode2D.Impulse);
                animator.SetFloat("ensuelo", enSuelo);

            }
            /*if (Input.GetKeyDown(KeyCode.Space))
            {
                rbd.AddForce(Vector2.up * fuerza, ForceMode2D.Impulse);
                //animator.SetFloat("ensuelo");

            }*/
       /* }
        void OnDrawGizmos()
        {
            Gizmos.color = Color.yellow;
            Gizmos.DrawLine(transform.position, transform.position + Vector3.down * longitudRaycast);
        }
    }
    public void ActivarSalto(bool activar)
    {
        saltoActivo = activar;
    }
    private void OnMouseDown()
    {
        print("Me pincharon");
    }
}
*/