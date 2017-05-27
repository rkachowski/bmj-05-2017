using UnityEngine;

public class KeepInScreen : MonoBehaviour
{
    void Update()
    {
         Vector3 pos = Camera.main.WorldToViewportPoint(transform.position);
         pos.x = Mathf.Clamp01(pos.x);
         pos.y = Mathf.Clamp01(pos.y);
         transform.position = Camera.main.ViewportToWorldPoint(pos);
    }
}