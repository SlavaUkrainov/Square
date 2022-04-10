namespace Domain.Entities;

public class Square
{
    public Guid Id { get; set; }
    
    public int Length { get; set; }
    
    public int Width { get; set; }
    
    public int Area { get; set; }
}