using UnityEngine;

public class JumpZone : MonoBehaviour, IInteractable
{
    [SerializeField] private float jumpForce = 300f;

    private void OnTriggerEnter(Collider other)
    {
        if (!other.TryGetComponent(out Rigidbody rb)) return;

        // 수직 속도 초기화 후 위로 점프
        rb.velocity = new Vector3(rb.velocity.x, 0f, rb.velocity.z);
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }

    // IInteractable 구현: 아이템 시스템과 동일하게 대응
    public string GetInteractPrompt()
    {
        return "점프대입니다!\n올라가면 자동으로 점프됩니다.";
    }

    public void OnInteract()
    {
        // 점프대는 F키 상호작용이 필요 없으므로 비워두면 됩니다.
        //Debug.Log("점프대는 F 키 없이 자동 작동합니다.");
    }

}
