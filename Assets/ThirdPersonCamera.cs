using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour
{
    // Configuración
    [Header("Configuración")]
    [Tooltip("Sensibilidad de rotación del ratón.")]
    [SerializeField] private float m_mouseSensitivity = 200f;

    [Tooltip("Limites de rotación vertical (pitch) para evitar que la cámara se voltee.")]
    [SerializeField] private Vector2 m_pitchLimits = new Vector2(-40f, 80f);

    protected float m_yaw = 0f; // Rotación horizontal
    protected float m_pitch = 0f; // Rotación vertical

    
    [Header("Colisión")]
    [Tooltip("Las capas con las que la cámara colisionará.")]
    [SerializeField] private LayerMask m_collisionMask;

    [Tooltip("Distancia a la que la cámara se mantendrá del objeto con el que colisiona.")]
    [SerializeField] private float m_collisionBuffer = 0.2f;

    [SerializeField] private float m_cameraPositionLerpSpeed = 5f;

    // variables privadas
    private Transform cameraTransform;
    private float _targetDistance;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        cameraTransform = transform.GetChild(0);
        _targetDistance = cameraTransform.localPosition.z;
    }

    private void LateUpdate()
    {
        HandleRotation();
        HandleCollisions(); 
    }

    private void HandleRotation()
    {
        float mouseX = Input.GetAxis("Mouse X") * m_mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * m_mouseSensitivity * Time.deltaTime;

        m_yaw += mouseX;
        m_pitch -= mouseY; 
        m_pitch = Mathf.Clamp(m_pitch, m_pitchLimits.x, m_pitchLimits.y);

        transform.parent.Rotate(Vector3.up * mouseX); // Rotar el jugador horizontalmente
        transform.localRotation = Quaternion.Euler(m_pitch, 0f, 0f);
    }
    private void HandleCollisions()
    {
        Vector3 desiredPosition = transform.TransformPoint(new Vector3(0, 0, _targetDistance));
        RaycastHit hit;

        if (Physics.Linecast(transform.position, desiredPosition, out hit, m_collisionMask))
        {
            desiredPosition = hit.point + hit.normal * m_collisionBuffer;
        }

        cameraTransform.position = Vector3.Lerp(cameraTransform.position, desiredPosition, Time.deltaTime * m_cameraPositionLerpSpeed);
    }
}

