﻿using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    [SerializeField]
    private int _max = 1000;
    [SerializeField]
    private int _min = 1;
    [SerializeField]
    private int _ourGuess = 500; 

    void Start()
    {
        _max += 1;
        Debug.Log("Selamat datang ke Setau Gaban.");
        Debug.Log("Cuba pilih numbur lapas tu jangan bagi tau...");
        Debug.Log($"Numbur paling basar: {_max}");
        Debug.Log($"Numbur paling damit: {_min}");
        Debug.Log($"Bagi tau kalau numbur mu lagi basar atau damit dari {_ourGuess}");
        Debug.Log("Takan arrow atas = lagi basar. Takan arrow bawah = lagi damit. Takan enter = enggam!");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("Lagi Basar");
            _min = _ourGuess;
            _ourGuess = (_max + _min) / 2;
            Debug.Log($"Okay, lagi basar atau damit dari {_ourGuess}");
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("Lagi Damit");
            _max = _ourGuess;
            _ourGuess = (_max + _min) / 2;
            Debug.Log($"Okay, lagi basar atau damit dari {_ourGuess}");
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Enggam!");
        }
    }
}
