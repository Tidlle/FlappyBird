using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
  


    public void Jogar()
    {
        SceneManager.LoadScene("SetPersonagem");
    }
}
