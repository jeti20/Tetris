using UnityEngine.Tilemaps;
using UnityEngine;

public enum Tetromino //Enum jest typem wyliczeniowy, który s³u¿y do przechowywania wartoœci sta³ych
{
    I, J, L, O, S, T, Z
}

[System.Serializable] //sprawia, ¿e wyœwietla listê w Unity na obiekcie na którym jest dodany skrypt
public struct TetrominoData// jak tutaj dopisszemy zmienn¹ to ona pojawia siê w Unity
{
    public Tile tile;
    public Tetromino tetromino;
    public Vector2Int[] cells { get; private set; } //kszta³t kolcków  { get; private set; } -> sprawi, ¿e pomimo serializable to nie pokazuje w unity tego
    public Vector2Int[,] wallKicks { get; private set; }

    public void Initialize()
    {
        this.cells = Data.Cells[this.tetromino]; //odwo³uje siê do skryptu Data z zapisanymi kszta³tami. Data.Cells this.tetromino wskazuje na "key"
        this.wallKicks = Data.WallKicks[this.tetromino]; //odwo³uje siê do skryptu Data z zapisanymi kszta³tami. Data.Cells this.tetromino wskazuje na "key" w tym przypadku WallKicks
    }
  

}
