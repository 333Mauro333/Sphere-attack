using UnityEngine;


namespace SphereAttack
{
    public class RotationMovement : MonoBehaviour
    {
        [Header("Configuration")]
        [SerializeField] string rotationAxisName = null;

        [Header("References")]
        [SerializeField] Camera camera = null;

        [Header("Values")]
        [Range(0.0f, 300.0f)]
        [SerializeField] float rotationSpeed = 0.0f;

        [Space(10)]

        [Range(0.0f, 90.0f)]
        [SerializeField] float cameraRotation = 0.0f;
        [SerializeField] float cameraPositionY = 0.0f;
        [SerializeField] float cameraDistance = 0.0f;



		void Update()
        {
            Movement();

            if (camera != null)
			{
                CameraMovement();
            }
        }


        void Movement()
		{
            float axisSpeed = Input.GetAxis(rotationAxisName);


            Vector3 rotation = new Vector3(0.0f, axisSpeed * rotationSpeed * Time.deltaTime, 0.0f);

            transform.Rotate(rotation);
        }
        void CameraMovement()
		{
            Vector3 angleToRotate = new Vector3(cameraRotation, 0.0f, 0.0f);
            Vector3 cameraPositionDiff = new Vector3(0.0f, cameraPositionY, 0.0f);


            camera.transform.rotation = transform.rotation;
            camera.transform.rotation *= Quaternion.Euler(angleToRotate);

            camera.transform.position = transform.position + cameraPositionDiff;
            camera.transform.position += transform.forward * -cameraDistance;
        }
    }
}
