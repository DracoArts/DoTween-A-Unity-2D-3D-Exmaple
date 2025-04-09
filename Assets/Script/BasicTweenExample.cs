using DG.Tweening;
using UnityEngine;

public class BasicTweenExample : MonoBehaviour
{
    
public Transform _transform;
    public void Move()
    {
        _transform.DOMove(new Vector3(5, 0, 0), 2f);
    
    }
    public void Rotate()
    {
        _transform.DORotate(new Vector3(0, 180, 0), 3f).SetDelay(0.5f);
    }

    public void Scale()
    {
        _transform.DOScale(Vector3.one * 2, 0.5f)
            .SetLoops(4, LoopType.Yoyo)
            .SetEase(Ease.InOutSine);

    }

}
