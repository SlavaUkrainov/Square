using Domain.UseCases;
using Microsoft.Extensions.DependencyInjection;
using Presentation;

Console.WriteLine("Введите длину и ширину через пробел");
var values = Console.ReadLine().Split();
var serviceProvider = new DependencyInjectionModule().GetServiceProvider();
var useCase = serviceProvider.GetService<GetSquareUseCase>();
var area = useCase.GetSquare(int.Parse(values[0]), int.Parse(values[1]));
Console.WriteLine(area);