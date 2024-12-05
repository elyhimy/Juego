using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nivel3 : MonoBehaviour
{
    [SerializeField] private float cantPuntos;
    [SerializeField] private Tiempo tiempo;

    public bool nivell2 = true;
    public bool nivell3 = false;

    // Start is called before the first frame update
    void Start()
    {
    }
    private void OnTriggerEnter2D(Collider2D other) //nivel 1
    {
        if (other.CompareTag("Player"))
        {
            nivell2 = false;
            nivell3 = true;
            print("pasaste al NIVEL 3");

            GameObject[] caos = GameObject.FindGameObjectsWithTag("nivel2");            // Encuentra todos los objetos con el tag "carro"


            foreach (GameObject carro in caos)            // Destruye cada objeto con el tag "carro"

            {
                Destroy(carro);
            }

            Destroy(gameObject);   // Destruye el objeto si es necesario

            tiempo.Sumartiempo(cantPuntos);
            print("sumaste tiempo +20seg");
        }
        // Encuentra todos los objetos con el tag "nivel2"
        GameObject[] Mov = GameObject.FindGameObjectsWithTag("nivel3");

        foreach (GameObject obje in Mov)
        {
            // Mueve cada objeto 10 unidades hacia abajo
            obje.transform.position -= new Vector3(0, -12, 0);
        }

    }


}

