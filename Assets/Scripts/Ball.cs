using UnityEngine;
using System;
using System.Collections.Generic;
using Random = UnityEngine.Random;

public class Ball : MonoBehaviour
{
    [SerializeField] public Colors ballColor = Colors.None;
    [SerializeField] private Color[] colors;
    [SerializeField] private Renderer renderer;

    private void Awake()
    {
        renderer = GetComponent<Renderer>();
    }

    void Update()
    {
        //RandomColor();
    }

    private void Start()
    {
        RandomColor();
    }


    [ContextMenu("RandomColor")]
    public void RandomColor()
    {
        int enumMax = Enum.GetValues(typeof(Colors)).Length;
        //Debug.Log(enumMax.ToString());


        var random = UnityEngine.Random.Range(0, enumMax);
        //Debug.Log(random.ToString());
        
        ballColor = (Colors)random;
        //Debug.Log(ballColor.ToString());
        
        renderer.material.color = colors[(int) ballColor];
    }
    
}


public enum Colors
{
    None = -1,
    Red = 0,
    Blue = 1,
    Green = 2,
    Yellow = 3
}
