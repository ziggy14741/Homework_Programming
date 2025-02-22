using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
private Camera _camera;

    private string _Cameraname = "Game_Camera";

    private Vector3 _positionMouse;

    private void Start()
    {
        _camera = GameObject.Find(_Cameraname).GetComponent<Camera>();

    }
    private void Update()
    {
        _positionMouse = _camera.ScreenToWorldPoint(Input.mousePosition);

        Vector3 pos = _positionMouse - transform.position;

        float rotZ = Mathf.Atan2(pos.y, pos.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(0, 0, rotZ - 90);
    }
}
