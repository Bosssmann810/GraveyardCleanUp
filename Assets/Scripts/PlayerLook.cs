using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerLook : MonoBehaviour
{
    private float rayCastDepth = 100f;
    private LayerMask mask;
    public Transform m_transform;

    private void Start()
    {
        mask = LayerMask.GetMask("Ground");
    }
    public void LookAtMouse()
    {
        Vector3 mousePos = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
        float angleRadian = Mathf.Atan2(mousePos.y - transform.position.y, mousePos.x - transform.position.x);
        float angleDegree = (180 /  Mathf.PI) * angleRadian -90;
        transform.rotation = Quaternion.Euler(0f, 0f, angleDegree);
        Debug.DrawLine(transform.position, mousePos, Color.red, Time.deltaTime);
    }
    private void Update()
    {
        LookAtMouse();
    }
}
