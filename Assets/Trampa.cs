using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Color = UnityEngine.Color;

public class Trampa : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Corrutina para desvanecer (fade out)
    IEnumerator FadeOut()
    {
        SpriteRenderer renderer = GetComponent<SpriteRenderer>();
        for (float f = 1f; f >= 0; f -= 0.1f)
        {
            Color c = renderer.color;
            c.a = f;
            renderer.material.color = c;
            //print(renderer.material.color.a);
           
            yield return new WaitForSeconds(0.3f);
        }
        Color color = renderer.color;
        color.a = 0f;
        renderer.material.color = color;
    }

    // Corrutina para aparecer (fade in)
    IEnumerator FadeIn()
    {
        SpriteRenderer renderer = GetComponent<SpriteRenderer>();
        for (float f = 0f; f <= 1f; f += 0.1f)
        {
            Color c = renderer.color;
            c.a = f;
            renderer.material.color = c;
            //print(renderer.material.color.a);

            yield return new WaitForSeconds(0.3f);
        }
        Color color = renderer.color;
        color.a = 1f;
        renderer.material.color = color;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
         StartCoroutine(FadeOut());
        
    }
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.T))
        {
            StartCoroutine(FadeIn());
        }
    }
}