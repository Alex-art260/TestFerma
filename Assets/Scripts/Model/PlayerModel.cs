using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerModel : BaseModel
{
    public override Vector2 directionVector2 { get; set; }

    private const int _minimumBombsCounter = 0;
    private const int _maximumBombsCounter = 3;

    private int _bombsAmount { get; set; }

    private List<GameObject> _bombs { get; set; }

    public List<GameObject> Bombs => _bombs;

    public int MinimumBombsCounter => _minimumBombsCounter;
    public int MaximumBombsCounter => _maximumBombsCounter;

    public int BombsAmount 
    { 
        get => _bombsAmount;
        set => _bombsAmount = value;
    } 

}
