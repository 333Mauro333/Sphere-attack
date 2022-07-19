using UnityEngine;


namespace SphereAttack
{
    public class RotationMovement : MonoBehaviour
    {
        [Header("Configuration")]
        [SerializeField] string rotationAxisName = null;

        [Header("Values")]
        [SerializeField] float speed = 0.0f;



        void Update()
        {
            float axisSpeed = Input.GetAxis(rotationAxisName);


            Vector3 rotation = new Vector3(0.0f, axisSpeed * speed * Time.deltaTime, 0.0f);

            transform.Rotate(rotation);
        }
    }
}
