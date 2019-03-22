using UnityEngine;
using System.Collections;

public class Camera : MonoBehaviour
{
    private float posX;
    public bool followX;
    private float velocityX = 0;
    public float smoothTimeX;
    public float offsetX;

    private float posY;
    public bool followY;
    private float velocityY = 0;
    public float smoothTimeY;
    public float offsetY;

    public float minY, maxY;

    public Transform targetTransform;

    // Use this for initialization
    void Start()
    {
        posX = transform.position.x;
        posY = 5;

        if (followX)
        {
            posX = targetTransform.position.x + offsetX;
        }
        transform.position = new Vector3(posX, 5, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        if (followX)
        {
            posX = Mathf.SmoothDamp(posX, targetTransform.position.x + offsetX, ref velocityX, smoothTimeX);
        }
        else
        {
            posX = transform.position.x;
        }

        transform.position = new Vector3(posX, 4.6f, transform.position.z);

    }
}
