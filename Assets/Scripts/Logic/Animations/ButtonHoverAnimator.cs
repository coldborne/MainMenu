using UnityEngine;
using UnityEngine.EventSystems;

[RequireComponent(typeof(Animator))]
public class ButtonHoverAnimator : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private readonly string IsHovered = nameof(IsHovered);
    
    private Animator _animator;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        _animator.SetBool(IsHovered, true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        _animator.SetBool(IsHovered, false);
    }
}
