using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fondomovi : MonoBehaviour
{
    [SerializeField] private Vector2 velocidadMov;
    private Vector2 offset;
    private Material Material;
    //private Rigidbody2D jugadorRB
    // Start is called before the first frame update
    private void Awake()
    {
        Material = GetComponent<SpriteRenderer>().material;
        //        jugadorRB = GameObject.FindGameObjectWithTag("player").GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    private void Update()
    {
        // offset = (jugadorRB.velocity.x * 0.1f) * velocidadMov * Time.deltaTime;
        offset = velocidadMov * Time.deltaTime;
        Material.mainTextureOffset += offset;
    }
}
