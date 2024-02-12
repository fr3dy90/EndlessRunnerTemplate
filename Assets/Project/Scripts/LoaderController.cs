
using UnityEngine;
using UnityEngine.UI;

public class LoaderController : MonoBehaviour
{
    public static LoaderController Instance;
    [SerializeField] private CanvasGroup canvasGroup;
    [SerializeField] private Image loaderImage;
    [SerializeField] private Sprite[] sprites;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this);
        }
    }

    public void Loader(bool isActive, int indexSprite, int initialAlpha)
    {
        canvasGroup.alpha = initialAlpha;
        int endAlpha = initialAlpha == 1 ? 0 : 1;
        canvasGroup.gameObject.SetActive(isActive);
        loaderImage.sprite = sprites[indexSprite];
    }
}