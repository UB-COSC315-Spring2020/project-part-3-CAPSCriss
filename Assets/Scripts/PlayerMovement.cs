using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public Transform playerBody;

    public float moveSpeed = 5f;
    public float shootDamage = 20f;

    private Vector3 moveInput;
    private Vector3 mouseInput;

    public float mouseSensitivity = 1f;
    public Camera viewCam;

    public RawImage miniMap;
    public Image mapBckg;
    public bool mapOn;

    private void Awake()
    {
        LockCursor();
    }

    void Start()
    {
        miniMap.enabled = false;
        mapBckg.enabled = false;
        mapOn = false;
    }

    // Update is called once per frame
    void Update()
    {

        //Player movement, keyboard input
       if(Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector3(0, 0, moveSpeed * Time.deltaTime));
        }
       else if(Input.GetKey(KeyCode.A))
        {
            transform.Translate(new Vector3(-moveSpeed * Time.deltaTime, 0, 0));
            //playerRigid.MoveRotation(playerRigid.rotation * Quaternion.Euler(new Vector3(Input.GetAxis("x") * mouseSensitivity, 0, 0)));
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector3(0, 0, -moveSpeed * Time.deltaTime));
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector3(moveSpeed * Time.deltaTime, 0, 0));
            //playerRigid.MoveRotation(playerRigid.rotation * Quaternion.Euler(new Vector3(Input.GetAxis("x") * mouseSensitivity, 0, 0)));
        }

       //MiniMap
        if (Input.GetKeyDown(KeyCode.M))    
        {
            if (mapOn == false)
            {
                miniMap.enabled = true;
                mapBckg.enabled = true;
                mapOn = true;
            }
            else if (mapOn == true)
            {
                miniMap.enabled = false;
                mapBckg.enabled = false;
                mapOn = false;
            }
        }

        //Player view, mouse movement

        //mouseInput = new Vector3(Input.GetAxisRaw("Mouse X") * mouseSensitivity, Input.GetAxisRaw("Mouse Y") * mouseSensitivity, 0);
        //transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x - mouseInput.y, transform.rotation.eulerAngles.y + mouseInput.x, transform.rotation.eulerAngles.z);
        //viewCam.transform.localRotation = Quaternion.Euler(viewCam.transform.localRotation.eulerAngles + new Vector3(0f, mouseInput.y, 0f));
        //playerRigid.MoveRotation(playerRigid.rotation * Quaternion.Euler(new Vector3(0, Input.GetAxisRaw("Mouse X") * mouseSensitivity, 0)));

        CameraRotation();

        //Shooting
        if (Input.GetButtonDown("Fire1"))
        {
            Ray ray = viewCam.ViewportPointToRay(new Vector3(.5f, .5f, 0f));
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit) && PlayerStats.playerAmmo > 0)
            {
                EnemyScript enemy = hit.transform.GetComponent<EnemyScript>();
                Debug.Log("I'm looking at " + hit.transform.name);
                enemy.TakeDamage(shootDamage);
                PlayerStats.playerAmmo --;
            }
            else
            {
                Debug.Log("I'm looking at nothing");
            }
        }
    }

    private void LockCursor()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void CameraRotation()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;

        playerBody.Rotate(Vector3.up * mouseX);
    }

}
