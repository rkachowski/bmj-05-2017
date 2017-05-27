using UnityEngine;
using System;

public class Killable : MonoBehaviour
{
    public event EventHandler OnDestroyed; 

    /// <summary>
    /// This function is called when the MonoBehaviour will be destroyed.
    /// </summary>
    void OnDestroy()
    {
        if(OnDestroyed != null)
        {
            OnDestroyed(gameObject, null);
        }   
    }
}