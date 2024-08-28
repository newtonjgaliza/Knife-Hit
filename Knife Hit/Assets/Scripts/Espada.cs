using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Espada : MonoBehaviour
{
    [Header("Referências Gerais")]
    private Rigidbody2D oRigidbody2D;

    [Header("Lançamento da Espada")]
    [SerializeField] private float forcaDoLancamento = 20f;
    private bool foiLancada = false;


    // Start is called before the first frame update
    void Start()
    {
        oRigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        ReceberInput();
    }

    private void ReceberInput()
    {
        if(Input.GetMouseButtonDown(0) && !foiLancada)
        {
            LancarEspada();
        }
    }

    private void LancarEspada()
    {
        oRigidbody2D.AddForce(new Vector2(0f, forcaDoLancamento), ForceMode2D.Impulse);
        oRigidbody2D.gravityScale = 1f;
    }

    private void OnCollisionEnter2D(Collision2D collider)
    {
        if(!foiLancada)
        {
            if(collider.gameObject.GetComponent<Alvo>() != null)
            {
                oRigidbody2D.velocity = Vector2.zero; //new Vector2(0, 0)
                oRigidbody2D.gravityScale = 0f;
                oRigidbody2D.bodyType = RigidbodyType2D.Static;
                transform.SetParent(collider.gameObject.transform);
            }
            else if(collider.gameObject.GetComponent<Espada>() != null)
            {
                oRigidbody2D.velocity = Vector2.zero;
            }

            foiLancada = true;
        }
    }


}
