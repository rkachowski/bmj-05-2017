using UnityEngine;

public class Lazer : MonoBehaviour
{
    /// <summary>
    /// Update is called every frame, if the MonoBehaviour is enabled.
    /// </summary>
    void Update()
    {
        if( Input.GetKey("space"))
        {
            if(Random.value > 0.5)
            {
                Vector3 cs = this.gameObject.transform.localScale;
                this.gameObject.transform.localScale = new Vector3(cs.x * -1,cs.y, cs.z);
            }
        }
    }
}