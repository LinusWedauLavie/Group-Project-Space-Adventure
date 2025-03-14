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
    SetPlayerPosition setPlayerPosition;
    public GameObject player;
    string activeSceneName;
   public void Start()   
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

        if (mouseClick)
        {
            relativePosition = new Vector2(targetPosition.x - transform.position.x, 0);
            isMoving = true;
            spriteRenderer.flipX = relativePosition.x < 0;
        }
         if (Mathf.Abs(relativePosition.x) < 0.1f)
            {
            isMoving = false;
            }

            animator.SetBool("Moving", isMoving);

		/*if (Input.GetKeyDown(KeyCode.Mouse0) && saveRoomStates.medbayScan == false)
		{
			Debug.Log(saveRoomStates.medbayScan);
			targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			mouseClick = true;

		}
		if (mouseClick == true && saveRoomStates.medbayScan == false)
		{
			relativePosition = new Vector2(targetPosition.x - gameObject.transform.position.x, 0);
			isMoving = true;
			if (relativePosition.x < 0)
			{
				spriteRenderer.flipX = true;
			}
			else if (relativePosition.x > 0)
			{
				spriteRenderer.flipX = false;
			}
           
        }*/
         
    }



void FixedUpdate()
{
    if (mouseClick)
    {
        movement.x = Mathf.Abs(relativePosition.x) <= speed.x * Time.deltaTime ? relativePosition.x : speed.x * Mathf.Sign(relativePosition.x);
        rb.linearVelocity = movement;
    }
}


    public void OnSceneChanged(Scene current, Scene next)
    {
        player = FindAnyObjectByType<ClickCharacterMove>().gameObject;
        setPlayerPosition.SetGroundPosition(SceneManager.GetActiveScene().name, player, saveRoomStates);
    }


public class SetPlayerPosition : MonoBehaviour
{
    public ClickCharacterMove clickCharacterMove;
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
        if (clickCharacterMove == null) { clickCharacterMove = FindAnyObjectByType<ClickCharacterMove>(); }
        switch (activeSceneName)
        {
            case "Bridge":
                player.transform.position = bridgeGroundPosition;
                clickCharacterMove.targetPosition = bridgeGroundPosition;
                break;
            case "Cabines":
                player.transform.position = cabinesGroundPosition;
                clickCharacterMove.targetPosition = cabinesGroundPosition;
                break;
            case "Canteen":
                player.transform.position = canteenGroundPosition;
                clickCharacterMove.targetPosition = canteenGroundPosition;
                break;
            case "Cryo":
                if (!saveRoomStates.firstLoad)
                {
                    player.transform.position = cryoGroundPosition;
                    clickCharacterMove.targetPosition = cryoGroundPosition;
                }
                break;
            case "Hangar":
                player.transform.position = hangarGroundPosition;
                clickCharacterMove.targetPosition = hangarGroundPosition;
                break;
            case "Lab":
                player.transform.position = labGroundPosition;
                clickCharacterMove.targetPosition = labGroundPosition;
                break;
            case "Medbay":
                player.transform.position = medbayGroundPosition;
                clickCharacterMove.targetPosition = medbayGroundPosition;
                break;
            case "TheStorage":
                player.transform.position = storageGroundPosition;
                clickCharacterMove.targetPosition = storageGroundPosition;
                break;
        }
    }
}

}