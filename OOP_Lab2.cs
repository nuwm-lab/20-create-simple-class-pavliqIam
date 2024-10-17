using System;

class MaterialPoint
{
    private float x0, y0, z0;
    private float vx, vy, vz;

    public MaterialPoint(float x0, float y0, float z0, float vx, float vy, float vz)
    {
        this.x0 = x0;
        this.y0 = y0;
        this.z0 = z0;
        this.vx = vx;
        this.vy = vy;
        this.vz = vz;
    }
    public void CalculatePosition(float t)
    {
        float x = x0 + vx * t;
        float y = y0 + vy * t;
        float z = z0 + vz * t;

        Console.WriteLine($"After time t = {t}, new coordinates: ({x}, {y}, {z})");

        if (x > 0 && y > 0 && z > 0)
        {
            Console.WriteLine("The point is in the first octant.");
        }
        else
        {
            Console.WriteLine("The point is NOT in the first octant.");
        }
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter the starting coords (x0, y0, z0): \n");
        float x0 = float.Parse(Console.ReadLine());
        float y0 = float.Parse(Console.ReadLine());
        float z0 = float.Parse(Console.ReadLine());

        Console.Write("Enter the components of the velocity vector (vx, vy, vz): \n");
        float vx = float.Parse(Console.ReadLine());
        float vy = float.Parse(Console.ReadLine());
        float vz = float.Parse(Console.ReadLine());

        MaterialPoint point = new MaterialPoint(x0, y0, z0, vx, vy, vz);

        Console.Write("Enter time t: \n");
        float t = float.Parse(Console.ReadLine());

        point.CalculatePosition(t);
    }
}