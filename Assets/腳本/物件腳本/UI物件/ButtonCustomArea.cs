using UnityEngine;
using UnityEngine.UI;

public class ButtonCustomArea : MonoBehaviour
{
    [Header("�i���ϰ�z����")]
    public float _touchedAlpha = 0.2f;

    private void Start()
    {
        GetComponent<Image>().alphaHitTestMinimumThreshold = _touchedAlpha;
    }
}