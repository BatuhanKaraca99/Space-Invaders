using UnityEngine;

public class Invaders : MonoBehaviour
{
    public Invader[] prefabs;
    public int rows = 5;
    public int columns = 11;

    private void Awake()
    {
        for (int row = 0; row < this.rows; row++)
        {
            //total width and height
            float width = 2.0f * (this.columns - 1);
            float height = 2.0f * (this.rows - 1);
            Vector2 centering = new Vector2(-width / 2, -height / 2); //center
            Vector3 rowPosition = new Vector3(centering.x,centering.y + (row * 2.0f), 0.0f);

            for(int col = 0; col < this.columns; col++)
            {
                Invader invader = Instantiate(this.prefabs[row], this.transform);
                Vector3 position = rowPosition;
                position.x += col * 2.0f; //column+spacing
                invader.transform.localPosition = position; //local position
            }
        }
    }
}
