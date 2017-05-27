using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    public static float baseSpeed = 0.01f;
    public static float increment = 0.003f;

    /// <summary>
    /// Start is called on the frame when a script is enabled just before
    /// any of the Update methods is called the first time.
    /// </summary>
    void Start()
    {
        baseSpeed += increment;
    }
    
    /// <summary>
    /// Update is called every frame, if the MonoBehaviour is enabled.
    /// </summary>
    void Update()
    {
        gameObject.transform.position += new Vector3(baseSpeed + (baseSpeed * Random.value),0,0);   
    }
}