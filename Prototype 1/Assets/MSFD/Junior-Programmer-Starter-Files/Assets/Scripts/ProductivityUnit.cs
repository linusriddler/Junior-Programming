using UnityEngine;

public abstract class ProductivityUnit : Unit
{
    public float speed = 1.0f;
    private ResourcePile m_CurrentPile = null;

    protected abstract override void BuildingInRange(); 

}