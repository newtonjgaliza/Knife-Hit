using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Espada : MonoBehaviour
{
    private Rigidbody2D oRigidbody2D;

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
}
