using UnityEngine.Tilemaps;
using UnityEngine;

public enum Tetromino //Enum jest typem wyliczeniowy, kt�ry s�u�y do przechowywania warto�ci sta�ych
{
    I, J, L, O, S, T, Z
}

[System.Serializable] //sprawia, �e wy�wietla list� w Unity na obiekcie na kt�rym jest dodany skrypt
public struct TetrominoData// jak tutaj dopisszemy zmienn� to ona pojawia si� w Unity
{
    public Tile tile;
    public Tetromino tetromino;
    public Vector2Int[] cells { get; private set; } //kszta�t kolck�w  { get; private set; } -> sprawi, �e pomimo serializable to nie pokazuje w unity tego
    public Vector2Int[,] wallKicks { get; private set; }

    public void Initialize()
    {
        this.cells = Data.Cells[this.tetromino]; //odwo�uje si� do skryptu Data z zapisanymi kszta�tami. Data.Cells this.tetromino wskazuje na "key"
        this.wallKicks = Data.WallKicks[this.tetromino]; //odwo�uje si� do skryptu Data z zapisanymi kszta�tami. Data.Cells this.tetromino wskazuje na "key" w tym przypadku WallKicks
    }
  

}
