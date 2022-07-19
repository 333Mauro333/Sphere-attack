using UnityEngine;


namespace SphereAttack
{
    [RequireComponent(typeof(CharacterController))]
    public class FrontMovement : MonoBehaviour
    {
        [Header("Configuration")]
        [SerializeField] string frontAxisName = null;

        [Header("Values")]
        [SerializeField] float speed = 0.0f;


        CharacterController cc = null;



		void Awake()
		{
            cc = GetComponent<CharacterController>();
		}

		void FixedUpdate()
		{
            float axisSpeed = Input.GetAxis(frontAxisName);


            cc.Move(transform.forward * axisSpeed * speed * Time.deltaTime);
		}
	}
}
