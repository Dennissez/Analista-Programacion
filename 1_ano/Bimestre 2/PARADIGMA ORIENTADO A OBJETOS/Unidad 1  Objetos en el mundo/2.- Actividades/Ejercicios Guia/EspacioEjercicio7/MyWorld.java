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
        Cohete cohete = new Cohete();
        addObject(cohete,135,95);
        Cohete cohete2 = new Cohete(30, 45);
        addObject(cohete2,316,308);
        cohete.getAnguloGiro();
        cohete.setAnguloGiro(60);
        cohete.setCantidadAvance(200);
        cohete2.setAnguloGiro(-108);
        cohete2.setCantidadAvance(100);
        Meteorito meteorito = new Meteorito();
        addObject(meteorito,75,174);
        Meteorito meteorito2 = new Meteorito();
        addObject(meteorito2,497,283);
        cohete.setAnguloGiro(120);
        cohete.setCantidadAvance(150);
    }
}
