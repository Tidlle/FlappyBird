using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class GameModeController : MonoBehaviour
{
    private UIDocument _document;
    private Button Jessie;
    private Button Marc;

    private void Awake()
    {
        _document = GetComponent<UIDocument>();
        Marc = _document.rootVisualElement.Q<Button>("btnMarc");
        Marc.RegisterCallback<ClickEvent>(OnPlayGameClickMarc);

        Jessie = _document.rootVisualElement.Q<Button>("btnJessie");
        Jessie.RegisterCallback<ClickEvent>(OnPlayGameClickJessie);
    }
   

    private void OnPlayGameClickMarc(ClickEvent evt)
    {
        SceneManager.LoadScene("GameMarc");
    }
    private void OnPlayGameClickJessie(ClickEvent evt)
    {
        SceneManager.LoadScene("GameJessie");
    }
}