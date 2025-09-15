using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class Rock : MonoBehaviour
{
    public float Offset = 10f;
    public float FloatDuration = 2.5f;
    public Ease Ease = Ease.OutQuart;
    
    // Start is called before the first frame update
    void OnEnable()
    {
        var endPosition = gameObject.transform.position;
        
        var startPosition = endPosition;
        startPosition.y -= Offset;

        transform.position = startPosition;
        gameObject.transform.DOMoveY(endPosition.y, FloatDuration).SetEase(Ease);
    }
}
