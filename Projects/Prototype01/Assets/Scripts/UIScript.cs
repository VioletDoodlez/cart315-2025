using System;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class UIScript : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI _livesTxt;

    [SerializeField]
    private PlayerScript _playerRef;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        _livesTxt.text = $"Lives: {_playerRef.Lives}";
    }
}
