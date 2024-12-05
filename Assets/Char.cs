using System;
using UnityEngine;
using UnityEngine.UI;

public class Char : MonoBehaviour
{
    [SerializeField] private Colors charColor = Colors.None;
    [SerializeField] private Color[] colors;
    [SerializeField] private Renderer renderer;

    public Text Point;
    public static int score = 0;
    
    int CurrentColor = 0;

    private void Awake()
    {
        renderer = GetComponent<Renderer>();

    }

    private void SetColor()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            charColor = Colors.Red;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            
            charColor = Colors.Blue;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            
            charColor = Colors.Green;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            
            charColor = Colors.Yellow;
        }

        if (charColor != Colors.None)
        {
            renderer.material.color = colors[(int)charColor];
        }
    }
    void Update()
    {
        SetColor();
        Point.text = "Score: " + score.ToString();
        
    }

    public void OnCollisionEnter(Collision other)
    {
        try
        {
            var ball = other.transform.GetComponent<Ball>();
            if (ball.ballColor == charColor)
            {
                score++;
            }
            else
            {
                score--;
            }
            Destroy(other.gameObject);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }
}
