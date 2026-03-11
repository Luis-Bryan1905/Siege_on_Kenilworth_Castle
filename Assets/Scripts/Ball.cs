using System;
using System.Collections;
using UnityEngine;

public class Ball : MonoBehaviour
{
    // base: https://www.youtube.com/watch?v=VOEtOGmHoeE

    public bool IsPressed;

    public bool active = true;

    public float lifeSpan;

    private float ReleaseDelay;

    public float maxX = 10.0f; // Maximum distance the camera can be from the target
    public float minY = 1.5f; // Minimum distance the camera can be from the target
    public float maxY = 10.0f; // Minimum distance the camera can be from the target

    private Rigidbody rb;
    private SpringJoint sj;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        sj = GetComponent<SpringJoint>();

        ReleaseDelay = 1 / (sj.massScale * 4);
    }

    private void FixedUpdate()
    {
        if (IsPressed && active)
        {
            DragBall();
        }
    }

    private void DragBall()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = Camera.main.WorldToScreenPoint(transform.position).z;

        Vector3 worldPos = Camera.main.ScreenToWorldPoint(mousePos);

        // Clamp X and Y
        worldPos.x = Mathf.Clamp(worldPos.x, -maxX, maxX);
        worldPos.y = Mathf.Clamp(worldPos.y, minY, maxY);
        rb.MovePosition(worldPos);

            
    }

    private void OnMouseDown()
    {
        Debug.Log("Mouse DOWN on sphere");
        IsPressed = true;
        rb.isKinematic = true;
    }

    private void OnMouseUp()
    {
        IsPressed = false;
        rb.isKinematic = false;
        StartCoroutine(Release());
    }

    private IEnumerator Release()
    {
        yield return new WaitForSeconds(ReleaseDelay);
        sj.spring = 0;
        active = false;
        StartCoroutine(Destroy());
    }

    private IEnumerator Destroy()
    {
        yield return new WaitForSeconds(lifeSpan);
        Destroy(gameObject);
    }

    }
