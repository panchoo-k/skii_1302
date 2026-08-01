using UnityEngine;
using TMPro;
using System;

public class UIManager: MonoBehaviour
{
    [SerializeField]
    private TMP_Text notiText;

    public static UIManager instance;

    void Awake()
    {
        instance = this;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowNotiText(String s)
    {
        notiText.text = s;
    }

}
