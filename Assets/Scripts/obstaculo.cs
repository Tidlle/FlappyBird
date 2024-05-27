using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstaculo : MonoBehaviour
{
    [SerializeField]
    private float velocidade = 1.5f;

    [SerializeField]
    private float variacaoposicaoY;
    void Start()
    {
        
    }

    private void Awake()
    {
        this.transform.Translate(Vector3.up * Random.Range(-variacaoposicaoY, variacaoposicaoY));
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(Vector3.left * Time.deltaTime);   
    }
}
