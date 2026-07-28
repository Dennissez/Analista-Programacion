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
        Abeja abeja = new Abeja();
        addObject(abeja,108,81);
        Abeja abeja2 = new Abeja();
        addObject(abeja2,101,289);
        Abeja abeja3 = new Abeja(2, "Panal 2");
        addObject(abeja3,289,195);
        abeja3.setAnios(3);
        Abeja abeja4 = new Abeja(2, "Panal 2");
        addObject(abeja4,463,136);
        Abeja abeja5 = new Abeja(1, "Panal 2");
        addObject(abeja5,472,337);
        abeja5.setLocation(488,294);
        abeja.getPanal();
        abeja3.getAnios();
        abeja.obtenerDatos();
        abeja5.setPanal("Panal 3");
        abeja5.getAnios();
        abeja5.setAnios(2);
        abeja5.obtenerDatos();
    }
}
