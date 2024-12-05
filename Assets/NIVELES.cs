using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NIVELES : MonoBehaviour
{
 
[SerializeField] private float cantPuntos;
[SerializeField] private Tiempo tiempo;

public bool nivell1 = true;
public bool nivell2 = false;

    // Start is called before the first frame update
    void Start()
{
   /* GameObject[] nivel2Objects = GameObject.FindGameObjectsWithTag("nivel2");// Encuentra todos los objetos con el tag "nivel2" y los desactiva inicialmente
    foreach (GameObject obj in nivel2Objects)
    {
        obj.SetActive(false);
    }*/
}
    private void OnTriggerEnter2D(Collider2D other) //nivel 1
    {
        if (other.CompareTag("Player"))
        {
            nivell1 = false;
            nivell2 = true;
            print("pasaste al NIVEL 2");

            GameObject[] carros = GameObject.FindGameObjectsWithTag("nvl1");            // Encuentra todos los objetos con el tag "carro"


            foreach (GameObject caro in carros)            // Destruye cada objeto con el tag "carro"

            {
                Destroy(caro);
            }

            Destroy(gameObject);   // Destruye el objeto si es necesario

            tiempo.Sumartiempo(cantPuntos);
            print("sumaste tiempo +20seg");
        }
        // Encuentra todos los objetos con el tag "nivel2"
        GameObject[] Move = GameObject.FindGameObjectsWithTag("nivel2");

        foreach (GameObject obj in Move)
        {
            // Mueve cada objeto 10 unidades hacia abajo
            obj.transform.position -= new Vector3(0,-12, 0);
        }

    }
     

}



/*using UnityEngine;

public class NIVELES : MonoBehaviour
{
    [SerializeField] private float cantPuntos;
    [SerializeField] private Tiempo tiempo;
    // Update is called once per frame

    public bool nivell1 = true;
    public bool nivell2 = false;
    // Start is called before the first frame update
    void Start()
    {
    }

    private void OnTriggerEnter2D(Collider2D other) //nivel 1
    {
       nivell1 = false;

        if (nivell1 = true)
        {
            if (other.CompareTag("Player"))
            {
                print("pasaste al NIVEL 2");

                // Encuentra todos los objetos con el tag "car"
                GameObject[] cars = GameObject.FindGameObjectsWithTag("carro");

                // Destruye cada objeto con el tag "car"
                foreach (GameObject car in cars)
                {
                    Destroy(car);
                }

                // Destruye el propio objeto si es necesario
                Destroy(gameObject);

                if (other.CompareTag("Player"))
                {
                    tiempo.Sumartiempo(cantPuntos);
                    print("sumaste tiempo +20seg");
                }
            }
        }
        nivell2 = true;

        if (nivell2 == true) // cambia esta condición
        {
            if (other.CompareTag("Player"))
            {
                print("pasaste al NIVEL 3");

                // Encuentra todos los objetos con el tag "nivel2"
                GameObject[] nivel2Objects = GameObject.FindGameObjectsWithTag("nivel2");

                // Hacer que cada objeto con el tag "nivel2" aparezca (activar)
                foreach (GameObject obj in nivel2Objects)
                {
                    obj.SetActive(true);
                }

            }
        }
    }
}*/