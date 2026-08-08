using UnityEngine;
using TMPro;
using System;
using Unity.VisualScripting;

public class UIManager: MonoBehaviour
{
    [SerializeField]
    private TMP_Text notiText;

    [SerializeField]
    private GameObject restartButton;

    [SerializeField]
    private Player player;

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

    public void RestartGame()
    {
        player.transform.position = new Vector3(0f, 88f, -85f);
        player.HP = 100;
        ShowNotiText("Restart");
        Time.timeScale = 1f;
        UIManager.instance.ShowHideRestartButton(false);

    }

    public void ShowHideRestartButton(bool flag)
    {
        restartButton.SetActive(flag);
    }

}
