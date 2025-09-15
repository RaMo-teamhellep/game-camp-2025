using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class PlatformMove : MonoBehaviour
{
    public float Height = 10f;
    public float Duration = 5f;
    public Ease Ease = Ease.InOutQuad;

    private Vector3 _startPosition;
    private Vector3 _endPosition;
    
    // Start is called before the first frame update
    void Start()
    {
        _startPosition = transform.position;
        _endPosition = _startPosition;
        _endPosition.y += Height;
        MoveUp();
    }

    private void MoveUp()
    {
        transform.DOMoveY(_endPosition.y, Duration)
            .SetEase(Ease)
            .OnComplete(MoveDown);
    }

    private void MoveDown()
    {
        transform.DOMoveY(_startPosition.y, Duration)
            .SetEase(Ease)
            .OnComplete(MoveUp);
    }
}
