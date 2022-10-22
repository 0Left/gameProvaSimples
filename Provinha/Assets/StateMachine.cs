using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine : MonoBehaviour
{
    
    [SerializeField] public List<Porta> portas = new List<Porta>();

    void Start()
    {
        callMe();
    }
    private void callMe()
    {
        foreach (var porta in portas)
        {
            Debug.Log("this: " + porta.pergunta.questionHeader);
        }
    }
}
[System.Serializable]
public class Porta
{
    public Pergunta pergunta;
    public int pontosMinimos;
    public int pontosRecebidos;
    [System.NonSerialized] public bool fuiRespondida;

    public bool verificarRespostaCerta(int resposta)
    {
        return (resposta == pergunta.respostaCerta ? true : false);
    }
}
[System.Serializable]
public class Pergunta
{
    private const int MaxLength = 30; // for example
    public string questionHeader;
    [TextArea]public string questionBody;
    public string resposta1;
    public string resposta2;
    public string resposta3;

    [Range(1,3)] public int respostaCerta;
}