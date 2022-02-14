using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Box : MonoBehaviour
{
   
    [SerializeField] private SpriteRenderer open;
    [SerializeField] private SpriteRenderer close;
  
    public UnityEvent openEvent;
    public UnityEvent closeEvent;

    void Start()
    {
        open.enabled = false;
        close.enabled = true;  
    }

    public void Open()
    {
        openEvent?.Invoke();
        open.enabled = true;
        close.enabled = false;
    }

    public void Close()
    {
        closeEvent?.Invoke();
        open.enabled = false;
        close.enabled = true;
    }
}
