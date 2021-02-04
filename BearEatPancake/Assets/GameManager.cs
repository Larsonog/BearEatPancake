using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static GameManager Instance { get; private set; }
    private int score = 0;
    public TextMeshProUGUI scoreText;

    private void Awake()
    {
       if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        } else
        {
            Destroy(gameObject);
        }
    }
    public void IncScore(int ds)
    {
        score += ds;
        scoreText.text = "Score: " + score;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
