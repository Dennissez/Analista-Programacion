import greenfoot.*;  // (World, Actor, GreenfootImage, Greenfoot and MouseInfo)

/**
 * Write a description of class MyWorld here.
 * 
 * @author (your name) 
 * @version (a version number or a date)
 */
public class MyWorld extends World
{

    /**
     * Constructor for objects of class MyWorld.
     * 
     */
    public MyWorld()
    {    
        // Create a new world with 600x400 cells with a cell size of 1x1 pixels.
        super(600, 400, 1); 
        prepare();
    }
    
    /**
     * Prepare the world for the start of the program.
     * That is: create the initial objects and add them to the world.
     */
    private void prepare()
    {
        Edificio edificio = new Edificio();
        addObject(edificio,120,71);
        Edificio edificio2 = new Edificio(10, 5, "Constructora Independiente", true);
        addObject(edificio2,174,320);
        Edificio edificio3 = new Edificio(7, 2, "Constructora Nacional", false);
        addObject(edificio3,437,158);
        edificio3.setLocation(446,69);
        edificio2.setLocation(189,319);
        edificio2.setLocation(131,316);
        Carro carro = new Carro();
        addObject(carro,106,221);
        carro.setLocation(87,215);
        carro.setLocation(116,146);
        Carro carro2 = new Carro();
        addObject(carro2,275,148);
        Carro carro3 = new Carro();
        addObject(carro3,444,146);
        Carro carro4 = new Carro();
        addObject(carro4,359,247);
        Carro carro5 = new Carro();
        addObject(carro5,202,247);
        carro4.turn(180);
        carro5.turn(180);
    }
}
