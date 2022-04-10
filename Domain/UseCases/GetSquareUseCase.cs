using Domain.Entities;
using Domain.Repository;

namespace Domain.UseCases;

public class GetSquareUseCase
{
    private readonly IRepository<Square> squares;

    public GetSquareUseCase(IRepository<Square> squares)
    {
        this.squares = squares;
    }

    public int GetSquare(int length, int width)
    {
        //Пробуем найти прямоугольник в базу, если не находим, считаем площадь самостоятельно
        var found = squares.FirstOrDefault(s => s.Length == length && s.Width == width);
        
        if (found != null)
            return found.Area;

        var square = new Square { Length = length, Width = width };
        square.Area = square.Length * square.Width;
        squares.Write(square);
        return square.Area;
    }
}