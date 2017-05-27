using UnityEngine;

public class Lazer : MonoBehaviour
{
    private SpriteRenderer _renderer;
    public Sprite active;
    public Sprite inactive;
    /// <summary>
    /// Start is called on the frame when a script is enabled just before
    /// any of the Update methods is called the first time.
    /// </summary>
    void Start()
    {
        _renderer = GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        if( Input.GetKey("space"))
        {
            
            if(_renderer.sprite != active) _renderer.sprite = active;
 
            if(Random.value > 0.5)
            {
                Vector3 cs = this.gameObject.transform.localScale;
                this.gameObject.transform.localScale = new Vector3(cs.x * -1,cs.y, cs.z);
            }
        }
        else
        {
            if(_renderer.sprite != inactive) _renderer.sprite = inactive;
        }
    }
    void OnCollisionEnter2D(Collision2D coll) 
    {
        if(_renderer.sprite == active)
        {
            if(coll.gameObject.tag == "zappable")
            {
                Destroy(coll.gameObject);
            }
        }
    }
}