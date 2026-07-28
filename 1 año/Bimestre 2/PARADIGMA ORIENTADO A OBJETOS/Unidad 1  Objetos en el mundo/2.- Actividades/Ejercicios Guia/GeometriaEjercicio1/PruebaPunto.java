public class PruebaPunto  
{
    public PruebaPunto()
    {
    }

    public static void main(String[] args)
    {
        Punto p1 = new Punto();
        Punto p2 = new Punto(100,50);
        System.out.println("Las coordenadas del punto 1 son: (" + 
        p1.getX() + "," + p1.getY() + ")");
        System.out.println("Las coordenadas del punto 2 son: (" + 
        p2.getX() + "," + p2.getY() + ")");
        
    }
}
