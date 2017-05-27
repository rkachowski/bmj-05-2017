using UnityEngine;
using System;

public class Game : MonoBehaviour
{

    public GameObject enemyPrefab;
    public GameObject fadeText;
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
        AddTarget(-2.55f,-4.21f);
    }

    void OnDestroyed(object destroyed, EventArgs e)
    {  
        Vector3 position = ((GameObject)(destroyed)).transform.position;
        Instantiate(fadeText, position, Quaternion.identity);

        AddTarget(-16.8f,(float)(UnityEngine.Random.value * 4 - 2.5));
    }

    void AddTarget(float x, float y)
    {
        GameObject newEnemy = Instantiate(enemyPrefab, new Vector3(x,y,0), Quaternion.identity);

        Killable k_enemy = newEnemy.GetComponent<Killable>();
        k_enemy.OnDestroyed += OnDestroyed;
    }
}
