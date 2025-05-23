using UnityEngine;

public class JumpZone : MonoBehaviour, IInteractable
{
    [SerializeField] private float jumpForce = 300f;

    private void OnTriggerEnter(Collider other)
    {
        if (!other.TryGetComponent(out Rigidbody rb)) return;

        // ���� �ӵ� �ʱ�ȭ �� ���� ����
        rb.velocity = new Vector3(rb.velocity.x, 0f, rb.velocity.z);
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }

    // IInteractable ����: ������ �ý��۰� �����ϰ� ����
    public string GetInteractPrompt()
    {
        return "�������Դϴ�!\n�ö󰡸� �ڵ����� �����˴ϴ�.";
    }

    public void OnInteract()
    {
        // ������� FŰ ��ȣ�ۿ��� �ʿ� �����Ƿ� ����θ� �˴ϴ�.
        //Debug.Log("������� F Ű ���� �ڵ� �۵��մϴ�.");
    }

}
