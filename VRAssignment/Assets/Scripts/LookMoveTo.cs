using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using TMPro;

public class LookMoveTo : MonoBehaviour
{
    public GameObject ground;
    private Transform camera;
    public Transform infobubble;
    private TMP_Text infotext;

    void Start()
    {
        camera = Camera.main.transform;
        if (infobubble != null)
        {
            infotext = GetComponentInChildren<TMP_Text>();
        }
    }


    void Update()
    {
        Ray ray;
        RaycastHit[] hits;
        GameObject hitObject;

        Debug.DrawRay(camera.position, camera.rotation *
        Vector3.forward * 100.0f);

        ray = new Ray(camera.position, camera.rotation *
        Vector3.forward);
        hits = Physics.RaycastAll(ray);
        for (int i = 0; i < hits.Length; i++)
        {
            RaycastHit hit = hits[i];
            hitObject = hit.collider.gameObject; if (hitObject == ground)
            {
                if (infobubble != null)
                {
                    infotext.text = "X:" + hit.point.x.ToString("F2") + "," + "Z:" + hit.point.z.ToString("F2");
                    infobubble.LookAt(camera.position);
                    infobubble.Rotate(0, 180f, 0);
                }
                transform.position = hit.point;
               
            }
        }

    }
}

