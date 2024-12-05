using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class practicaMouse : MonoBehaviour
{
    // Start is called before the first frame update
    enum ActionType {
        Color, 
        Sprite, 
        Scale
    }
    
    [SerializeField]
    ActionType actionType;
    [SerializeField]
    Color[] colors;
    [SerializeField]
    Sprite[] sprites;
    [SerializeField]
    Vector3[] scales;
    
    int clickCounter = 0;
    int contador = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetKeyDown(KeyCode.Space)))
        {
            if (contador == 0)
            {
                actionType = ActionType.Color;
                contador++;
                Debug.Log(contador);
            }
            else {
                if (contador == 1)
                {
                    actionType = ActionType.Sprite;
                    contador++;
                    Debug.Log(contador);
                }
                else {
                    if (contador == 2)
                    {
                        actionType = ActionType.Scale;
                        contador = 0;
                        Debug.Log(contador);
                    }
                }
            }
        }
    }

    private void OnMouseDown()
    {
        //Debug.Log("Me Tocaron wey");
        //GetComponent<SpriteRenderer>().color = Color.magenta;
        switch (actionType) {
            case ActionType.Color:
                Color colorActual = colors[clickCounter];
                GetComponent<SpriteRenderer>().color = colorActual;
                if (clickCounter == colors.Length - 1)
                {
                    clickCounter = 0;
                }
                else {
                    clickCounter++;
                }
                break;
            case ActionType.Sprite: 
                Sprite SpriteActual = sprites[clickCounter];
                GetComponent<SpriteRenderer>().sprite = SpriteActual;
                if (clickCounter == sprites.Length - 1)
                {
                    clickCounter = 0;
                }
                else
                {
                    clickCounter++;
                }
                break;
            case ActionType.Scale:
                Vector3 Scale = scales[clickCounter];
                GetComponent<Transform>().localScale = Scale;
                if (clickCounter == scales.Length - 1)
                {
                    clickCounter = 0;
                }
                else
                {
                    clickCounter++;
                }
                break;
        }
    }
}
