// Used the following tutorial as a source:
// https://medium.com/nerd-for-tech/creating-collectables-unity-ccb59ea0c191
using System;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UI : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI _livesTxt;

    [SerializeField]
    private Player _playerRef;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //displays lives

        _livesTxt.text = $"Lives: {_playerRef.Lives}";
    }
}

    
