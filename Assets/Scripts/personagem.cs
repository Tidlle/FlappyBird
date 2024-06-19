using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class personagem : MonoBehaviour
{
    //cria a variavel fisica do tipo Rigidbody
    Rigidbody2D fisica;

    //método Awake é chamado toda vez que o objeto é criado
    private void Awake()
    {
        //adiciona à variavel física o componente RigidBody daquele objeto ativo no momento
        this.fisica = this.GetComponent<Rigidbody2D>();
    }
    //métodos private somente nossa classe pode acessar
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Clicou");
            //chama o método impulsionar
            //o this serve para indicar que é o objeto ativo naquele momento que recerá ação
            this.Impulsionar();
        }
    }
    //método que impulsiona nosso pássaro
    private void Impulsionar()
    {
        //zera a velocidade antes de dar o impulso
        this.fisica.velocity = Vector2.zero;
        //adiciona a variável física e o método AddForce, adicionando uma força para cima do tipo impulso
        this.fisica.AddForce(Vector2.up * 3, ForceMode2D.Impulse);
    }
    private void OnCollisionEnter2D(Collision2D colision)
    {
        this.fisica.simulated = false;
    }
}