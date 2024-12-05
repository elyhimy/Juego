using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Tiempo : MonoBehaviour
{
    private float tiempo = 30;
    private TextMeshProUGUI textMesh;
    private bool tiempoDetenido = false;
    private bool tiempoActivo = true; // Variable para activar/desactivar el movimiento


    private void Start()
    {
        textMesh = GetComponent<TextMeshProUGUI>();
        
    }

    // Ejemplo en el script Tiempo
    private void Update()
    {
        if (tiempoActivo)
        {

            if (!tiempoDetenido)
            {
                tiempo -= Time.deltaTime;
                textMesh.text = tiempo.ToString("0");
                if (tiempo <= 0)
                {
                    print("Tiempo!!!");
                    tiempoDetenido = true;

                    Movimiento movimientoScript = FindObjectOfType<Movimiento>(); // Desactivar el movimiento cuando el tiempo llega a 7
                    if (movimientoScript != null)
                    {
                        movimientoScript.ActivarMovimiento(false);
                    }

                   /* salto saltoScript = FindObjectOfType<salto>();  // Desactivar el salto cuando el tiempo llega a 7
                    if (saltoScript != null)
                    {
                        saltoScript.ActivarSalto(false);
                    }*/
                }
            }
        }
    }

    public void ReiniciarTiempo(bool activar)
    {       
        tiempo= 10;
        tiempoActivo = true;
        tiempoDetenido = false;
    }
    public void Sumartiempo(float TiempoEntrada)
    {
        if (!tiempoDetenido)
        {
            tiempo += TiempoEntrada;
        }
    }
    public float GetTiempo() // Método público para obtener el valor del tiempo { return tiempo;
    {  
        return tiempo; 
    }
}