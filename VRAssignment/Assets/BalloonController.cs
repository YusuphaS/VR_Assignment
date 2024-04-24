using UnityEngine;

public class BalloonController : MonoBehaviour
{
    void Update()
    {
        if (Input.GetButtonDown("XRI_Right_TriggerButton"))
        {
            Debug.Log("Trigger down");
        }
        else if
        (Input.GetButtonUp("XRI_Right_TriggerButton"))
        {
            Debug.Log("Trigger up");
        }
    }
}
