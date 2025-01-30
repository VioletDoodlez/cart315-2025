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
        Player.OnPlayerHit += UpdateLives;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void UpdateLives() {
        _livesTxt.text = "Lives: " + _playerRef.Lives;
    }
}
