
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickCharacterMove : MonoBehaviour
{
	public Vector2 speed = new Vector2(5f, 0f);
	bool mouseClick = false;
	bool isMoving = false;
	private Animator animator;
	private Rigidbody2D rb;
	private SpriteRenderer spriteRenderer;
	public Vector2 targetPosition;
	public Vector2 relativePosition;
	private Vector2 movement;
	private Rigidbody2D rigidbodyComponent;
	SaveRoomStates saveRoomStates;
	void Awake()
	{
		saveRoomStates = FindAnyObjectByType<SaveRoomStates>();
		SceneManager.activeSceneChanged += OnSceneChanged;
	}
	public GameObject player;
	string activeSceneName;
	void Start()
	{

		animator = GetComponent<Animator>();
		rb = GetComponent<Rigidbody2D>();
		spriteRenderer = GetComponent<SpriteRenderer>();
	}
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Mouse0))
		{
			targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			mouseClick = true;

		}
		if (mouseClick == true)
		{
			relativePosition = new Vector2(
			targetPosition.x - gameObject.transform.position.x, 0);
			isMoving = true;
			if (relativePosition.x < 0)
			{
				spriteRenderer.flipX = true;
			}
			else if (relativePosition.x > 0)
			{
				spriteRenderer.flipX = false;
			}

		}

		if (relativePosition.x < 0.1 && relativePosition.x > -0.1)
		{
			isMoving = false;

		}
		animator.SetBool("Moving", isMoving);

	}
	void FixedUpdate()
	{
		if (mouseClick)
		{
			if (speed.x * Time.deltaTime >= Mathf.Abs(relativePosition.x))
			{
				movement.x = relativePosition.x;

			}
			else
			{
				movement.x = speed.x * Mathf.Sign(relativePosition.x);
			}
			/*if(	speed.y * Time.deltaTime >=  Mathf.Abs(relativePosition.y) ) {
				movement.y = relativePosition.y;
			} else{
				movement.y = speed.y * Mathf.Sign(relativePosition.y);
			}*/

			GetComponent<Rigidbody2D>().linearVelocity = movement;

		}

	}

	SetPlayerPosition setPlayerPosition = new SetPlayerPosition();
	public void OnSceneChanged(Scene current, Scene next)
	{
		setPlayerPosition.SetGroundPosition(SceneManager.GetActiveScene().name, player, saveRoomStates);
	}

}



public class SetPlayerPosition
{
	Vector2 bridgeGroundPosition = new Vector2(-0.34f, -3.8f);
	Vector2 cabinesGroundPosition = new Vector2(5.5f, -3.63f);
	Vector2 canteenGroundPosition = new Vector2(1f, 1.72f);
	Vector2 cryoGroundPosition = new Vector2(-7.5f, -3.76f);
	Vector2 hangarGroundPosition = new Vector2(-1f, -5.51f);
	Vector2 labGroundPosition = new Vector2(0f, -3.8f);
	Vector2 medbayGroundPosition = new Vector2(6.6f, -3.8f);
	Vector2 storageGroundPosition = new Vector2(-2.1f, -1.344f);

	public void SetGroundPosition(string activeSceneName, GameObject player, SaveRoomStates saveRoomStates)
	{
		switch (activeSceneName)
		{
			case "Bridge":
				player.transform.position = bridgeGroundPosition;
				break;
			case "Cabines":
				player.transform.position = cabinesGroundPosition;
				break;
			case "Canteen":
				player.transform.position = canteenGroundPosition;
				break;
			case "Cryo":
				if (saveRoomStates.firstLoad == false)
				{
					player.transform.position = cryoGroundPosition;
				}
				break;
			case "Hangar":
				player.transform.position = hangarGroundPosition;
				break;
			case "Lab":
				player.transform.position = labGroundPosition;
				break;
			case "Medbay":
				player.transform.position = medbayGroundPosition;
				break;
			case "TheStorage":
				player.transform.position = storageGroundPosition;
				break;

		}
	}
}
