using DG.Tweening;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

public class UITweenExample : MonoBehaviour
{
    public CanvasGroup panel;
    public Button button;

    void Start()
    {
       
        button.onClick.AddListener(() =>
        {
            panel.transform.DOMoveX(Screen.width, 3f)
                .SetEase(Ease.InBack)
                .OnComplete(() => panel.gameObject.SetActive(false));
        });
    }
  public void Fade(){

    panel.DOFade(1, 3f).From(0); 
  }
}