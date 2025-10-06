using UnityEngine;

public class playercontroll : MonoBehaviour
{
    public Rigidbody rb;
    public float rapidez = 3;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float movimientoHorizontal = Input.GetAxis("Horizontal")*rapidez;
        rb.linearVelocity = new Vector3(movimientoHorizontal, rb.linearVelocity.y, rb.linearVelocity.z);
    }
}
