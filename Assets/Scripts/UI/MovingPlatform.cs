using System.Collections;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    [Header("이동 설정")]
    public Transform pointA;
    public Transform pointB;
    public float moveDuration = 2f;
    public float waitTime = 1f;

    private Vector3 previousPosition;
    public Vector3 PlatformDelta { get; private set; }

    private Rigidbody platformRigidbody;

    private void Awake()
    {
        platformRigidbody = GetComponent<Rigidbody>();
    }


    private void Start()
    {
        previousPosition = transform.position;
        StartCoroutine(MovePlatform());
    }

    private void FixedUpdate()
    {
        PlatformDelta = transform.position - previousPosition;
        previousPosition = transform.position;
    }

    private IEnumerator MovePlatform()
    {
        while (true)
        {
            yield return StartCoroutine(MoveTo(pointB.position));
            yield return new WaitForSeconds(waitTime);
            yield return StartCoroutine(MoveTo(pointA.position));
            yield return new WaitForSeconds(waitTime);
        }
    }

    private IEnumerator MoveTo(Vector3 targetPosition)
    {
        Vector3 startPos = transform.position;
        float elapsed = 0f;

        while (elapsed < moveDuration)
        {
            elapsed += Time.deltaTime;
            float t = elapsed / moveDuration;

            Vector3 nextPos = Vector3.Lerp(startPos, targetPosition, t);
            platformRigidbody.MovePosition(nextPos);

            yield return new WaitForFixedUpdate(); // 중요한 변경점
        }

        platformRigidbody.MovePosition(targetPosition);
    }

}
