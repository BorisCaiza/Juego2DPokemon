using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[CreateAssetMenu(fileName = "Move", menuName = "Pokemon/Nuevo Movimiento")]
public class MoveBase : ScriptableObject
{
    [SerializeField] private string name;

    public string Name => name;

    [TextArea] [SerializeField] private string description;
    
    public string Description => description;

    [SerializeField] private PokemonType type;

    [SerializeField] private int power;
    
    [SerializeField] private int accuaracy;
    
    [SerializeField] private int pp;
    
    public PokemonType Type => type;
    public int Power => power;
    public int Accuaracy => accuaracy;
    public int Pp => pp;

}
