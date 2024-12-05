using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public Tiempo tiempoScript; // Referencia al script Tiempo
    public GameObject objetoParaMostrar; // El objeto que se va mostrar
   // private bool go = true; // Variable para activar/desactivar el movimiento

    private void Start()
    {
        if (tiempoScript == null)
        {
            tiempoScript = FindObjectOfType<Tiempo>();
        }
        // Asegúrate de que el objeto esté inicialmente desactivado
        if (objetoParaMostrar != null)
        {
            objetoParaMostrar.SetActive(false);
        }

    }

    private void Update()
    {

        
        if (tiempoScript.GetTiempo() <= 0)
        {
            // Mostrar el objeto cuando el tiempo llegue a 7
            if (objetoParaMostrar != null)
            {
                objetoParaMostrar.SetActive(true);
                print("GAME OVER");
            }
        }
        
    }
}
