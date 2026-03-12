using UnityEngine;

public class AgentModel : MonoBehaviour
{
    [SerializeField] private PlayerView _agentController;
    [SerializeField] private float _velocidad = 20;
    [SerializeField] private Rigidbody _rb;

     public void Movimiento()
    {
        _rb.linearVelocity = new Vector3(_agentController.moveValue.x * _velocidad, _rb.linearVelocity.y, _agentController.moveValue.y * _velocidad);
    }
     
    void Update()
    {
        Movimiento(); 
    }
}
