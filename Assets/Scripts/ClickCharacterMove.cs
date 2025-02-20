using UnityEngine;

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
    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
		spriteRenderer = GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))	
		{	
			targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mouseClick = true;
			
		}
        if(mouseClick == true){
		    relativePosition = new Vector2(
			targetPosition.x - gameObject.transform.position.x, 0 );
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
			
		if (relativePosition.x < 0.1 && relativePosition.x > -0.1 )
			{
				isMoving = false;
				
			}
		animator.SetBool("Moving", isMoving);

    }
    void FixedUpdate()
	{
    	if (mouseClick){
        if(	speed.x * Time.deltaTime >=  Mathf.Abs(relativePosition.x)) {
			movement.x = relativePosition.x;	

		} else{
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
}
