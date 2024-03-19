using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public Transform target;
    public float distance = 5.0f; // ī�޶�� ĳ���� ������ �Ÿ�
    public float height = 2.0f; // ī�޶��� ����
    public float sensitivity = 5.0f;
    float xX = 0.0f;
    float yY = 0.0f;
    void LateUpdate()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");
        xX += mouseX * sensitivity;
        yY -= mouseY * sensitivity;
        yY = Mathf.Clamp(yY, -90f, 90f);

        Vector3 offset = new Vector3(0,height,-distance);
        Quaternion rotation = Quaternion.Euler(yY,xX,0);
        transform.position = target.position + rotation * offset;

        transform.LookAt(target.position + Vector3.up * height);
    }
}
