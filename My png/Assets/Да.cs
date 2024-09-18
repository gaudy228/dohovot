using UnityEngine;

public class Да : MonoBehaviour
{
    public float speed;
    public float FrameSpeed;
    private Rigidbody rb;
    public Transform enemy;
    private Vector3 enemyPoint;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 moveInput = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        enemyPoint = enemy.position;
        rb.velocity = moveInput * speed;
        if (Input.GetKey(KeyCode.LeftShift))
        {
            transform.LookAt(enemyPoint);
        }
        if (!Input.GetKey(KeyCode.LeftShift) && moveInput.magnitude > 0.1f)
        {
            Quaternion rotation = Quaternion.LookRotation(moveInput);
            rotation.x = 0;
            rotation.z = 0;
            transform.rotation = Quaternion.Lerp(transform.rotation, rotation, FrameSpeed * Time.deltaTime);
        }
       




    }
    private void OnTriggerEnter(Collider other)
    {
        
    }
}
