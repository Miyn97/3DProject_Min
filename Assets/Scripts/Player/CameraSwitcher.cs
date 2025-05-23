using UnityEngine;
using UnityEngine.UI;

public class CameraSwitcher : MonoBehaviour
{
    public Camera mainCamera;
    public Camera subCamera;
    public Text switchHintText;

    private bool isMainCameraActive = true;

    void Start()
    {
        mainCamera.enabled = true;
        subCamera.enabled = false;

        if (switchHintText != null)
            switchHintText.text = "V: 시점 전환";
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            isMainCameraActive = !isMainCameraActive;
            mainCamera.enabled = isMainCameraActive;
            subCamera.enabled = !isMainCameraActive;
        }
    }
}
