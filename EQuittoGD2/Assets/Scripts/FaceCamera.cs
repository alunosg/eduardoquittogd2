using UnityEngine;

public class FaceCamera : MonoBehaviour
{
    public float baseScale = 0.1f;
    public Camera MainCamera;
    public Vector3 startScale;

    void Start()
    {
        MainCamera = Camera.main;
        startScale = transform.localScale;
    }

    void Update()
    {
        transform.rotation = MainCamera.transform.rotation;
        transform.localScale = startScale * (baseScale *
            Vector3.Distance(transform.position, transform.position));
    }
}
