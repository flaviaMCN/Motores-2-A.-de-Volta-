using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float velocidade;

   private float movimentoHorizontal = 0f;

    private float movimentoVertical = 0f;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            movimentoHorizontal = 1f;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            movimentoHorizontal = -1f;
        }
        else
        {
            movimentoHorizontal = 0f;
        }

        transform.position += new Vector3(movimentoHorizontal, 0f, 0f) * velocidade * Time.deltaTime;
        
        if (Input.GetKey(KeyCode.W))
        {
            movimentoVertical = 1f;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            movimentoVertical = -1f;
        }
        else
        {
            movimentoVertical = 0f;
        }
        
        transform.position += new Vector3(0f, movimentoVertical, 0f) * velocidade * Time.deltaTime;
    }
}
