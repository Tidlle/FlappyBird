using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class obstaculo : MonoBehaviour
{
    [SerializeField]
    private float velocidade = 1.5f;

    [SerializeField]
    private float variacaoposicaoY;
    private Vector3 posicaoPassaro;
    private UIControler controladorUI;

    private bool pontuei;
    
    private void Awake()
    {
        this.transform.Translate(Vector3.up * Random.Range(-variacaoposicaoY, variacaoposicaoY));
    }
    private void Start()
        {
        this.posicaoPassaro = GameObject.FindObjectOfType<personagem>().transform.position;
        this.controladorUI = GameObject.FindObjectOfType<UIControler>();
        }
    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(Vector3.left * Time.deltaTime);
        if (!this.pontuei && this.transform.position.x < this.posicaoPassaro.x){
            this.controladorUI.adicionarPontos();
            this.pontuei = true;    
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        this.Destruir();
    }

    private void Destruir()
    {
        Destroy(this.gameObject);
    }
}
