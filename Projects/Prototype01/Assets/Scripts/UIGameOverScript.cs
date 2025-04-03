using System;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class UIGameOverScript : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI _gameoverTxt;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        _gameoverTxt.text = "GAME OVER";
    }
}
