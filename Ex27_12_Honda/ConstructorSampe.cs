using System;
using ConsoleUtility;

namespace ConstructorSampe
{
    class ConstructorSampeMain
    {
        static void Main(string[] args)
        {
            Console.WriteLine("三角形の３辺の長さＡ,Ｂ,Ｃを入力してください。");
            Triangle triangle = new Triangle(
                InteractiveInput.InputFloat("辺Ａの長さ："),
                InteractiveInput.InputFloat("辺Ｂの長さ："),
                InteractiveInput.InputFloat("辺Ｃの長さ："));
            Console.WriteLine($"面積は{triangle.GetSurface()}");
        }
    }
}
