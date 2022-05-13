using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    // マウス感度
	public float mouseSensitivity;
    // 移動速度
    public float moveSpeed;
    // カメラの距離
    public float cameraDistance;
    // カメラの上下限
    public float limit;
    // カメラの高さ
    private float cameraHeight;
    // カメラ
    private GameObject mainCamera;
    
    private Rigidbody m_rigidbody;

    void Start() {
        // マウスの固定と非表示
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        // カメラオブジェクトの取得
        mainCamera = GameObject.FindGameObjectsWithTag("MainCamera")[0];
        // カメラの初期位置設定
        mainCamera.transform.position = transform.position - cameraDistance * transform.forward;
        mainCamera.transform.LookAt(transform.position);
        
        // コンポーネントの取得
        m_rigidbody = GetComponent<Rigidbody>();
    }

    void Update() {
        Move();
        CalcCamera();
    }

    void Move() {
        // 上下(WS)の大きさ取得
        float ver = Input.GetAxis("Vertical");
        // 左右(AD)の大きさ取得
        float hor = Input.GetAxis("Horizontal");

        if (hor != 0 || ver != 0) {
            // カメラに対して垂直，平行なベクトルの取得
            Vector3 forwardVec = transform.position - mainCamera.transform.position;
            forwardVec.y = 0;
            Vector3 sideVec = new Vector3(forwardVec.z, 0, -forwardVec.x);

            // 移動ベクトルの作成
            Vector3 moveVector = (ver * forwardVec + hor * sideVec) * Time.deltaTime * moveSpeed;
            transform.LookAt(transform.position + moveVector);

            // 上下の速度の保持
            moveVector.y = m_rigidbody.velocity.y;
            m_rigidbody.velocity = moveVector;
        }
    }

    void CalcCamera() {
		float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity;
		float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity;

        // 左右回転の量の計算
        Vector3 deferredPosition = (mainCamera.transform.position - transform.position);
        deferredPosition.y = 0;
        deferredPosition = deferredPosition.normalized;
        deferredPosition = Quaternion.Euler(0, 5000f * Time.deltaTime * mouseX, 0) * deferredPosition;

        // 上下回転の量の計算
        cameraHeight += mouseY;
        if (Mathf.Abs(cameraHeight) > limit) {
            cameraHeight = limit * Mathf.Sign(cameraHeight);
        }

        // カメラの位置決定
        Vector3 addCameraVec = deferredPosition + cameraHeight * transform.up;
        mainCamera.transform.position = transform.position + addCameraVec.normalized * cameraDistance;
        mainCamera.transform.LookAt(transform.position);
    }
}
