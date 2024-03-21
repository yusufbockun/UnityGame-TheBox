using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SliderDrag : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IDragHandler
{
    private Slider slider;
    private bool isDragging = false;

    void Start()
    {
        // Slider bile�enini al
        slider = GetComponent<Slider>();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        // Slider'a fare t�kland���nda s�r�kleme i�lemini ba�lat
        isDragging = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        // Slider'dan fare b�rak�ld���nda s�r�kleme i�lemini durdur
        isDragging = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        // Slider'a fare s�r�klendi�inde, s�r�klenen mesafeye g�re de�eri g�ncelle
        if (isDragging)
        {
            float normalizedValue = Mathf.InverseLerp(0, Screen.width, eventData.position.x);
            slider.value = Mathf.Clamp01(normalizedValue);
        }
    }
}
