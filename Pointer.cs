using UnityEngine;
using UnityPointer = UnityEngine.InputSystem.Pointer;

public static class Pointer
{
    public static Vector2 Position => UnityPointer.current.position.ReadValue();

    public static bool IsPressed => Input.GetMouseButton(0);

    public static Vector2 GetLocalPosition(RectTransform transform)
    {
        RectTransformUtility.ScreenPointToLocalPointInRectangle(transform, Position, null, out Vector2 position);
        return position;
    }

    public static Vector2 GetWorldPosition(RectTransform transform)
    {
        RectTransformUtility.ScreenPointToWorldPointInRectangle(transform, Position, null, out Vector3 position);
        return position;
    }
}
