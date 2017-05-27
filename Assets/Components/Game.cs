using UnityEngine;
using System;
using UnityEngine.UI;

public class Game : MonoBehaviour
{

    public GameObject enemyPrefab;
    public GameObject fadeText;
    public Text scoreCounter;
    private int score = 0;

    
    /// <summary>
    /// Update is called every frame, if the MonoBehaviour is enabled.
    /// </summary>
    void Update()
    {
        //add enemies n stuff 
    }

    /// <summary>
    /// Start is called on the frame when a script is enabled just before
    /// any of the Update methods is called the first time.
    /// </summary>
    void Start()
    {
        foreach(var gameObject in GameObject.FindGameObjectsWithTag("zappable"))
        {
            Destroy(gameObject);
        }

        score = 0;
        scoreCounter.text = score.ToString();
        
        AddTarget(-17.33f,-3.04f);

        Debug.Log(Camera.current.aspect);
    }

    void OnDestroyed(object destroyed, EventArgs e)
    {  
        Vector3 position = ((GameObject)(destroyed)).transform.position;
        Instantiate(fadeText, position, Quaternion.identity);

        score++;
        scoreCounter.text = score.ToString();

        AddTarget(-16.8f,(float)(UnityEngine.Random.value * 4 - 2.5));
    }

    void AddTarget(float x, float y)
    {
        GameObject newEnemy = Instantiate(enemyPrefab, new Vector3(x,y,0), Quaternion.identity);

        Killable k_enemy = newEnemy.GetComponent<Killable>();
        k_enemy.OnDestroyed += OnDestroyed;
    }
}
