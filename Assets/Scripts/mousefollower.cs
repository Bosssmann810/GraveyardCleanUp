using UnityEngine;
using UnityEngine.InputSystem;
public class mousefollower : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {
        transform.position = Input.mousePosition;
    }
}
