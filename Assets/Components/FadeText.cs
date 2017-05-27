using UnityEngine;

public class FadeText : MonoBehaviour
{
    public Sprite[] goodSprites;

    private SpriteRenderer _renderer;
    private float _startTime;
    public float duration = 1.5f;
    public float minimum = 0.0f;
    public float maximum = 0.6f;

    /// <summary>
    /// Start is called on the frame when a script is enabled just before
    /// any of the Update methods is called the first time.
    /// </summary>
    void Start()
    {
        _renderer = gameObject.GetComponent<SpriteRenderer>();    
        _renderer.sprite = Resources.Load<Sprite>("Sprites/ohno") as Sprite;
        _renderer.color = new Color(1f,1f,1f,maximum);     
        _startTime = Time.time;
    }
    /// <summary>
    /// Update is called every frame, if the MonoBehaviour is enabled.
    /// </summary>
    void Update()
    {
        float t = (Time.time - _startTime) / duration;  
        _renderer.color = new Color(1f,1f,1f,Mathf.SmoothStep(maximum, minimum, t));     

        if((Time.time - _startTime) > duration)
        {
            Destroy(this);
        }
    }
}