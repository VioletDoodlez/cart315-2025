using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    [SerializeField]
    public TextMeshProUGUI _titleTxt;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _titleTxt.text = "GAME OVER";
    }

    // Update is called once per frame
    void Update()
    {
        _titleTxt.text = "GAME OVER";
    }
}
