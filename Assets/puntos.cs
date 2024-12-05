using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Puntos : MonoBehaviour
{
    [SerializeField] private float cantPuntos;
    [SerializeField] private Tiempo tiempo;
    // Update is called once per frame

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            tiempo.Sumartiempo(cantPuntos);
            print("sumaste tiempo +5seg");
            Destroy(gameObject);

        }
    }
}
