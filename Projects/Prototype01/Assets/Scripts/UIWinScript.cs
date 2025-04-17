using System;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class UIWinScript : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI _winTxt;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        _winTxt.text = "YOU WIN!";
    }
}
