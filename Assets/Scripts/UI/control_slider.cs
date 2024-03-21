using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SliderDrag : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IDragHandler
{
    private Slider slider;
    private bool isDragging = false;

    void Start()
    {
        // Slider bileþenini al
        slider = GetComponent<Slider>();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        // Slider'a fare týklandýðýnda sürükleme iþlemini baþlat
        isDragging = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        // Slider'dan fare býrakýldýðýnda sürükleme iþlemini durdur
        isDragging = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        // Slider'a fare sürüklendiðinde, sürüklenen mesafeye göre deðeri güncelle
        if (isDragging)
        {
            float normalizedValue = Mathf.InverseLerp(0, Screen.width, eventData.position.x);
            slider.value = Mathf.Clamp01(normalizedValue);
        }
    }
}
